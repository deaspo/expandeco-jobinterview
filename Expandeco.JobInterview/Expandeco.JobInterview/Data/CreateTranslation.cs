using Microsoft.IdentityModel.Tokens;
using System;
using System.IO;

namespace Expandeco.JobInterview.Data {
    public record CreateTranslationRequest(string Title, string Text, int SourceLanguageId, int TargetLanguageId, string deadline)
    {
        public void Validate()
        {
            if (string.IsNullOrEmpty(Title)) throw new ArgumentNullException();
            if (string.IsNullOrEmpty(Text)) throw new ArgumentNullException();
        }
    }
}