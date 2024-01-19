using Expandeco.JobInterview.Data;
using Expandeco.JobInterview.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

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

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var loggedUser = _loggedUserService.Get();
            var typeId = loggedUser.TypeId;

            var result = _dbContext.Translations
                .Include(x => x.SourceLanguage)
                .Include(x => x.TargetLanguage)
                .Include(x => x.CreatedBy)
                .Include(x => x.AssignedTo)
                .Where(x => x.AssignedToId ==typeId || x.CreatedById == typeId || typeId == 1)
                .FirstOrDefault(x => x.Id == id);

            if (result == null)
                return NotFound();
            

            return Ok(result);
        }
    }
}
