using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiRestAPiC_.Services
{
    public interface IGeminiService
    {
        Task<string> GenerateContentAsync(string text);
    }
}
