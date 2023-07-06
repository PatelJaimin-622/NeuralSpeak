using System.ComponentModel.DataAnnotations.Schema;

namespace NeuralSpeak.Web.Data.Entities
{
    public class UserHistory
    {
        public int UserHistoryId { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string FileUrl { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string SourceLanguage { get; set; }
        public string DestinationLanguage { get; set; }
    }
}
