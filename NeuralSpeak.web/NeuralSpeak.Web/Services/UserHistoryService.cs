using Microsoft.EntityFrameworkCore;
using NeuralSpeak.Web.Data;
using NeuralSpeak.Web.Data.Entities;
using NeuralSpeak.Web.Models;

namespace NeuralSpeak.Web.Services
{
    public class UserHistoryService : IUserHistoryService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserHistoryService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

        }
        public async Task<UserHistory> GetById(int id)
        {
            return await _applicationDbContext.UserHistory.FindAsync(id);
        }

        public async Task Add(UserHistory  userHistory)
        {
            _applicationDbContext.UserHistory.Add(userHistory);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteBy(int id)
        {
            UserHistory userHistory = await _applicationDbContext.UserHistory.FindAsync(id);
            if (userHistory != null)
            {
                _applicationDbContext.UserHistory.Remove(userHistory);
                await _applicationDbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<UserAudioView>> GetByUserId(string userId)
        {
            return await _applicationDbContext.UserHistory.Where(x => x.UserId == userId).Select(userHistory => new UserAudioView
            {
                // Map the properties from UserHistory to UserAudioView
                UserHistoryId = userHistory.UserHistoryId,
                UserId = userHistory.UserId,
                FileUrl = userHistory.FileUrl,
                CreatedDate = userHistory.CreatedDate,
                SourceLanguage = userHistory.SourceLanguage,
                DestinationLanguage = userHistory.DestinationLanguage,
                // Add more properties as needed
            }).ToListAsync();
        }

    }

    public interface IUserHistoryService
    {
        Task<UserHistory> GetById(int id);
        Task<bool> DeleteBy(int id);
        Task<List<UserAudioView>> GetByUserId(string userId);
        Task Add(UserHistory userHistory);
    }
}
