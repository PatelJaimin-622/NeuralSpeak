using NeuralSpeak.Web.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NeuralSpeak.Web.Models
{
    public class UserAudioView:UserHistory
    {

        public int UserHistoryId { get; set; }
        public string UserId { get; set; }
        public string FileUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SourceLanguage { get; set; }
        public string DestinationLanguage { get; set; }
    }



}
