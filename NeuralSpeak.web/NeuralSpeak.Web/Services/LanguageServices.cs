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
            return await _applicationDbContext.Language.Where(x => x.Locale != null && x.Locale.ToLower() != "n/a")
                                                        .Select(x => new Languages
                                                        {
                                                            Name = x.LocaleName + " (" + x.LocalName + ")",
                                                            Code = x.Locale,
                                                            Voice = x.ShortName
                                                        }).ToListAsync();
        }
    }
    public interface ILanguageServices
    {
        Task<List<Languages>> GetLanguages();
    }
}
