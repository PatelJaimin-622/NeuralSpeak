using Microsoft.EntityFrameworkCore;
using NeuralSpeak.Web.Data;
using NeuralSpeak.Web.Models;

namespace NeuralSpeak.Web.Services
{
    public class LanguageServices : ILanguageServices
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public LanguageServices(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

        }

        public async Task<List<Languages>> GetLanguages()
        {
            return await _applicationDbContext.Language
                                              .Where(x => x.Locale != null
                                                    && x.Locale.ToLower() != "n/a"
                                                    && x.LocaleName != null
                                                    && x.ShortName != null
                                                    && x.LocalName != null
                                                    && x.Gender.ToLower() == "male"
                                                    )
                                              .GroupBy(x => x.Locale)
                                              .Select(x => new Languages
                                              {
                                                  Name = x.FirstOrDefault().LocaleName + " (" + x.FirstOrDefault().LocalName + ")",
                                                  Code = x.Key,
                                                  Voice = x.FirstOrDefault().ShortName
                                              }).ToListAsync();
        }
    }
    public interface ILanguageServices
    {
        Task<List<Languages>> GetLanguages();
    }
}
