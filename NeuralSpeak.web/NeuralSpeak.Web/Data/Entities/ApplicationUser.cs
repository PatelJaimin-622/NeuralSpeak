using Microsoft.AspNetCore.Identity;

namespace NeuralSpeak.Web.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<UserHistory> UserHistories { get; set; }
    }
}
