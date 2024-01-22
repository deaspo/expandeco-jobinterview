using System;

namespace Expandeco.JobInterview.Data
{
    public record UpdateTranslationRequest
        (
        string Title,
        string Text,
        int SourceLanguageId, 
        int TargetLanguageId,
        string translatedText,
        int? assignedToId,
        int translationId
        )
    {
        public void Validate()
        {
            if (string.IsNullOrEmpty(Title)) throw new ArgumentNullException();
            if (string.IsNullOrEmpty(Text)) throw new ArgumentNullException();
        }
    }
}