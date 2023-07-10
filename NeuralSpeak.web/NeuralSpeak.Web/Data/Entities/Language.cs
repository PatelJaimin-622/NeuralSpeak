using System.ComponentModel.DataAnnotations;

namespace NeuralSpeak.Web.Data.Entities
{
    public class Language
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; } = "N/a";
        public string DisplayName { get; set; } = "N/a";
        public string LocalName { get; set; } = "N/a";
        public string ShortName { get; set; } = "N/a";
        public string Gender { get; set; } = "N/a";
        public string Locale { get; set; } = "N/a";
        public string LocaleName { get; set; } = "N/a";
        public string SampleRateHertz { get; set; } = "N/a";
        public string VoiceType { get; set; } = "N/a";
        public string Status { get; set; } = "N/a";
        public string WordsPerMinute { get; set; } = "N/a";
    }
}
