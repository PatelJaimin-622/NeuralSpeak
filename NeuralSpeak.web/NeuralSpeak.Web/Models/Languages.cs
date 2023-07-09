namespace NeuralSpeak.Web.Models
{
    public class Languages
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Voice { get; set; }

    public static List<Languages> langList = new List<Languages>()
    {
        new Languages(){ Name="Afrikaans (South Africa)", Code = "af-ZA" , Voice = "af-ZA-WillemNeural" },
        new Languages(){ Name="English (United States)", Code = "en-US" , Voice = "en-US-GuyNeural" },
        new Languages(){ Name="Spanish (Argentina)", Code = "es-AR" , Voice = "es-AR-TomasNeural" },
        new Languages(){ Name="hindi (India)", Code = "hi-IN" , Voice = "hi-IN-MadhurNeural" },
        new Languages(){ Name="Gujarati (India)", Code = "gu-IN" , Voice = "gu-IN-NiranjanNeural" },
    };

    };

}
