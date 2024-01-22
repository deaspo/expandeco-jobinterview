using Expandeco.JobInterview.Data;
using Expandeco.JobInterview.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Expandeco.JobInterview.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TranslationsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<TranslationsController> _logger;
        private readonly ILoggedUserService _loggedUserService;

        public TranslationsController(ApplicationDbContext dbContext, ILogger<TranslationsController> logger, ILoggedUserService loggedUserService)
        {
            _dbContext = dbContext;
            _logger = logger;
            _loggedUserService = loggedUserService;
        }

        [HttpGet]
        public IEnumerable<Translation> Get()
        {
            var loggedUser = _loggedUserService.Get();
            var results = _dbContext.Translations
                .Include(x => x.SourceLanguage)
                .Include(x => x.TargetLanguage)
                .Include(x => x.CreatedBy)
                .Include(x => x.AssignedTo)
                .Include(x => x.Deadline)
                .ToArray();
            
            switch (loggedUser.TypeId)
            {
                case 1:
                    return results;
                case 2:
                    return results.Where(x => x.AssignedToId == loggedUser.Id);
                case 3:
                    return results.Where(x => x.CreatedById == loggedUser.Id);
                default:
                    return Enumerable.Empty<Translation>();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var loggedUser = _loggedUserService.Get();
            var typeId = loggedUser.TypeId;

            var result = _dbContext.Translations
                .Include(x => x.SourceLanguage)
                .Include(x => x.TargetLanguage)
                .Include(x => x.CreatedBy)
                .Include(x => x.AssignedTo)
                .Include(x => x.Deadline)
                .Where(x => x.AssignedToId == loggedUser.Id || x.CreatedById == loggedUser.Id || typeId == 1)
                .FirstOrDefault(x => x.Id == id);

            if (result == null)
                return NotFound();
            

            return Ok(result);
        }

        [HttpPost("create")]
        [ProducesResponseType(200, Type = typeof(string))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult Create([FromBody] CreateTranslationRequest createTranslationRequest)
        {
            createTranslationRequest.Validate();
            var loggedUser = _loggedUserService.Get();
            var creator = _dbContext.Users.Include(x => x.Type).FirstOrDefault(x => x.Id == loggedUser.Id);
            var sourceLanguage = _dbContext.Languages.Find(createTranslationRequest.SourceLanguageId);
            var targetLanguage = _dbContext.Languages.Find(createTranslationRequest.TargetLanguageId);

            var expiredDeadline = DateTime.Parse(createTranslationRequest.deadline).CompareTo(DateTime.UtcNow) < 0;

            var deadline = new Deadline {
                DeadlineDateTimeString = DateTime.Parse(createTranslationRequest.deadline, CultureInfo.InvariantCulture).ToString("s"),
                DeadlineDateTime = DateTime.Parse(createTranslationRequest.deadline, CultureInfo.InvariantCulture),
                ExpiredDeadline = expiredDeadline
            };

            var entity = new Translation {
                Title = createTranslationRequest.Title,
                Text = createTranslationRequest.Text,
                SourceLanguageId = sourceLanguage.Id,
                TargetLanguageId = targetLanguage.Id,
                CreatedById = loggedUser.Id,
                CreatedBy = creator,
                SourceLanguage = sourceLanguage,
                TargetLanguage = targetLanguage,
                DeadlineString = deadline.DeadlineDateTime.ToString("f"),
                Deadline = deadline
            };

            _dbContext.Translations.Add(entity);
            _dbContext.SaveChanges();

            return Ok(entity);
        }

        [HttpPatch("update")]
        public IActionResult Update([FromBody] UpdateTranslationRequest updateTranslationRequest) {
            updateTranslationRequest.Validate();

            var loggedUser = _loggedUserService.Get();
            var typeId = loggedUser.TypeId;

            var translation = _dbContext.Translations.Include(x => x.SourceLanguage)
                .Include(x => x.TargetLanguage)
                .Include(x => x.CreatedBy)
                .Include(x => x.AssignedTo)
                .FirstOrDefault(x => x.Id == updateTranslationRequest.translationId);

            switch (typeId)
            {
                case 1:
                    // Manager Edits
                    // Assigned translator
                    if (updateTranslationRequest.assignedToId != null) {
                        var assigned = _dbContext.Users.Include(x => x.Type).FirstOrDefault(x => x.Id == updateTranslationRequest.assignedToId);

                        translation.AssignedTo = assigned;
                        translation.AssignedToId = assigned.Id;
                    }

                    break;
                case 2:
                    // Assigned Edits
                    // Translated texts
                    if (!string.IsNullOrEmpty(updateTranslationRequest.Text)) translation.TranslatedText = updateTranslationRequest.translatedText;

                    break;
                case 3:
                    // Client Edits
                    var sourceLanguage = _dbContext.Languages.FirstOrDefault(x => x.Id == updateTranslationRequest.SourceLanguageId);
                    var targetLanguage = _dbContext.Languages.FirstOrDefault(x => x.Id == updateTranslationRequest.TargetLanguageId);
                    // Title. Text, Source lang, Target lang
                    translation.Title = updateTranslationRequest.Title;
                    translation.Text = updateTranslationRequest.Text;
                    translation.SourceLanguage = sourceLanguage;
                    translation.TargetLanguage = targetLanguage;
                    translation.SourceLanguageId = sourceLanguage.Id;
                    translation.TargetLanguageId = targetLanguage.Id;

                    break;
            }

            _dbContext.Translations.Update(translation);
            _dbContext.SaveChanges();

            return Ok(translation);
        }
    }
}
