using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NeuralSpeak.Web.Data.Entities;

namespace NeuralSpeak.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
   : base(options)
        {
        }
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        public virtual DbSet<UserHistory> UserHistory { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            ApplicationDbContext applicationDbContext = serviceProvider.GetRequiredService<ApplicationDbContext>();

            if (!applicationDbContext.Language.Any())
            {
                List<Language> languages = new List<Language>
            {
                    new Language()
                    {
                        Name = "af-ZA, AdriNeural",
                        DisplayName = "Adri",
                        LocalName = "Adri",
                        ShortName = "af-ZA-AdriNeural",
                        Gender = "Female",
                        Locale = "af-ZA",
                        LocaleName = "Afrikaans South Africa",
                        VoiceType = "Neural",
                        Status = "GA",
                        WordsPerMinute = "147"
                    },
   new Language()
   {
       Name = "af-ZA, WillemNeural",
       DisplayName = "Willem",
       LocalName = "Willem",
       ShortName = "af-ZA-WillemNeural",
       Gender = "Male",
       Locale = "af-ZA",
       LocaleName = "Afrikaans South Africa",
       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "am-ET, MekdesNeural",
       DisplayName = "Mekdes",
       LocalName = "መቅደስ",
       ShortName = "am-ET-MekdesNeural",
       Gender = "Female",
       Locale = "am-ET",
       LocaleName = "Amharic Ethiopia",
       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "117"
   },
   new Language()
   {
       Name = "am-ET, AmehaNeural",
       DisplayName = "Ameha",
       LocalName = "አምሀ",
       ShortName = "am-ET-AmehaNeural",
       Gender = "Male",
       Locale = "am-ET",
       LocaleName = "Amharic Ethiopia",
       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "112"
   },
   new Language()
   {
       Name = "ar-AE, FatimaNeural",
       DisplayName = "Fatima",
       LocalName = "فاطمة",
       ShortName = "ar-AE-FatimaNeural",
       Gender = "Female",
       Locale = "ar-AE",
       LocaleName = "Arabic United Arab Emirates",
       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "110"
   },
   new Language()
   {
       Name = "ar-AE, HamdanNeural",
       DisplayName = "Hamdan",
       LocalName = "حمدان",
       ShortName = "ar-AE-HamdanNeural",
       Gender = "Male",
       Locale = "ar-AE",
       LocaleName = "Arabic United Arab Emirates",
       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "115"
   },
   new Language()
   {
       Name = "ar-BH, LailaNeural",
       DisplayName = "Laila",
       LocalName = "ليلى",
       ShortName = "ar-BH-LailaNeural",
       Gender = "Female",
       Locale = "ar-BH",
       LocaleName = "Arabic Bahrain",
       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "108"
   },
   new Language()
   {
       Name = "ar-BH, AliNeural",
       DisplayName = "Ali",
       LocalName = "علي",
       ShortName = "ar-BH-AliNeural",
       Gender = "Male",
       Locale = "ar-BH",
       LocaleName = "Arabic Bahrain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "121"
   },
   new Language()
   {
       Name = "ar-DZ, AminaNeural",
       DisplayName = "Amina",
       LocalName = "أمينة",
       ShortName = "ar-DZ-AminaNeural",
       Gender = "Female",
       Locale = "ar-DZ",
       LocaleName = "Arabic Algeria",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "110"
   },
   new Language()
   {
       Name = "ar-DZ, IsmaelNeural",
       DisplayName = "Ismael",
       LocalName = "إسماعيل",
       ShortName = "ar-DZ-IsmaelNeural",
       Gender = "Male",
       Locale = "ar-DZ",
       LocaleName = "Arabic Algeria",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "115"
   },
   new Language()
   {
       Name = "ar-EG, SalmaNeural",
       DisplayName = "Salma",
       LocalName = "سلمى",
       ShortName = "ar-EG-SalmaNeural",
       Gender = "Female",
       Locale = "ar-EG",
       LocaleName = "Arabic Egypt",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "103"
   },
   new Language()
   {
       Name = "ar-EG, ShakirNeural",
       DisplayName = "Shakir",
       LocalName = "شاكر",
       ShortName = "ar-EG-ShakirNeural",
       Gender = "Male",
       Locale = "ar-EG",
       LocaleName = "Arabic Egypt",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "115"
   },
   new Language()
   {
       Name = "ar-IQ, RanaNeural",
       DisplayName = "Rana",
       LocalName = "رنا",
       ShortName = "ar-IQ-RanaNeural",
       Gender = "Female",
       Locale = "ar-IQ",
       LocaleName = "Arabic Iraq",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "98"
   },
   new Language()
   {
       Name = "ar-IQ, BasselNeural",
       DisplayName = "Bassel",
       LocalName = "باسل",
       ShortName = "ar-IQ-BasselNeural",
       Gender = "Male",
       Locale = "ar-IQ",
       LocaleName = "Arabic Iraq",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "113"
   },
   new Language()
   {
       Name = "ar-JO, SanaNeural",
       DisplayName = "Sana",
       LocalName = "سناء",
       ShortName = "ar-JO-SanaNeural",
       Gender = "Female",
       Locale = "ar-JO",
       LocaleName = "Arabic Jordan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "98"
   },
   new Language()
   {
       Name = "ar-JO, TaimNeural",
       DisplayName = "Taim",
       LocalName = "تيم",
       ShortName = "ar-JO-TaimNeural",
       Gender = "Male",
       Locale = "ar-JO",
       LocaleName = "Arabic Jordan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "113"
   },
   new Language()
   {
       Name = "ar-KW, NouraNeural",
       DisplayName = "Noura",
       LocalName = "نورا",
       ShortName = "ar-KW-NouraNeural",
       Gender = "Female",
       Locale = "ar-KW",
       LocaleName = "Arabic Kuwait",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "121"
   },
   new Language()
   {
       Name = "ar-KW, FahedNeural",
       DisplayName = "Fahed",
       LocalName = "فهد",
       ShortName = "ar-KW-FahedNeural",
       Gender = "Male",
       Locale = "ar-KW",
       LocaleName = "Arabic Kuwait",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "128"
   },
   new Language()
   {
       Name = "ar-LB, LaylaNeural",
       DisplayName = "Layla",
       LocalName = "ليلى",
       ShortName = "ar-LB-LaylaNeural",
       Gender = "Female",
       Locale = "ar-LB",
       LocaleName = "Arabic Lebanon",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "99"
   },
   new Language()
   {
       Name = "ar-LB, RamiNeural",
       DisplayName = "Rami",
       LocalName = "رامي",
       ShortName = "ar-LB-RamiNeural",
       Gender = "Male",
       Locale = "ar-LB",
       LocaleName = "Arabic Lebanon",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "101"
   },
   new Language()
   {
       Name = "ar-LY, ImanNeural",
       DisplayName = "Iman",
       LocalName = "إيمان",
       ShortName = "ar-LY-ImanNeural",
       Gender = "Female",
       Locale = "ar-LY",
       LocaleName = "Arabic Libya",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "108"
   },
   new Language()
   {
       Name = "ar-LY, OmarNeural",
       DisplayName = "Omar",
       LocalName = "أحمد",
       ShortName = "ar-LY-OmarNeural",
       Gender = "Male",
       Locale = "ar-LY",
       LocaleName = "Arabic Libya",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "111"
   },
   new Language()
   {
       Name = "ar-MA, MounaNeural",
       DisplayName = "Mouna",
       LocalName = "منى",
       ShortName = "ar-MA-MounaNeural",
       Gender = "Female",
       Locale = "ar-MA",
       LocaleName = "Arabic Morocco",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "121"
   },
   new Language()
   {
       Name = "ar-MA, JamalNeural",
       DisplayName = "Jamal",
       LocalName = "جمال",
       ShortName = "ar-MA-JamalNeural",
       Gender = "Male",
       Locale = "ar-MA",
       LocaleName = "Arabic Morocco",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "128"
   },
   new Language()
   {
       Name = "ar-OM, AyshaNeural",
       DisplayName = "Aysha",
       LocalName = "عائشة",
       ShortName = "ar-OM-AyshaNeural",
       Gender = "Female",
       Locale = "ar-OM",
       LocaleName = "Arabic Oman",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "118"
   },
   new Language()
   {
       Name = "ar-OM, AbdullahNeural",
       DisplayName = "Abdullah",
       LocalName = "عبدالله",
       ShortName = "ar-OM-AbdullahNeural",
       Gender = "Male",
       Locale = "ar-OM",
       LocaleName = "Arabic Oman",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "123"
   },
   new Language()
   {
       Name = "ar-QA, AmalNeural",
       DisplayName = "Amal",
       LocalName = "أمل",
       ShortName = "ar-QA-AmalNeural",
       Gender = "Female",
       Locale = "ar-QA",
       LocaleName = "Arabic Qatar",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "113"
   },
   new Language()
   {
       Name = "ar-QA, MoazNeural",
       DisplayName = "Moaz",
       LocalName = "معاذ",
       ShortName = "ar-QA-MoazNeural",
       Gender = "Male",
       Locale = "ar-QA",
       LocaleName = "Arabic Qatar",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "114"
   },
   new Language()
   {
       Name = "ar-SA, ZariyahNeural",
       DisplayName = "Zariyah",
       LocalName = "زارية",
       ShortName = "ar-SA-ZariyahNeural",
       Gender = "Female",
       Locale = "ar-SA",
       LocaleName = "Arabic Saudi Arabia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "105"
   },
   new Language()
   {
       Name = "ar-SA, HamedNeural",
       DisplayName = "Hamed",
       LocalName = "حامد",
       ShortName = "ar-SA-HamedNeural",
       Gender = "Male",
       Locale = "ar-SA",
       LocaleName = "Arabic Saudi Arabia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "107"
   },
   new Language()
   {
       Name = "ar-SY, AmanyNeural",
       DisplayName = "Amany",
       LocalName = "أماني",
       ShortName = "ar-SY-AmanyNeural",
       Gender = "Female",
       Locale = "ar-SY",
       LocaleName = "Arabic Syria",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "122"
   },
   new Language()
   {
       Name = "ar-SY, LaithNeural",
       DisplayName = "Laith",
       LocalName = "ليث",
       ShortName = "ar-SY-LaithNeural",
       Gender = "Male",
       Locale = "ar-SY",
       LocaleName = "Arabic Syria",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "133"
   },
   new Language()
   {
       Name = "ar-TN, ReemNeural",
       DisplayName = "Reem",
       LocalName = "ريم",
       ShortName = "ar-TN-ReemNeural",
       Gender = "Female",
       Locale = "ar-TN",
       LocaleName = "Arabic Tunisia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "112"
   },
   new Language()
   {
       Name = "ar-TN, HediNeural",
       DisplayName = "Hedi",
       LocalName = "هادي",
       ShortName = "ar-TN-HediNeural",
       Gender = "Male",
       Locale = "ar-TN",
       LocaleName = "Arabic Tunisia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "118"
   },
   new Language()
   {
       Name = "ar-YE, MaryamNeural",
       DisplayName = "Maryam",
       LocalName = "مريم",
       ShortName = "ar-YE-MaryamNeural",
       Gender = "Female",
       Locale = "ar-YE",
       LocaleName = "Arabic Yemen",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "108"
   },
   new Language()
   {
       Name = "ar-YE, SalehNeural",
       DisplayName = "Saleh",
       LocalName = "صالح",
       ShortName = "ar-YE-SalehNeural",
       Gender = "Male",
       Locale = "ar-YE",
       LocaleName = "Arabic Yemen",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "115"
   },
   new Language()
   {
       Name = "az-AZ, BanuNeural",
       DisplayName = "Banu",
       LocalName = "Banu",
       ShortName = "az-AZ-BanuNeural",
       Gender = "Female",
       Locale = "az-AZ",
       LocaleName = "Azerbaijani Latin, Azerbaijan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "114"
   },
   new Language()
   {
       Name = "az-AZ, BabekNeural",
       DisplayName = "Babek",
       LocalName = "Babək",
       ShortName = "az-AZ-BabekNeural",
       Gender = "Male",
       Locale = "az-AZ",
       LocaleName = "Azerbaijani Latin, Azerbaijan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "114"
   },
   new Language()
   {
       Name = "bg-BG, KalinaNeural",
       DisplayName = "Kalina",
       LocalName = "Калина",
       ShortName = "bg-BG-KalinaNeural",
       Gender = "Female",
       Locale = "bg-BG",
       LocaleName = "Bulgarian Bulgaria",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "125"
   },
   new Language()
   {
       Name = "bg-BG, BorislavNeural",
       DisplayName = "Borislav",
       LocalName = "Борислав",
       ShortName = "bg-BG-BorislavNeural",
       Gender = "Male",
       Locale = "bg-BG",
       LocaleName = "Bulgarian Bulgaria",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "132"
   },
   new Language()
   {
       Name = "bn-BD, NabanitaNeural",
       DisplayName = "Nabanita",
       LocalName = "নবনীতা",
       ShortName = "bn-BD-NabanitaNeural",
       Gender = "Female",
       Locale = "bn-BD",
       LocaleName = "Bangla Bangladesh",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "123"
   },
   new Language()
   {
       Name = "bn-BD, PradeepNeural",
       DisplayName = "Pradeep",
       LocalName = "প্রদ্বীপ",
       ShortName = "bn-BD-PradeepNeural",
       Gender = "Male",
       Locale = "bn-BD",
       LocaleName = "Bangla Bangladesh",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "125"
   },
   new Language()
   {
       Name = "bn-IN, TanishaaNeural",
       DisplayName = "Tanishaa",
       LocalName = "তানিশা",
       ShortName = "bn-IN-TanishaaNeural",
       Gender = "Female",
       Locale = "bn-IN",
       LocaleName = "Bengali India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "123"
   },
   new Language()
   {
       Name = "bn-IN, BashkarNeural",
       DisplayName = "Bashkar",
       LocalName = "ভাস্কর",
       ShortName = "bn-IN-BashkarNeural",
       Gender = "Male",
       Locale = "bn-IN",
       LocaleName = "Bengali India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "131"
   },
   new Language()
   {
       Name = "bs-BA, VesnaNeural",
       DisplayName = "Vesna",
       LocalName = "Vesna",
       ShortName = "bs-BA-VesnaNeural",
       Gender = "Female",
       Locale = "bs-BA",
       LocaleName = "Bosnian Bosnia and Herzegovina",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "135"
   },
   new Language()
   {
       Name = "bs-BA, GoranNeural",
       DisplayName = "Goran",
       LocalName = "Goran",
       ShortName = "bs-BA-GoranNeural",
       Gender = "Male",
       Locale = "bs-BA",
       LocaleName = "Bosnian Bosnia and Herzegovina",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "135"
   },
   new Language()
   {
       Name = "ca-ES, JoanaNeural",
       DisplayName = "Joana",
       LocalName = "Joana",
       ShortName = "ca-ES-JoanaNeural",
       Gender = "Female",
       Locale = "ca-ES",
       LocaleName = "Catalan Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "147"
   },
   new Language()
   {
       Name = "ca-ES, EnricNeural",
       DisplayName = "Enric",
       LocalName = "Enric",
       ShortName = "ca-ES-EnricNeural",
       Gender = "Male",
       Locale = "ca-ES",
       LocaleName = "Catalan Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "ca-ES, AlbaNeural",
       DisplayName = "Alba",
       LocalName = "Alba",
       ShortName = "ca-ES-AlbaNeural",
       Gender = "Female",
       Locale = "ca-ES",
       LocaleName = "Catalan Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "cs-CZ, VlastaNeural",
       DisplayName = "Vlasta",
       LocalName = "Vlasta",
       ShortName = "cs-CZ-VlastaNeural",
       Gender = "Female",
       Locale = "cs-CZ",
       LocaleName = "Czech Czechia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "118"
   },
   new Language()
   {
       Name = "cs-CZ, AntoninNeural",
       DisplayName = "Antonin",
       LocalName = "Antonín",
       ShortName = "cs-CZ-AntoninNeural",
       Gender = "Male",
       Locale = "cs-CZ",
       LocaleName = "Czech Czechia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "cy-GB, NiaNeural",
       DisplayName = "Nia",
       LocalName = "Nia",
       ShortName = "cy-GB-NiaNeural",
       Gender = "Female",
       Locale = "cy-GB",
       LocaleName = "Welsh United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "136"
   },
   new Language()
   {
       Name = "cy-GB, AledNeural",
       DisplayName = "Aled",
       LocalName = "Aled",
       ShortName = "cy-GB-AledNeural",
       Gender = "Male",
       Locale = "cy-GB",
       LocaleName = "Welsh United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "148"
   },
   new Language()
   {
       Name = "da-DK, ChristelNeural",
       DisplayName = "Christel",
       LocalName = "Christel",
       ShortName = "da-DK-ChristelNeural",
       Gender = "Female",
       Locale = "da-DK",
       LocaleName = "Danish Denmark",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "da-DK, JeppeNeural",
       DisplayName = "Jeppe",
       LocalName = "Jeppe",
       ShortName = "da-DK-JeppeNeural",
       Gender = "Male",
       Locale = "da-DK",
       LocaleName = "Danish Denmark",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "147"
   },
   new Language()
   {
       Name = "de-AT, IngridNeural",
       DisplayName = "Ingrid",
       LocalName = "Ingrid",
       ShortName = "de-AT-IngridNeural",
       Gender = "Female",
       Locale = "de-AT",
       LocaleName = "German Austria",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "128"
   },
   new Language()
   {
       Name = "de-AT, JonasNeural",
       DisplayName = "Jonas",
       LocalName = "Jonas",
       ShortName = "de-AT-JonasNeural",
       Gender = "Male",
       Locale = "de-AT",
       LocaleName = "German Austria",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "130"
   },
   new Language()
   {
       Name = "de-CH, LeniNeural",
       DisplayName = "Leni",
       LocalName = "Leni",
       ShortName = "de-CH-LeniNeural",
       Gender = "Female",
       Locale = "de-CH",
       LocaleName = "German Switzerland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "121"
   },
   new Language()
   {
       Name = "de-CH, JanNeural",
       DisplayName = "Jan",
       LocalName = "Jan",
       ShortName = "de-CH-JanNeural",
       Gender = "Male",
       Locale = "de-CH",
       LocaleName = "German Switzerland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "135"
   },
   new Language()
   {
       Name = "de-DE, KatjaNeural",
       DisplayName = "Katja",
       LocalName = "Katja",
       ShortName = "de-DE-KatjaNeural",
       Gender = "Female",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "121"
   },
   new Language()
   {
       Name = "de-DE, ConradNeural",
       DisplayName = "Conrad",
       LocalName = "Conrad",
       ShortName = "de-DE-ConradNeural",
       Gender = "Male",
       Locale = "de-DE",
       LocaleName = "German Germany",


       VoiceType = "Neural",
       Status = "Preview",
       WordsPerMinute = "128"
   },
   new Language()
   {
       Name = "de-DE, AmalaNeural",
       DisplayName = "Amala",
       LocalName = "Amala",
       ShortName = "de-DE-AmalaNeural",
       Gender = "Female",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "115"
   },
   new Language()
   {
       Name = "de-DE, BerndNeural",
       DisplayName = "Bernd",
       LocalName = "Bernd",
       ShortName = "de-DE-BerndNeural",
       Gender = "Male",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "123"
   },
   new Language()
   {
       Name = "de-DE, ChristophNeural",
       DisplayName = "Christoph",
       LocalName = "Christoph",
       ShortName = "de-DE-ChristophNeural",
       Gender = "Male",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "128"
   },
   new Language()
   {
       Name = "de-DE, ElkeNeural",
       DisplayName = "Elke",
       LocalName = "Elke",
       ShortName = "de-DE-ElkeNeural",
       Gender = "Female",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "114"
   },
   new Language()
   {
       Name = "de-DE, GiselaNeural",
       DisplayName = "Gisela",
       LocalName = "Gisela",
       ShortName = "de-DE-GiselaNeural",
       Gender = "Female",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "110"
   },
   new Language()
   {
       Name = "de-DE, KasperNeural",
       DisplayName = "Kasper",
       LocalName = "Kasper",
       ShortName = "de-DE-KasperNeural",
       Gender = "Male",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "129"
   },
   new Language()
   {
       Name = "de-DE, KillianNeural",
       DisplayName = "Killian",
       LocalName = "Killian",
       ShortName = "de-DE-KillianNeural",
       Gender = "Male",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "126"
   },
   new Language()
   {
       Name = "de-DE, KlarissaNeural",
       DisplayName = "Klarissa",
       LocalName = "Klarissa",
       ShortName = "de-DE-KlarissaNeural",
       Gender = "Female",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "116"
   },
   new Language()
   {
       Name = "de-DE, KlausNeural",
       DisplayName = "Klaus",
       LocalName = "Klaus",
       ShortName = "de-DE-KlausNeural",
       Gender = "Male",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "106"
   },
   new Language()
   {
       Name = "de-DE, LouisaNeural",
       DisplayName = "Louisa",
       LocalName = "Louisa",
       ShortName = "de-DE-LouisaNeural",
       Gender = "Female",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "114"
   },
   new Language()
   {
       Name = "de-DE, MajaNeural",
       DisplayName = "Maja",
       LocalName = "Maja",
       ShortName = "de-DE-MajaNeural",
       Gender = "Female",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "116"
   },
   new Language()
   {
       Name = "de-DE, RalfNeural",
       DisplayName = "Ralf",
       LocalName = "Ralf",
       ShortName = "de-DE-RalfNeural",
       Gender = "Male",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "127"
   },
   new Language()
   {
       Name = "de-DE, TanjaNeural",
       DisplayName = "Tanja",
       LocalName = "Tanja",
       ShortName = "de-DE-TanjaNeural",
       Gender = "Female",
       Locale = "de-DE",
       LocaleName = "German Germany",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "114"
   },
   new Language()
   {
       Name = "el-GR, AthinaNeural",
       DisplayName = "Athina",
       LocalName = "Αθηνά",
       ShortName = "el-GR-AthinaNeural",
       Gender = "Female",
       Locale = "el-GR",
       LocaleName = "Greek Greece",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "156"
   },
   new Language()
   {
       Name = "el-GR, NestorasNeural",
       DisplayName = "Nestoras",
       LocalName = "Νέστορας",
       ShortName = "el-GR-NestorasNeural",
       Gender = "Male",
       Locale = "el-GR",
       LocaleName = "Greek Greece",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "158"
   },
   new Language()
   {
       Name = "en-AU, NatashaNeural",
       DisplayName = "Natasha",
       LocalName = "Natasha",
       ShortName = "en-AU-NatashaNeural",
       Gender = "Female",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "139"
   },
   new Language()
   {
       Name = "en-AU, WilliamNeural",
       DisplayName = "William",
       LocalName = "William",
       ShortName = "en-AU-WilliamNeural",
       Gender = "Male",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "157"
   },
   new Language()
   {
       Name = "en-AU, AnnetteNeural",
       DisplayName = "Annette",
       LocalName = "Annette",
       ShortName = "en-AU-AnnetteNeural",
       Gender = "Female",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "en-AU, CarlyNeural",
       DisplayName = "Carly",
       LocalName = "Carly",
       ShortName = "en-AU-CarlyNeural",
       Gender = "Female",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "137"
   },
   new Language()
   {
       Name = "en-AU, DarrenNeural",
       DisplayName = "Darren",
       LocalName = "Darren",
       ShortName = "en-AU-DarrenNeural",
       Gender = "Male",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "159"
   },
   new Language()
   {
       Name = "en-AU, DuncanNeural",
       DisplayName = "Duncan",
       LocalName = "Duncan",
       ShortName = "en-AU-DuncanNeural",
       Gender = "Male",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "153"
   },
   new Language()
   {
       Name = "en-AU, ElsieNeural",
       DisplayName = "Elsie",
       LocalName = "Elsie",
       ShortName = "en-AU-ElsieNeural",
       Gender = "Female",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "148"
   },
   new Language()
   {
       Name = "en-AU, FreyaNeural",
       DisplayName = "Freya",
       LocalName = "Freya",
       ShortName = "en-AU-FreyaNeural",
       Gender = "Female",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "148"
   },
   new Language()
   {
       Name = "en-AU, JoanneNeural",
       DisplayName = "Joanne",
       LocalName = "Joanne",
       ShortName = "en-AU-JoanneNeural",
       Gender = "Female",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "153"
   },
   new Language()
   {
       Name = "en-AU, KenNeural",
       DisplayName = "Ken",
       LocalName = "Ken",
       ShortName = "en-AU-KenNeural",
       Gender = "Male",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "159"
   },
   new Language()
   {
       Name = "en-AU, KimNeural",
       DisplayName = "Kim",
       LocalName = "Kim",
       ShortName = "en-AU-KimNeural",
       Gender = "Female",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "150"
   },
   new Language()
   {
       Name = "en-AU, NeilNeural",
       DisplayName = "Neil",
       LocalName = "Neil",
       ShortName = "en-AU-NeilNeural",
       Gender = "Male",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "148"
   },
   new Language()
   {
       Name = "en-AU, TimNeural",
       DisplayName = "Tim",
       LocalName = "Tim",
       ShortName = "en-AU-TimNeural",
       Gender = "Male",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "144"
   },
   new Language()
   {
       Name = "en-AU, TinaNeural",
       DisplayName = "Tina",
       LocalName = "Tina",
       ShortName = "en-AU-TinaNeural",
       Gender = "Female",
       Locale = "en-AU",
       LocaleName = "English Australia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "136"
   },
   new Language()
   {
       Name = "en-CA, ClaraNeural",
       DisplayName = "Clara",
       LocalName = "Clara",
       ShortName = "en-CA-ClaraNeural",
       Gender = "Female",
       Locale = "en-CA",
       LocaleName = "English Canada",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "167"
   },
   new Language()
   {
       Name = "en-CA, LiamNeural",
       DisplayName = "Liam",
       LocalName = "Liam",
       ShortName = "en-CA-LiamNeural",
       Gender = "Male",
       Locale = "en-CA",
       LocaleName = "English Canada",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "180"
   },
   new Language()
   {
       Name = "en-GB, SoniaNeural",
       DisplayName = "Sonia",
       LocalName = "Sonia",
       ShortName = "en-GB-SoniaNeural",
       Gender = "Female",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "150"
   },
   new Language()
   {
       Name = "en-GB, RyanNeural",
       DisplayName = "Ryan",
       LocalName = "Ryan",
       ShortName = "en-GB-RyanNeural",
       Gender = "Male",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "161"
   },
   new Language()
   {
       Name = "en-GB, LibbyNeural",
       DisplayName = "Libby",
       LocalName = "Libby",
       ShortName = "en-GB-LibbyNeural",
       Gender = "Female",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "138"
   },
   new Language()
   {
       Name = "en-GB, AbbiNeural",
       DisplayName = "Abbi",
       LocalName = "Abbi",
       ShortName = "en-GB-AbbiNeural",
       Gender = "Female",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "145"
   },
   new Language()
   {
       Name = "en-GB, AlfieNeural",
       DisplayName = "Alfie",
       LocalName = "Alfie",
       ShortName = "en-GB-AlfieNeural",
       Gender = "Male",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "157"
   },
   new Language()
   {
       Name = "en-GB, BellaNeural",
       DisplayName = "Bella",
       LocalName = "Bella",
       ShortName = "en-GB-BellaNeural",
       Gender = "Female",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "146"
   },
   new Language()
   {
       Name = "en-GB, ElliotNeural",
       DisplayName = "Elliot",
       LocalName = "Elliot",
       ShortName = "en-GB-ElliotNeural",
       Gender = "Male",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "150"
   },
   new Language()
   {
       Name = "en-GB, EthanNeural",
       DisplayName = "Ethan",
       LocalName = "Ethan",
       ShortName = "en-GB-EthanNeural",
       Gender = "Male",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "en-GB, HollieNeural",
       DisplayName = "Hollie",
       LocalName = "Hollie",
       ShortName = "en-GB-HollieNeural",
       Gender = "Female",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "144"
   },
   new Language()
   {
       Name = "en-GB, MaisieNeural",
       DisplayName = "Maisie",
       LocalName = "Maisie",
       ShortName = "en-GB-MaisieNeural",
       Gender = "Female",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "141"
   },
   new Language()
   {
       Name = "en-GB, NoahNeural",
       DisplayName = "Noah",
       LocalName = "Noah",
       ShortName = "en-GB-NoahNeural",
       Gender = "Male",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "en-GB, OliverNeural",
       DisplayName = "Oliver",
       LocalName = "Oliver",
       ShortName = "en-GB-OliverNeural",
       Gender = "Male",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "en-GB, OliviaNeural",
       DisplayName = "Olivia",
       LocalName = "Olivia",
       ShortName = "en-GB-OliviaNeural",
       Gender = "Female",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "en-GB, ThomasNeural",
       DisplayName = "Thomas",
       LocalName = "Thomas",
       ShortName = "en-GB-ThomasNeural",
       Gender = "Male",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "en-GB, MiaNeural",
       DisplayName = "Mia",
       LocalName = "Mia",
       ShortName = "en-GB-MiaNeural",
       Gender = "Female",
       Locale = "en-GB",
       LocaleName = "English United Kingdom",

       VoiceType = "Neural",
       Status = "Deprecated"
   },
   new Language()
   {
       Name = "en-HK, YanNeural",
       DisplayName = "Yan",
       LocalName = "Yan",
       ShortName = "en-HK-YanNeural",
       Gender = "Female",
       Locale = "en-HK",
       LocaleName = "English Hong Kong SAR",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "144"
   },
   new Language()
   {
       Name = "en-HK, SamNeural",
       DisplayName = "Sam",
       LocalName = "Sam",
       ShortName = "en-HK-SamNeural",
       Gender = "Male",
       Locale = "en-HK",
       LocaleName = "English Hong Kong SAR",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "140"
   },
   new Language()
   {
       Name = "en-IE, EmilyNeural",
       DisplayName = "Emily",
       LocalName = "Emily",
       ShortName = "en-IE-EmilyNeural",
       Gender = "Female",
       Locale = "en-IE",
       LocaleName = "English Ireland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "135"
   },
   new Language()
   {
       Name = "en-IE, ConnorNeural",
       DisplayName = "Connor",
       LocalName = "Connor",
       ShortName = "en-IE-ConnorNeural",
       Gender = "Male",
       Locale = "en-IE",
       LocaleName = "English Ireland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "146"
   },
   new Language()
   {
       Name = "en-IN, NeerjaNeural",
       DisplayName = "Neerja",
       LocalName = "Neerja",
       ShortName = "en-IN-NeerjaNeural",
       Gender = "Female",
       Locale = "en-IN",
       LocaleName = "English India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "139"
   },
   new Language()
   {
       Name = "en-IN, PrabhatNeural",
       DisplayName = "Prabhat",
       LocalName = "Prabhat",
       ShortName = "en-IN-PrabhatNeural",
       Gender = "Male",
       Locale = "en-IN",
       LocaleName = "English India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "129"
   },
   new Language()
   {
       Name = "en-KE, AsiliaNeural",
       DisplayName = "Asilia",
       LocalName = "Asilia",
       ShortName = "en-KE-AsiliaNeural",
       Gender = "Female",
       Locale = "en-KE",
       LocaleName = "English Kenya",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "en-KE, ChilembaNeural",
       DisplayName = "Chilemba",
       LocalName = "Chilemba",
       ShortName = "en-KE-ChilembaNeural",
       Gender = "Male",
       Locale = "en-KE",
       LocaleName = "English Kenya",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "156"
   },
   new Language()
   {
       Name = "en-NG, EzinneNeural",
       DisplayName = "Ezinne",
       LocalName = "Ezinne",
       ShortName = "en-NG-EzinneNeural",
       Gender = "Female",
       Locale = "en-NG",
       LocaleName = "English Nigeria",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "142"
   },
   new Language()
   {
       Name = "en-NG, AbeoNeural",
       DisplayName = "Abeo",
       LocalName = "Abeo",
       ShortName = "en-NG-AbeoNeural",
       Gender = "Male",
       Locale = "en-NG",
       LocaleName = "English Nigeria",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "153"
   },
   new Language()
   {
       Name = "en-NZ, MollyNeural",
       DisplayName = "Molly",
       LocalName = "Molly",
       ShortName = "en-NZ-MollyNeural",
       Gender = "Female",
       Locale = "en-NZ",
       LocaleName = "English New Zealand",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "132"
   },
   new Language()
   {
       Name = "en-NZ, MitchellNeural",
       DisplayName = "Mitchell",
       LocalName = "Mitchell",
       ShortName = "en-NZ-MitchellNeural",
       Gender = "Male",
       Locale = "en-NZ",
       LocaleName = "English New Zealand",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "149"
   },
   new Language()
   {
       Name = "en-PH, RosaNeural",
       DisplayName = "Rosa",
       LocalName = "Rosa",
       ShortName = "en-PH-RosaNeural",
       Gender = "Female",
       Locale = "en-PH",
       LocaleName = "English Philippines",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "137"
   },
   new Language()
   {
       Name = "en-PH, JamesNeural",
       DisplayName = "James",
       LocalName = "James",
       ShortName = "en-PH-JamesNeural",
       Gender = "Male",
       Locale = "en-PH",
       LocaleName = "English Philippines",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "147"
   },
   new Language()
   {
       Name = "en-SG, LunaNeural",
       DisplayName = "Luna",
       LocalName = "Luna",
       ShortName = "en-SG-LunaNeural",
       Gender = "Female",
       Locale = "en-SG",
       LocaleName = "English Singapore",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "133"
   },
   new Language()
   {
       Name = "en-SG, WayneNeural",
       DisplayName = "Wayne",
       LocalName = "Wayne",
       ShortName = "en-SG-WayneNeural",
       Gender = "Male",
       Locale = "en-SG",
       LocaleName = "English Singapore",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "133"
   },
   new Language()
   {
       Name = "en-TZ, ImaniNeural",
       DisplayName = "Imani",
       LocalName = "Imani",
       ShortName = "en-TZ-ImaniNeural",
       Gender = "Female",
       Locale = "en-TZ",
       LocaleName = "English Tanzania",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "142"
   },
   new Language()
   {
       Name = "en-TZ, ElimuNeural",
       DisplayName = "Elimu",
       LocalName = "Elimu",
       ShortName = "en-TZ-ElimuNeural",
       Gender = "Male",
       Locale = "en-TZ",
       LocaleName = "English Tanzania",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "152"
   },
   new Language()
   {
       Name = "en-US, JennyMultilingualNeural",
       DisplayName = "Jenny Multilingual",
       LocalName = "Jenny Multilingual",
       ShortName = "en-US-JennyMultilingualNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "190"
   },
   new Language()
   {
       Name = "en-US, JennyNeural",
       DisplayName = "Jenny",
       LocalName = "Jenny",
       ShortName = "en-US-JennyNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "152"
   },
   new Language()
   {
       Name = "en-US, GuyNeural",
       DisplayName = "Guy",
       LocalName = "Guy",
       ShortName = "en-US-GuyNeural",
       Gender = "Male",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "215"
   },
   new Language()
   {
       Name = "en-US, AriaNeural",
       DisplayName = "Aria",
       LocalName = "Aria",
       ShortName = "en-US-AriaNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",


       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "150"
   },
   new Language()
   {
       Name = "en-US, DavisNeural",
       DisplayName = "Davis",
       LocalName = "Davis",
       ShortName = "en-US-DavisNeural",
       Gender = "Male",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "en-US, AmberNeural",
       DisplayName = "Amber",
       LocalName = "Amber",
       ShortName = "en-US-AmberNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "152"
   },
   new Language()
   {
       Name = "en-US, AnaNeural",
       DisplayName = "Ana",
       LocalName = "Ana",
       ShortName = "en-US-AnaNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "135"
   },
   new Language()
   {
       Name = "en-US, AshleyNeural",
       DisplayName = "Ashley",
       LocalName = "Ashley",
       ShortName = "en-US-AshleyNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "149"
   },
   new Language()
   {
       Name = "en-US, BrandonNeural",
       DisplayName = "Brandon",
       LocalName = "Brandon",
       ShortName = "en-US-BrandonNeural",
       Gender = "Male",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "156"
   },
   new Language()
   {
       Name = "en-US, ChristopherNeural",
       DisplayName = "Christopher",
       LocalName = "Christopher",
       ShortName = "en-US-ChristopherNeural",
       Gender = "Male",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "149"
   },
   new Language()
   {
       Name = "en-US, CoraNeural",
       DisplayName = "Cora",
       LocalName = "Cora",
       ShortName = "en-US-CoraNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "146"
   },
   new Language()
   {
       Name = "en-US, ElizabethNeural",
       DisplayName = "Elizabeth",
       LocalName = "Elizabeth",
       ShortName = "en-US-ElizabethNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "152"
   },
   new Language()
   {
       Name = "en-US, EricNeural",
       DisplayName = "Eric",
       LocalName = "Eric",
       ShortName = "en-US-EricNeural",
       Gender = "Male",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "147"
   },
   new Language()
   {
       Name = "en-US, JacobNeural",
       DisplayName = "Jacob",
       LocalName = "Jacob",
       ShortName = "en-US-JacobNeural",
       Gender = "Male",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "en-US, JaneNeural",
       DisplayName = "Jane",
       LocalName = "Jane",
       ShortName = "en-US-JaneNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "en-US, JasonNeural",
       DisplayName = "Jason",
       LocalName = "Jason",
       ShortName = "en-US-JasonNeural",
       Gender = "Male",
       Locale = "en-US",
       LocaleName = "English United States",


       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "156"
   },
   new Language()
   {
       Name = "en-US, MichelleNeural",
       DisplayName = "Michelle",
       LocalName = "Michelle",
       ShortName = "en-US-MichelleNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "en-US, MonicaNeural",
       DisplayName = "Monica",
       LocalName = "Monica",
       ShortName = "en-US-MonicaNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "145"
   },
   new Language()
   {
       Name = "en-US, NancyNeural",
       DisplayName = "Nancy",
       LocalName = "Nancy",
       ShortName = "en-US-NancyNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "149"
   },
   new Language()
   {
       Name = "en-US, RogerNeural",
       DisplayName = "Roger",
       LocalName = "Roger",
       ShortName = "en-US-RogerNeural",
       Gender = "Male",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA"
   },
   new Language()
   {
       Name = "en-US, SaraNeural",
       DisplayName = "Sara",
       LocalName = "Sara",
       ShortName = "en-US-SaraNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",


       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "157"
   },
   new Language()
   {
       Name = "en-US, SteffanNeural",
       DisplayName = "Steffan",
       LocalName = "Steffan",
       ShortName = "en-US-SteffanNeural",
       Gender = "Male",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "en-US, TonyNeural",
       DisplayName = "Tony",
       LocalName = "Tony",
       ShortName = "en-US-TonyNeural",
       Gender = "Male",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "156"
   },
   new Language()
   {
       Name = "en-US, AIGenerate1Neural",
       DisplayName = "AIGenerate1",
       LocalName = "AIGenerate1",
       ShortName = "en-US-AIGenerate1Neural",
       Gender = "Male",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "Preview",
       WordsPerMinute = "135"
   },
   new Language()
   {
       Name = "en-US, AIGenerate2Neural",
       DisplayName = "AIGenerate2",
       LocalName = "AIGenerate2",
       ShortName = "en-US-AIGenerate2Neural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "Preview",
       WordsPerMinute = "140"
   },
   new Language()
   {
       Name = "en-US, BlueNeural",
       DisplayName = "Blue",
       LocalName = "Blue",
       ShortName = "en-US-BlueNeural",
       Gender = "Female",
       Locale = "en-US",
       LocaleName = "English United States",

       VoiceType = "Neural",
       Status = "Preview"
   },
   new Language()
   {
       Name = "en-ZA, LeahNeural",
       DisplayName = "Leah",
       LocalName = "Leah",
       ShortName = "en-ZA-LeahNeural",
       Gender = "Female",
       Locale = "en-ZA",
       LocaleName = "English South Africa",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "en-ZA, LukeNeural",
       DisplayName = "Luke",
       LocalName = "Luke",
       ShortName = "en-ZA-LukeNeural",
       Gender = "Male",
       Locale = "en-ZA",
       LocaleName = "English South Africa",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "168"
   },
   new Language()
   {
       Name = "es-AR, ElenaNeural",
       DisplayName = "Elena",
       LocalName = "Elena",
       ShortName = "es-AR-ElenaNeural",
       Gender = "Female",
       Locale = "es-AR",
       LocaleName = "Spanish Argentina",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "150"
   },
   new Language()
   {
       Name = "es-AR, TomasNeural",
       DisplayName = "Tomas",
       LocalName = "Tomas",
       ShortName = "es-AR-TomasNeural",
       Gender = "Male",
       Locale = "es-AR",
       LocaleName = "Spanish Argentina",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "158"
   },
   new Language()
   {
       Name = "es-BO, SofiaNeural",
       DisplayName = "Sofia",
       LocalName = "Sofia",
       ShortName = "es-BO-SofiaNeural",
       Gender = "Female",
       Locale = "es-BO",
       LocaleName = "Spanish Bolivia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "159"
   },
   new Language()
   {
       Name = "es-BO, MarceloNeural",
       DisplayName = "Marcelo",
       LocalName = "Marcelo",
       ShortName = "es-BO-MarceloNeural",
       Gender = "Male",
       Locale = "es-BO",
       LocaleName = "Spanish Bolivia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "152"
   },
   new Language()
   {
       Name = "es-CL, CatalinaNeural",
       DisplayName = "Catalina",
       LocalName = "Catalina",
       ShortName = "es-CL-CatalinaNeural",
       Gender = "Female",
       Locale = "es-CL",
       LocaleName = "Spanish Chile",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "295"
   },
   new Language()
   {
       Name = "es-CL, LorenzoNeural",
       DisplayName = "Lorenzo",
       LocalName = "Lorenzo",
       ShortName = "es-CL-LorenzoNeural",
       Gender = "Male",
       Locale = "es-CL",
       LocaleName = "Spanish Chile",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "318"
   },
   new Language()
   {
       Name = "es-CO, SalomeNeural",
       DisplayName = "Salome",
       LocalName = "Salome",
       ShortName = "es-CO-SalomeNeural",
       Gender = "Female",
       Locale = "es-CO",
       LocaleName = "Spanish Colombia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "es-CO, GonzaloNeural",
       DisplayName = "Gonzalo",
       LocalName = "Gonzalo",
       ShortName = "es-CO-GonzaloNeural",
       Gender = "Male",
       Locale = "es-CO",
       LocaleName = "Spanish Colombia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "161"
   },
   new Language()
   {
       Name = "es-CR, MariaNeural",
       DisplayName = "Maria",
       LocalName = "María",
       ShortName = "es-CR-MariaNeural",
       Gender = "Female",
       Locale = "es-CR",
       LocaleName = "Spanish Costa Rica",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "138"
   },
   new Language()
   {
       Name = "es-CR, JuanNeural",
       DisplayName = "Juan",
       LocalName = "Juan",
       ShortName = "es-CR-JuanNeural",
       Gender = "Male",
       Locale = "es-CR",
       LocaleName = "Spanish Costa Rica",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "133"
   },
   new Language()
   {
       Name = "es-CU, BelkysNeural",
       DisplayName = "Belkys",
       LocalName = "Belkys",
       ShortName = "es-CU-BelkysNeural",
       Gender = "Female",
       Locale = "es-CU",
       LocaleName = "Spanish Cuba",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "es-CU, ManuelNeural",
       DisplayName = "Manuel",
       LocalName = "Manuel",
       ShortName = "es-CU-ManuelNeural",
       Gender = "Male",
       Locale = "es-CU",
       LocaleName = "Spanish Cuba",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "137"
   },
   new Language()
   {
       Name = "es-DO, RamonaNeural",
       DisplayName = "Ramona",
       LocalName = "Ramona",
       ShortName = "es-DO-RamonaNeural",
       Gender = "Female",
       Locale = "es-DO",
       LocaleName = "Spanish Dominican Republic",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "130"
   },
   new Language()
   {
       Name = "es-DO, EmilioNeural",
       DisplayName = "Emilio",
       LocalName = "Emilio",
       ShortName = "es-DO-EmilioNeural",
       Gender = "Male",
       Locale = "es-DO",
       LocaleName = "Spanish Dominican Republic",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "133"
   },
   new Language()
   {
       Name = "es-EC, AndreaNeural",
       DisplayName = "Andrea",
       LocalName = "Andrea",
       ShortName = "es-EC-AndreaNeural",
       Gender = "Female",
       Locale = "es-EC",
       LocaleName = "Spanish Ecuador",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "152"
   },
   new Language()
   {
       Name = "es-EC, LuisNeural",
       DisplayName = "Luis",
       LocalName = "Luis",
       ShortName = "es-EC-LuisNeural",
       Gender = "Male",
       Locale = "es-EC",
       LocaleName = "Spanish Ecuador",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "138"
   },
   new Language()
   {
       Name = "es-ES, ElviraNeural",
       DisplayName = "Elvira",
       LocalName = "Elvira",
       ShortName = "es-ES-ElviraNeural",
       Gender = "Female",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "148"
   },
   new Language()
   {
       Name = "es-ES, AlvaroNeural",
       DisplayName = "Alvaro",
       LocalName = "Álvaro",
       ShortName = "es-ES-AlvaroNeural",
       Gender = "Male",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "148"
   },
   new Language()
   {
       Name = "es-ES, AbrilNeural",
       DisplayName = "Abril",
       LocalName = "Abril",
       ShortName = "es-ES-AbrilNeural",
       Gender = "Female",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "146"
   },
   new Language()
   {
       Name = "es-ES, ArnauNeural",
       DisplayName = "Arnau",
       LocalName = "Arnau",
       ShortName = "es-ES-ArnauNeural",
       Gender = "Male",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "142"
   },
   new Language()
   {
       Name = "es-ES, DarioNeural",
       DisplayName = "Dario",
       LocalName = "Dario",
       ShortName = "es-ES-DarioNeural",
       Gender = "Male",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "164"
   },
   new Language()
   {
       Name = "es-ES, EliasNeural",
       DisplayName = "Elias",
       LocalName = "Elias",
       ShortName = "es-ES-EliasNeural",
       Gender = "Male",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "es-ES, EstrellaNeural",
       DisplayName = "Estrella",
       LocalName = "Estrella",
       ShortName = "es-ES-EstrellaNeural",
       Gender = "Female",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "es-ES, IreneNeural",
       DisplayName = "Irene",
       LocalName = "Irene",
       ShortName = "es-ES-IreneNeural",
       Gender = "Female",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "134"
   },
   new Language()
   {
       Name = "es-ES, LaiaNeural",
       DisplayName = "Laia",
       LocalName = "Laia",
       ShortName = "es-ES-LaiaNeural",
       Gender = "Female",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "141"
   },
   new Language()
   {
       Name = "es-ES, LiaNeural",
       DisplayName = "Lia",
       LocalName = "Lia",
       ShortName = "es-ES-LiaNeural",
       Gender = "Female",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "150"
   },
   new Language()
   {
       Name = "es-ES, NilNeural",
       DisplayName = "Nil",
       LocalName = "Nil",
       ShortName = "es-ES-NilNeural",
       Gender = "Male",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "149"
   },
   new Language()
   {
       Name = "es-ES, SaulNeural",
       DisplayName = "Saul",
       LocalName = "Saul",
       ShortName = "es-ES-SaulNeural",
       Gender = "Male",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "148"
   },
   new Language()
   {
       Name = "es-ES, TeoNeural",
       DisplayName = "Teo",
       LocalName = "Teo",
       ShortName = "es-ES-TeoNeural",
       Gender = "Male",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "es-ES, TrianaNeural",
       DisplayName = "Triana",
       LocalName = "Triana",
       ShortName = "es-ES-TrianaNeural",
       Gender = "Female",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "150"
   },
   new Language()
   {
       Name = "es-ES, VeraNeural",
       DisplayName = "Vera",
       LocalName = "Vera",
       ShortName = "es-ES-VeraNeural",
       Gender = "Female",
       Locale = "es-ES",
       LocaleName = "Spanish Spain",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "152"
   },
   new Language()
   {
       Name = "es-GQ, TeresaNeural",
       DisplayName = "Teresa",
       LocalName = "Teresa",
       ShortName = "es-GQ-TeresaNeural",
       Gender = "Female",
       Locale = "es-GQ",
       LocaleName = "Spanish Equatorial Guinea",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "es-GQ, JavierNeural",
       DisplayName = "Javier",
       LocalName = "Javier",
       ShortName = "es-GQ-JavierNeural",
       Gender = "Male",
       Locale = "es-GQ",
       LocaleName = "Spanish Equatorial Guinea",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "129"
   },
   new Language()
   {
       Name = "es-GT, MartaNeural",
       DisplayName = "Marta",
       LocalName = "Marta",
       ShortName = "es-GT-MartaNeural",
       Gender = "Female",
       Locale = "es-GT",
       LocaleName = "Spanish Guatemala",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "159"
   },
   new Language()
   {
       Name = "es-GT, AndresNeural",
       DisplayName = "Andres",
       LocalName = "Andrés",
       ShortName = "es-GT-AndresNeural",
       Gender = "Male",
       Locale = "es-GT",
       LocaleName = "Spanish Guatemala",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "157"
   },
   new Language()
   {
       Name = "es-HN, KarlaNeural",
       DisplayName = "Karla",
       LocalName = "Karla",
       ShortName = "es-HN-KarlaNeural",
       Gender = "Female",
       Locale = "es-HN",
       LocaleName = "Spanish Honduras",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "137"
   },
   new Language()
   {
       Name = "es-HN, CarlosNeural",
       DisplayName = "Carlos",
       LocalName = "Carlos",
       ShortName = "es-HN-CarlosNeural",
       Gender = "Male",
       Locale = "es-HN",
       LocaleName = "Spanish Honduras",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "157"
   },
   new Language()
   {
       Name = "es-MX, DaliaNeural",
       DisplayName = "Dalia",
       LocalName = "Dalia",
       ShortName = "es-MX-DaliaNeural",
       Gender = "Female",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "145"
   },
   new Language()
   {
       Name = "es-MX, JorgeNeural",
       DisplayName = "Jorge",
       LocalName = "Jorge",
       ShortName = "es-MX-JorgeNeural",
       Gender = "Male",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "es-MX, BeatrizNeural",
       DisplayName = "Beatriz",
       LocalName = "Beatriz",
       ShortName = "es-MX-BeatrizNeural",
       Gender = "Female",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "157"
   },
   new Language()
   {
       Name = "es-MX, CandelaNeural",
       DisplayName = "Candela",
       LocalName = "Candela",
       ShortName = "es-MX-CandelaNeural",
       Gender = "Female",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "134"
   },
   new Language()
   {
       Name = "es-MX, CarlotaNeural",
       DisplayName = "Carlota",
       LocalName = "Carlota",
       ShortName = "es-MX-CarlotaNeural",
       Gender = "Female",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "145"
   },
   new Language()
   {
       Name = "es-MX, CecilioNeural",
       DisplayName = "Cecilio",
       LocalName = "Cecilio",
       ShortName = "es-MX-CecilioNeural",
       Gender = "Male",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "149"
   },
   new Language()
   {
       Name = "es-MX, GerardoNeural",
       DisplayName = "Gerardo",
       LocalName = "Gerardo",
       ShortName = "es-MX-GerardoNeural",
       Gender = "Male",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "141"
   },
   new Language()
   {
       Name = "es-MX, LarissaNeural",
       DisplayName = "Larissa",
       LocalName = "Larissa",
       ShortName = "es-MX-LarissaNeural",
       Gender = "Female",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "151"
   },
   new Language()
   {
       Name = "es-MX, LibertoNeural",
       DisplayName = "Liberto",
       LocalName = "Liberto",
       ShortName = "es-MX-LibertoNeural",
       Gender = "Male",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "149"
   },
   new Language()
   {
       Name = "es-MX, LucianoNeural",
       DisplayName = "Luciano",
       LocalName = "Luciano",
       ShortName = "es-MX-LucianoNeural",
       Gender = "Male",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "139"
   },
   new Language()
   {
       Name = "es-MX, MarinaNeural",
       DisplayName = "Marina",
       LocalName = "Marina",
       ShortName = "es-MX-MarinaNeural",
       Gender = "Female",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "136"
   },
   new Language()
   {
       Name = "es-MX, NuriaNeural",
       DisplayName = "Nuria",
       LocalName = "Nuria",
       ShortName = "es-MX-NuriaNeural",
       Gender = "Female",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "es-MX, PelayoNeural",
       DisplayName = "Pelayo",
       LocalName = "Pelayo",
       ShortName = "es-MX-PelayoNeural",
       Gender = "Male",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "148"
   },
   new Language()
   {
       Name = "es-MX, RenataNeural",
       DisplayName = "Renata",
       LocalName = "Renata",
       ShortName = "es-MX-RenataNeural",
       Gender = "Female",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "153"
   },
   new Language()
   {
       Name = "es-MX, YagoNeural",
       DisplayName = "Yago",
       LocalName = "Yago",
       ShortName = "es-MX-YagoNeural",
       Gender = "Male",
       Locale = "es-MX",
       LocaleName = "Spanish Mexico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "149"
   },
   new Language()
   {
       Name = "es-NI, YolandaNeural",
       DisplayName = "Yolanda",
       LocalName = "Yolanda",
       ShortName = "es-NI-YolandaNeural",
       Gender = "Female",
       Locale = "es-NI",
       LocaleName = "Spanish Nicaragua",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "130"
   },
   new Language()
   {
       Name = "es-NI, FedericoNeural",
       DisplayName = "Federico",
       LocalName = "Federico",
       ShortName = "es-NI-FedericoNeural",
       Gender = "Male",
       Locale = "es-NI",
       LocaleName = "Spanish Nicaragua",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "152"
   },
   new Language()
   {
       Name = "es-PA, MargaritaNeural",
       DisplayName = "Margarita",
       LocalName = "Margarita",
       ShortName = "es-PA-MargaritaNeural",
       Gender = "Female",
       Locale = "es-PA",
       LocaleName = "Spanish Panama",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "152"
   },
   new Language()
   {
       Name = "es-PA, RobertoNeural",
       DisplayName = "Roberto",
       LocalName = "Roberto",
       ShortName = "es-PA-RobertoNeural",
       Gender = "Male",
       Locale = "es-PA",
       LocaleName = "Spanish Panama",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "133"
   },
   new Language()
   {
       Name = "es-PE, CamilaNeural",
       DisplayName = "Camila",
       LocalName = "Camila",
       ShortName = "es-PE-CamilaNeural",
       Gender = "Female",
       Locale = "es-PE",
       LocaleName = "Spanish Peru",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "159"
   },
   new Language()
   {
       Name = "es-PE, AlexNeural",
       DisplayName = "Alex",
       LocalName = "Alex",
       ShortName = "es-PE-AlexNeural",
       Gender = "Male",
       Locale = "es-PE",
       LocaleName = "Spanish Peru",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "133"
   },
   new Language()
   {
       Name = "es-PR, KarinaNeural",
       DisplayName = "Karina",
       LocalName = "Karina",
       ShortName = "es-PR-KarinaNeural",
       Gender = "Female",
       Locale = "es-PR",
       LocaleName = "Spanish Puerto Rico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "130"
   },
   new Language()
   {
       Name = "es-PR, VictorNeural",
       DisplayName = "Victor",
       LocalName = "Víctor",
       ShortName = "es-PR-VictorNeural",
       Gender = "Male",
       Locale = "es-PR",
       LocaleName = "Spanish Puerto Rico",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "138"
   },
   new Language()
   {
       Name = "es-PY, TaniaNeural",
       DisplayName = "Tania",
       LocalName = "Tania",
       ShortName = "es-PY-TaniaNeural",
       Gender = "Female",
       Locale = "es-PY",
       LocaleName = "Spanish Paraguay",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "151"
   },
   new Language()
   {
       Name = "es-PY, MarioNeural",
       DisplayName = "Mario",
       LocalName = "Mario",
       ShortName = "es-PY-MarioNeural",
       Gender = "Male",
       Locale = "es-PY",
       LocaleName = "Spanish Paraguay",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "168"
   },
   new Language()
   {
       Name = "es-SV, LorenaNeural",
       DisplayName = "Lorena",
       LocalName = "Lorena",
       ShortName = "es-SV-LorenaNeural",
       Gender = "Female",
       Locale = "es-SV",
       LocaleName = "Spanish El Salvador",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "159"
   },
   new Language()
   {
       Name = "es-SV, RodrigoNeural",
       DisplayName = "Rodrigo",
       LocalName = "Rodrigo",
       ShortName = "es-SV-RodrigoNeural",
       Gender = "Male",
       Locale = "es-SV",
       LocaleName = "Spanish El Salvador",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "157"
   },
   new Language()
   {
       Name = "es-US, PalomaNeural",
       DisplayName = "Paloma",
       LocalName = "Paloma",
       ShortName = "es-US-PalomaNeural",
       Gender = "Female",
       Locale = "es-US",
       LocaleName = "Spanish United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "152"
   },
   new Language()
   {
       Name = "es-US, AlonsoNeural",
       DisplayName = "Alonso",
       LocalName = "Alonso",
       ShortName = "es-US-AlonsoNeural",
       Gender = "Male",
       Locale = "es-US",
       LocaleName = "Spanish United States",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "138"
   },
   new Language()
   {
       Name = "es-UY, ValentinaNeural",
       DisplayName = "Valentina",
       LocalName = "Valentina",
       ShortName = "es-UY-ValentinaNeural",
       Gender = "Female",
       Locale = "es-UY",
       LocaleName = "Spanish Uruguay",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "150"
   },
   new Language()
   {
       Name = "es-UY, MateoNeural",
       DisplayName = "Mateo",
       LocalName = "Mateo",
       ShortName = "es-UY-MateoNeural",
       Gender = "Male",
       Locale = "es-UY",
       LocaleName = "Spanish Uruguay",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "158"
   },
   new Language()
   {
       Name = "es-VE, PaolaNeural",
       DisplayName = "Paola",
       LocalName = "Paola",
       ShortName = "es-VE-PaolaNeural",
       Gender = "Female",
       Locale = "es-VE",
       LocaleName = "Spanish Venezuela",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "130"
   },
   new Language()
   {
       Name = "es-VE, SebastianNeural",
       DisplayName = "Sebastian",
       LocalName = "Sebastián",
       ShortName = "es-VE-SebastianNeural",
       Gender = "Male",
       Locale = "es-VE",
       LocaleName = "Spanish Venezuela",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "157"
   },
   new Language()
   {
       Name = "et-EE, AnuNeural",
       DisplayName = "Anu",
       LocalName = "Anu",
       ShortName = "et-EE-AnuNeural",
       Gender = "Female",
       Locale = "et-EE",
       LocaleName = "Estonian Estonia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "114"
   },
   new Language()
   {
       Name = "et-EE, KertNeural",
       DisplayName = "Kert",
       LocalName = "Kert",
       ShortName = "et-EE-KertNeural",
       Gender = "Male",
       Locale = "et-EE",
       LocaleName = "Estonian Estonia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "114"
   },
   new Language()
   {
       Name = "eu-ES, AinhoaNeural",
       DisplayName = "Ainhoa",
       LocalName = "Ainhoa",
       ShortName = "eu-ES-AinhoaNeural",
       Gender = "Female",
       Locale = "eu-ES",
       LocaleName = "Basque",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "102"
   },
   new Language()
   {
       Name = "eu-ES, AnderNeural",
       DisplayName = "Ander",
       LocalName = "Ander",
       ShortName = "eu-ES-AnderNeural",
       Gender = "Male",
       Locale = "eu-ES",
       LocaleName = "Basque",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "102"
   },
   new Language()
   {
       Name = "fa-IR, DilaraNeural",
       DisplayName = "Dilara",
       LocalName = "دلارا",
       ShortName = "fa-IR-DilaraNeural",
       Gender = "Female",
       Locale = "fa-IR",
       LocaleName = "Persian Iran",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "134"
   },
   new Language()
   {
       Name = "fa-IR, FaridNeural",
       DisplayName = "Farid",
       LocalName = "فرید",
       ShortName = "fa-IR-FaridNeural",
       Gender = "Male",
       Locale = "fa-IR",
       LocaleName = "Persian Iran",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "134"
   },
   new Language()
   {
       Name = "fi-FI, SelmaNeural",
       DisplayName = "Selma",
       LocalName = "Selma",
       ShortName = "fi-FI-SelmaNeural",
       Gender = "Female",
       Locale = "fi-FI",
       LocaleName = "Finnish Finland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "91"
   },
   new Language()
   {
       Name = "fi-FI, HarriNeural",
       DisplayName = "Harri",
       LocalName = "Harri",
       ShortName = "fi-FI-HarriNeural",
       Gender = "Male",
       Locale = "fi-FI",
       LocaleName = "Finnish Finland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "97"
   },
   new Language()
   {
       Name = "fi-FI, NooraNeural",
       DisplayName = "Noora",
       LocalName = "Noora",
       ShortName = "fi-FI-NooraNeural",
       Gender = "Female",
       Locale = "fi-FI",
       LocaleName = "Finnish Finland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "96"
   },
   new Language()
   {
       Name = "fil-PH, BlessicaNeural",
       DisplayName = "Blessica",
       LocalName = "Blessica",
       ShortName = "fil-PH-BlessicaNeural",
       Gender = "Female",
       Locale = "fil-PH",
       LocaleName = "Filipino Philippines",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "140"
   },
   new Language()
   {
       Name = "fil-PH, AngeloNeural",
       DisplayName = "Angelo",
       LocalName = "Angelo",
       ShortName = "fil-PH-AngeloNeural",
       Gender = "Male",
       Locale = "fil-PH",
       LocaleName = "Filipino Philippines",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "144"
   },
   new Language()
   {
       Name = "fr-BE, CharlineNeural",
       DisplayName = "Charline",
       LocalName = "Charline",
       ShortName = "fr-BE-CharlineNeural",
       Gender = "Female",
       Locale = "fr-BE",
       LocaleName = "French Belgium",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "157"
   },
   new Language()
   {
       Name = "fr-BE, GerardNeural",
       DisplayName = "Gerard",
       LocalName = "Gerard",
       ShortName = "fr-BE-GerardNeural",
       Gender = "Male",
       Locale = "fr-BE",
       LocaleName = "French Belgium",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "172"
   },
   new Language()
   {
       Name = "fr-CA, SylvieNeural",
       DisplayName = "Sylvie",
       LocalName = "Sylvie",
       ShortName = "fr-CA-SylvieNeural",
       Gender = "Female",
       Locale = "fr-CA",
       LocaleName = "French Canada",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "fr-CA, JeanNeural",
       DisplayName = "Jean",
       LocalName = "Jean",
       ShortName = "fr-CA-JeanNeural",
       Gender = "Male",
       Locale = "fr-CA",
       LocaleName = "French Canada",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "133"
   },
   new Language()
   {
       Name = "fr-CA, AntoineNeural",
       DisplayName = "Antoine",
       LocalName = "Antoine",
       ShortName = "fr-CA-AntoineNeural",
       Gender = "Male",
       Locale = "fr-CA",
       LocaleName = "French Canada",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "159"
   },
   new Language()
   {
       Name = "fr-CH, ArianeNeural",
       DisplayName = "Ariane",
       LocalName = "Ariane",
       ShortName = "fr-CH-ArianeNeural",
       Gender = "Female",
       Locale = "fr-CH",
       LocaleName = "French Switzerland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "158"
   },
   new Language()
   {
       Name = "fr-CH, FabriceNeural",
       DisplayName = "Fabrice",
       LocalName = "Fabrice",
       ShortName = "fr-CH-FabriceNeural",
       Gender = "Male",
       Locale = "fr-CH",
       LocaleName = "French Switzerland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "172"
   },
   new Language()
   {
       Name = "fr-FR, DeniseNeural",
       DisplayName = "Denise",
       LocalName = "Denise",
       ShortName = "fr-FR-DeniseNeural",
       Gender = "Female",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "fr-FR, HenriNeural",
       DisplayName = "Henri",
       LocalName = "Henri",
       ShortName = "fr-FR-HenriNeural",
       Gender = "Male",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "165"
   },
   new Language()
   {
       Name = "fr-FR, AlainNeural",
       DisplayName = "Alain",
       LocalName = "Alain",
       ShortName = "fr-FR-AlainNeural",
       Gender = "Male",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "165"
   },
   new Language()
   {
       Name = "fr-FR, BrigitteNeural",
       DisplayName = "Brigitte",
       LocalName = "Brigitte",
       ShortName = "fr-FR-BrigitteNeural",
       Gender = "Female",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "153"
   },
   new Language()
   {
       Name = "fr-FR, CelesteNeural",
       DisplayName = "Celeste",
       LocalName = "Celeste",
       ShortName = "fr-FR-CelesteNeural",
       Gender = "Female",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "fr-FR, ClaudeNeural",
       DisplayName = "Claude",
       LocalName = "Claude",
       ShortName = "fr-FR-ClaudeNeural",
       Gender = "Male",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "fr-FR, CoralieNeural",
       DisplayName = "Coralie",
       LocalName = "Coralie",
       ShortName = "fr-FR-CoralieNeural",
       Gender = "Female",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "fr-FR, EloiseNeural",
       DisplayName = "Eloise",
       LocalName = "Eloise",
       ShortName = "fr-FR-EloiseNeural",
       Gender = "Female",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "150"
   },
   new Language()
   {
       Name = "fr-FR, JacquelineNeural",
       DisplayName = "Jacqueline",
       LocalName = "Jacqueline",
       ShortName = "fr-FR-JacquelineNeural",
       Gender = "Female",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "fr-FR, JeromeNeural",
       DisplayName = "Jerome",
       LocalName = "Jerome",
       ShortName = "fr-FR-JeromeNeural",
       Gender = "Male",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "165"
   },
   new Language()
   {
       Name = "fr-FR, JosephineNeural",
       DisplayName = "Josephine",
       LocalName = "Josephine",
       ShortName = "fr-FR-JosephineNeural",
       Gender = "Female",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "fr-FR, MauriceNeural",
       DisplayName = "Maurice",
       LocalName = "Maurice",
       ShortName = "fr-FR-MauriceNeural",
       Gender = "Male",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "162"
   },
   new Language()
   {
       Name = "fr-FR, YvesNeural",
       DisplayName = "Yves",
       LocalName = "Yves",
       ShortName = "fr-FR-YvesNeural",
       Gender = "Male",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "162"
   },
   new Language()
   {
       Name = "fr-FR, YvetteNeural",
       DisplayName = "Yvette",
       LocalName = "Yvette",
       ShortName = "fr-FR-YvetteNeural",
       Gender = "Female",
       Locale = "fr-FR",
       LocaleName = "French France",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "156"
   },
   new Language()
   {
       Name = "ga-IE, OrlaNeural",
       DisplayName = "Orla",
       LocalName = "Orla",
       ShortName = "ga-IE-OrlaNeural",
       Gender = "Female",
       Locale = "ga-IE",
       LocaleName = "Irish Ireland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "139"
   },
   new Language()
   {
       Name = "ga-IE, ColmNeural",
       DisplayName = "Colm",
       LocalName = "Colm",
       ShortName = "ga-IE-ColmNeural",
       Gender = "Male",
       Locale = "ga-IE",
       LocaleName = "Irish Ireland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "157"
   },
   new Language()
   {
       Name = "gl-ES, SabelaNeural",
       DisplayName = "Sabela",
       LocalName = "Sabela",
       ShortName = "gl-ES-SabelaNeural",
       Gender = "Female",
       Locale = "gl-ES",
       LocaleName = "Galician",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "141"
   },
   new Language()
   {
       Name = "gl-ES, RoiNeural",
       DisplayName = "Roi",
       LocalName = "Roi",
       ShortName = "gl-ES-RoiNeural",
       Gender = "Male",
       Locale = "gl-ES",
       LocaleName = "Galician",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "148"
   },
   new Language()
   {
       Name = "gu-IN, DhwaniNeural",
       DisplayName = "Dhwani",
       LocalName = "ધ્વની",
       ShortName = "gu-IN-DhwaniNeural",
       Gender = "Female",
       Locale = "gu-IN",
       LocaleName = "Gujarati India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "89"
   },
   new Language()
   {
       Name = "gu-IN, NiranjanNeural",
       DisplayName = "Niranjan",
       LocalName = "નિરંજન",
       ShortName = "gu-IN-NiranjanNeural",
       Gender = "Male",
       Locale = "gu-IN",
       LocaleName = "Gujarati India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "107"
   },
   new Language()
   {
       Name = "he-IL, HilaNeural",
       DisplayName = "Hila",
       LocalName = "הילה",
       ShortName = "he-IL-HilaNeural",
       Gender = "Female",
       Locale = "he-IL",
       LocaleName = "Hebrew Israel",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "113"
   },
   new Language()
   {
       Name = "he-IL, AvriNeural",
       DisplayName = "Avri",
       LocalName = "אברי",
       ShortName = "he-IL-AvriNeural",
       Gender = "Male",
       Locale = "he-IL",
       LocaleName = "Hebrew Israel",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "106"
   },
   new Language()
   {
       Name = "hi-IN, SwaraNeural",
       DisplayName = "Swara",
       LocalName = "स्वरा",
       ShortName = "hi-IN-SwaraNeural",
       Gender = "Female",
       Locale = "hi-IN",
       LocaleName = "Hindi India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "117"
   },
   new Language()
   {
       Name = "hi-IN, MadhurNeural",
       DisplayName = "Madhur",
       LocalName = "मधुर",
       ShortName = "hi-IN-MadhurNeural",
       Gender = "Male",
       Locale = "hi-IN",
       LocaleName = "Hindi India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "114"
   },
   new Language()
   {
       Name = "hr-HR, GabrijelaNeural",
       DisplayName = "Gabrijela",
       LocalName = "Gabrijela",
       ShortName = "hr-HR-GabrijelaNeural",
       Gender = "Female",
       Locale = "hr-HR",
       LocaleName = "Croatian Croatia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "124"
   },
   new Language()
   {
       Name = "hr-HR, SreckoNeural",
       DisplayName = "Srecko",
       LocalName = "Srećko",
       ShortName = "hr-HR-SreckoNeural",
       Gender = "Male",
       Locale = "hr-HR",
       LocaleName = "Croatian Croatia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "133"
   },
   new Language()
   {
       Name = "hu-HU, NoemiNeural",
       DisplayName = "Noemi",
       LocalName = "Noémi",
       ShortName = "hu-HU-NoemiNeural",
       Gender = "Female",
       Locale = "hu-HU",
       LocaleName = "Hungarian Hungary",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "110"
   },
   new Language()
   {
       Name = "hu-HU, TamasNeural",
       DisplayName = "Tamas",
       LocalName = "Tamás",
       ShortName = "hu-HU-TamasNeural",
       Gender = "Male",
       Locale = "hu-HU",
       LocaleName = "Hungarian Hungary",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "124"
   },
   new Language()
   {
       Name = "hy-AM, AnahitNeural",
       DisplayName = "Anahit",
       LocalName = "Անահիտ",
       ShortName = "hy-AM-AnahitNeural",
       Gender = "Female",
       Locale = "hy-AM",
       LocaleName = "Armenian Armenia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "112"
   },
   new Language()
   {
       Name = "hy-AM, HaykNeural",
       DisplayName = "Hayk",
       LocalName = "Հայկ",
       ShortName = "hy-AM-HaykNeural",
       Gender = "Male",
       Locale = "hy-AM",
       LocaleName = "Armenian Armenia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "112"
   },
   new Language()
   {
       Name = "id-ID, GadisNeural",
       DisplayName = "Gadis",
       LocalName = "Gadis",
       ShortName = "id-ID-GadisNeural",
       Gender = "Female",
       Locale = "id-ID",
       LocaleName = "Indonesian Indonesia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "111"
   },
   new Language()
   {
       Name = "id-ID, ArdiNeural",
       DisplayName = "Ardi",
       LocalName = "Ardi",
       ShortName = "id-ID-ArdiNeural",
       Gender = "Male",
       Locale = "id-ID",
       LocaleName = "Indonesian Indonesia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "124"
   },
   new Language()
   {
       Name = "is-IS, GudrunNeural",
       DisplayName = "Gudrun",
       LocalName = "Guðrún",
       ShortName = "is-IS-GudrunNeural",
       Gender = "Female",
       Locale = "is-IS",
       LocaleName = "Icelandic Iceland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "135"
   },
   new Language()
   {
       Name = "is-IS, GunnarNeural",
       DisplayName = "Gunnar",
       LocalName = "Gunnar",
       ShortName = "is-IS-GunnarNeural",
       Gender = "Male",
       Locale = "is-IS",
       LocaleName = "Icelandic Iceland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "144"
   },
   new Language()
   {
       Name = "it-IT, ElsaNeural",
       DisplayName = "Elsa",
       LocalName = "Elsa",
       ShortName = "it-IT-ElsaNeural",
       Gender = "Female",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "148"
   },
   new Language()
   {
       Name = "it-IT, IsabellaNeural",
       DisplayName = "Isabella",
       LocalName = "Isabella",
       ShortName = "it-IT-IsabellaNeural",
       Gender = "Female",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "134"
   },
   new Language()
   {
       Name = "it-IT, DiegoNeural",
       DisplayName = "Diego",
       LocalName = "Diego",
       ShortName = "it-IT-DiegoNeural",
       Gender = "Male",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "135"
   },
   new Language()
   {
       Name = "it-IT, BenignoNeural",
       DisplayName = "Benigno",
       LocalName = "Benigno",
       ShortName = "it-IT-BenignoNeural",
       Gender = "Male",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "153"
   },
   new Language()
   {
       Name = "it-IT, CalimeroNeural",
       DisplayName = "Calimero",
       LocalName = "Calimero",
       ShortName = "it-IT-CalimeroNeural",
       Gender = "Male",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "142"
   },
   new Language()
   {
       Name = "it-IT, CataldoNeural",
       DisplayName = "Cataldo",
       LocalName = "Cataldo",
       ShortName = "it-IT-CataldoNeural",
       Gender = "Male",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "149"
   },
   new Language()
   {
       Name = "it-IT, FabiolaNeural",
       DisplayName = "Fabiola",
       LocalName = "Fabiola",
       ShortName = "it-IT-FabiolaNeural",
       Gender = "Female",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "it-IT, FiammaNeural",
       DisplayName = "Fiamma",
       LocalName = "Fiamma",
       ShortName = "it-IT-FiammaNeural",
       Gender = "Female",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "141"
   },
   new Language()
   {
       Name = "it-IT, GianniNeural",
       DisplayName = "Gianni",
       LocalName = "Gianni",
       ShortName = "it-IT-GianniNeural",
       Gender = "Male",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "139"
   },
   new Language()
   {
       Name = "it-IT, ImeldaNeural",
       DisplayName = "Imelda",
       LocalName = "Imelda",
       ShortName = "it-IT-ImeldaNeural",
       Gender = "Female",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "140"
   },
   new Language()
   {
       Name = "it-IT, IrmaNeural",
       DisplayName = "Irma",
       LocalName = "Irma",
       ShortName = "it-IT-IrmaNeural",
       Gender = "Female",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "142"
   },
   new Language()
   {
       Name = "it-IT, LisandroNeural",
       DisplayName = "Lisandro",
       LocalName = "Lisandro",
       ShortName = "it-IT-LisandroNeural",
       Gender = "Male",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "137"
   },
   new Language()
   {
       Name = "it-IT, PalmiraNeural",
       DisplayName = "Palmira",
       LocalName = "Palmira",
       ShortName = "it-IT-PalmiraNeural",
       Gender = "Female",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "139"
   },
   new Language()
   {
       Name = "it-IT, PierinaNeural",
       DisplayName = "Pierina",
       LocalName = "Pierina",
       ShortName = "it-IT-PierinaNeural",
       Gender = "Female",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "134"
   },
   new Language()
   {
       Name = "it-IT, RinaldoNeural",
       DisplayName = "Rinaldo",
       LocalName = "Rinaldo",
       ShortName = "it-IT-RinaldoNeural",
       Gender = "Male",
       Locale = "it-IT",
       LocaleName = "Italian Italy",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "137"
   },
   new Language()
   {
       Name = "ja-JP, NanamiNeural",
       DisplayName = "Nanami",
       LocalName = "七海",
       ShortName = "ja-JP-NanamiNeural",
       Gender = "Female",
       Locale = "ja-JP",
       LocaleName = "Japanese Japan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "305"
   },
   new Language()
   {
       Name = "ja-JP, KeitaNeural",
       DisplayName = "Keita",
       LocalName = "圭太",
       ShortName = "ja-JP-KeitaNeural",
       Gender = "Male",
       Locale = "ja-JP",
       LocaleName = "Japanese Japan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "337"
   },
   new Language()
   {
       Name = "ja-JP, AoiNeural",
       DisplayName = "Aoi",
       LocalName = "碧衣",
       ShortName = "ja-JP-AoiNeural",
       Gender = "Female",
       Locale = "ja-JP",
       LocaleName = "Japanese Japan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "270"
   },
   new Language()
   {
       Name = "ja-JP, DaichiNeural",
       DisplayName = "Daichi",
       LocalName = "大智",
       ShortName = "ja-JP-DaichiNeural",
       Gender = "Male",
       Locale = "ja-JP",
       LocaleName = "Japanese Japan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "312"
   },
   new Language()
   {
       Name = "ja-JP, MayuNeural",
       DisplayName = "Mayu",
       LocalName = "真夕",
       ShortName = "ja-JP-MayuNeural",
       Gender = "Female",
       Locale = "ja-JP",
       LocaleName = "Japanese Japan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "302"
   },
   new Language()
   {
       Name = "ja-JP, NaokiNeural",
       DisplayName = "Naoki",
       LocalName = "直紀",
       ShortName = "ja-JP-NaokiNeural",
       Gender = "Male",
       Locale = "ja-JP",
       LocaleName = "Japanese Japan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "312"
   },
   new Language()
   {
       Name = "ja-JP, ShioriNeural",
       DisplayName = "Shiori",
       LocalName = "志織",
       ShortName = "ja-JP-ShioriNeural",
       Gender = "Female",
       Locale = "ja-JP",
       LocaleName = "Japanese Japan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "296"
   },
   new Language()
   {
       Name = "jv-ID, SitiNeural",
       DisplayName = "Siti",
       LocalName = "Siti",
       ShortName = "jv-ID-SitiNeural",
       Gender = "Female",
       Locale = "jv-ID",
       LocaleName = "Javanese Latin, Indonesia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "104"
   },
   new Language()
   {
       Name = "jv-ID, DimasNeural",
       DisplayName = "Dimas",
       LocalName = "Dimas",
       ShortName = "jv-ID-DimasNeural",
       Gender = "Male",
       Locale = "jv-ID",
       LocaleName = "Javanese Latin, Indonesia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "115"
   },
   new Language()
   {
       Name = "ka-GE, EkaNeural",
       DisplayName = "Eka",
       LocalName = "ეკა",
       ShortName = "ka-GE-EkaNeural",
       Gender = "Female",
       Locale = "ka-GE",
       LocaleName = "Georgian Georgia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "104"
   },
   new Language()
   {
       Name = "ka-GE, GiorgiNeural",
       DisplayName = "Giorgi",
       LocalName = "გიორგი",
       ShortName = "ka-GE-GiorgiNeural",
       Gender = "Male",
       Locale = "ka-GE",
       LocaleName = "Georgian Georgia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "104"
   },
   new Language()
   {
       Name = "kk-KZ, AigulNeural",
       DisplayName = "Aigul",
       LocalName = "Айгүл",
       ShortName = "kk-KZ-AigulNeural",
       Gender = "Female",
       Locale = "kk-KZ",
       LocaleName = "Kazakh Kazakhstan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "107"
   },
   new Language()
   {
       Name = "kk-KZ, DauletNeural",
       DisplayName = "Daulet",
       LocalName = "Дәулет",
       ShortName = "kk-KZ-DauletNeural",
       Gender = "Male",
       Locale = "kk-KZ",
       LocaleName = "Kazakh Kazakhstan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "111"
   },
   new Language()
   {
       Name = "km-KH, SreymomNeural",
       DisplayName = "Sreymom",
       LocalName = "ស្រីមុំ",
       ShortName = "km-KH-SreymomNeural",
       Gender = "Female",
       Locale = "km-KH",
       LocaleName = "Khmer Cambodia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "25"
   },
   new Language()
   {
       Name = "km-KH, PisethNeural",
       DisplayName = "Piseth",
       LocalName = "ពិសិដ្ឋ",
       ShortName = "km-KH-PisethNeural",
       Gender = "Male",
       Locale = "km-KH",
       LocaleName = "Khmer Cambodia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "25"
   },
   new Language()
   {
       Name = "kn-IN, SapnaNeural",
       DisplayName = "Sapna",
       LocalName = "ಸಪ್ನಾ",
       ShortName = "kn-IN-SapnaNeural",
       Gender = "Female",
       Locale = "kn-IN",
       LocaleName = "Kannada India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "94"
   },
   new Language()
   {
       Name = "kn-IN, GaganNeural",
       DisplayName = "Gagan",
       LocalName = "ಗಗನ್",
       ShortName = "kn-IN-GaganNeural",
       Gender = "Male",
       Locale = "kn-IN",
       LocaleName = "Kannada India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "100"
   },
   new Language()
   {
       Name = "ko-KR, SunHiNeural",
       DisplayName = "Sun-Hi",
       LocalName = "선히",
       ShortName = "ko-KR-SunHiNeural",
       Gender = "Female",
       Locale = "ko-KR",
       LocaleName = "Korean Korea",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "274"
   },
   new Language()
   {
       Name = "ko-KR, InJoonNeural",
       DisplayName = "InJoon",
       LocalName = "인준",
       ShortName = "ko-KR-InJoonNeural",
       Gender = "Male",
       Locale = "ko-KR",
       LocaleName = "Korean Korea",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "253"
   },
   new Language()
   {
       Name = "ko-KR, BongJinNeural",
       DisplayName = "BongJin",
       LocalName = "봉진",
       ShortName = "ko-KR-BongJinNeural",
       Gender = "Male",
       Locale = "ko-KR",
       LocaleName = "Korean Korea",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "262"
   },
   new Language()
   {
       Name = "ko-KR, GookMinNeural",
       DisplayName = "GookMin",
       LocalName = "국민",
       ShortName = "ko-KR-GookMinNeural",
       Gender = "Male",
       Locale = "ko-KR",
       LocaleName = "Korean Korea",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "278"
   },
   new Language()
   {
       Name = "ko-KR, JiMinNeural",
       DisplayName = "JiMin",
       LocalName = "지민",
       ShortName = "ko-KR-JiMinNeural",
       Gender = "Female",
       Locale = "ko-KR",
       LocaleName = "Korean Korea",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "291"
   },
   new Language()
   {
       Name = "ko-KR, SeoHyeonNeural",
       DisplayName = "SeoHyeon",
       LocalName = "서현",
       ShortName = "ko-KR-SeoHyeonNeural",
       Gender = "Female",
       Locale = "ko-KR",
       LocaleName = "Korean Korea",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "258"
   },
   new Language()
   {
       Name = "ko-KR, SoonBokNeural",
       DisplayName = "SoonBok",
       LocalName = "순복",
       ShortName = "ko-KR-SoonBokNeural",
       Gender = "Female",
       Locale = "ko-KR",
       LocaleName = "Korean Korea",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "271"
   },
   new Language()
   {
       Name = "ko-KR, YuJinNeural",
       DisplayName = "YuJin",
       LocalName = "유진",
       ShortName = "ko-KR-YuJinNeural",
       Gender = "Female",
       Locale = "ko-KR",
       LocaleName = "Korean Korea",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "288"
   },
   new Language()
   {
       Name = "lo-LA, KeomanyNeural",
       DisplayName = "Keomany",
       LocalName = "ແກ້ວມະນີ",
       ShortName = "lo-LA-KeomanyNeural",
       Gender = "Female",
       Locale = "lo-LA",
       LocaleName = "Lao Laos",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "33"
   },
   new Language()
   {
       Name = "lo-LA, ChanthavongNeural",
       DisplayName = "Chanthavong",
       LocalName = "ຈັນທະວົງ",
       ShortName = "lo-LA-ChanthavongNeural",
       Gender = "Male",
       Locale = "lo-LA",
       LocaleName = "Lao Laos",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "35"
   },
   new Language()
   {
       Name = "lt-LT, OnaNeural",
       DisplayName = "Ona",
       LocalName = "Ona",
       ShortName = "lt-LT-OnaNeural",
       Gender = "Female",
       Locale = "lt-LT",
       LocaleName = "Lithuanian Lithuania",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "107"
   },
   new Language()
   {
       Name = "lt-LT, LeonasNeural",
       DisplayName = "Leonas",
       LocalName = "Leonas",
       ShortName = "lt-LT-LeonasNeural",
       Gender = "Male",
       Locale = "lt-LT",
       LocaleName = "Lithuanian Lithuania",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "111"
   },
   new Language()
   {
       Name = "lv-LV, EveritaNeural",
       DisplayName = "Everita",
       LocalName = "Everita",
       ShortName = "lv-LV-EveritaNeural",
       Gender = "Female",
       Locale = "lv-LV",
       LocaleName = "Latvian Latvia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "106"
   },
   new Language()
   {
       Name = "lv-LV, NilsNeural",
       DisplayName = "Nils",
       LocalName = "Nils",
       ShortName = "lv-LV-NilsNeural",
       Gender = "Male",
       Locale = "lv-LV",
       LocaleName = "Latvian Latvia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "120"
   },
   new Language()
   {
       Name = "mk-MK, MarijaNeural",
       DisplayName = "Marija",
       LocalName = "Марија",
       ShortName = "mk-MK-MarijaNeural",
       Gender = "Female",
       Locale = "mk-MK",
       LocaleName = "Macedonian North Macedonia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "127"
   },
   new Language()
   {
       Name = "mk-MK, AleksandarNeural",
       DisplayName = "Aleksandar",
       LocalName = "Александар",
       ShortName = "mk-MK-AleksandarNeural",
       Gender = "Male",
       Locale = "mk-MK",
       LocaleName = "Macedonian North Macedonia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "127"
   },
   new Language()
   {
       Name = "ml-IN, SobhanaNeural",
       DisplayName = "Sobhana",
       LocalName = "ശോഭന",
       ShortName = "ml-IN-SobhanaNeural",
       Gender = "Female",
       Locale = "ml-IN",
       LocaleName = "Malayalam India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "87"
   },
   new Language()
   {
       Name = "ml-IN, MidhunNeural",
       DisplayName = "Midhun",
       LocalName = "മിഥുൻ",
       ShortName = "ml-IN-MidhunNeural",
       Gender = "Male",
       Locale = "ml-IN",
       LocaleName = "Malayalam India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "93"
   },
   new Language()
   {
       Name = "mn-MN, YesuiNeural",
       DisplayName = "Yesui",
       LocalName = "Есүй",
       ShortName = "mn-MN-YesuiNeural",
       Gender = "Female",
       Locale = "mn-MN",
       LocaleName = "Mongolian Mongolia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "142"
   },
   new Language()
   {
       Name = "mn-MN, BataaNeural",
       DisplayName = "Bataa",
       LocalName = "Батаа",
       ShortName = "mn-MN-BataaNeural",
       Gender = "Male",
       Locale = "mn-MN",
       LocaleName = "Mongolian Mongolia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "142"
   },
   new Language()
   {
       Name = "mr-IN, AarohiNeural",
       DisplayName = "Aarohi",
       LocalName = "आरोही",
       ShortName = "mr-IN-AarohiNeural",
       Gender = "Female",
       Locale = "mr-IN",
       LocaleName = "Marathi India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "99"
   },
   new Language()
   {
       Name = "mr-IN, ManoharNeural",
       DisplayName = "Manohar",
       LocalName = "मनोहर",
       ShortName = "mr-IN-ManoharNeural",
       Gender = "Male",
       Locale = "mr-IN",
       LocaleName = "Marathi India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "100"
   },
   new Language()
   {
       Name = "ms-MY, YasminNeural",
       DisplayName = "Yasmin",
       LocalName = "Yasmin",
       ShortName = "ms-MY-YasminNeural",
       Gender = "Female",
       Locale = "ms-MY",
       LocaleName = "Malay Malaysia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "112"
   },
   new Language()
   {
       Name = "ms-MY, OsmanNeural",
       DisplayName = "Osman",
       LocalName = "Osman",
       ShortName = "ms-MY-OsmanNeural",
       Gender = "Male",
       Locale = "ms-MY",
       LocaleName = "Malay Malaysia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "118"
   },
   new Language()
   {
       Name = "mt-MT, GraceNeural",
       DisplayName = "Grace",
       LocalName = "Grace",
       ShortName = "mt-MT-GraceNeural",
       Gender = "Female",
       Locale = "mt-MT",
       LocaleName = "Maltese Malta",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "136"
   },
   new Language()
   {
       Name = "mt-MT, JosephNeural",
       DisplayName = "Joseph",
       LocalName = "Joseph",
       ShortName = "mt-MT-JosephNeural",
       Gender = "Male",
       Locale = "mt-MT",
       LocaleName = "Maltese Malta",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "130"
   },
   new Language()
   {
       Name = "my-MM, NilarNeural",
       DisplayName = "Nilar",
       LocalName = "နီလာ",
       ShortName = "my-MM-NilarNeural",
       Gender = "Female",
       Locale = "my-MM",
       LocaleName = "Burmese Myanmar",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "63"
   },
   new Language()
   {
       Name = "my-MM, ThihaNeural",
       DisplayName = "Thiha",
       LocalName = "သီဟ",
       ShortName = "my-MM-ThihaNeural",
       Gender = "Male",
       Locale = "my-MM",
       LocaleName = "Burmese Myanmar",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "71"
   },
   new Language()
   {
       Name = "nb-NO, PernilleNeural",
       DisplayName = "Pernille",
       LocalName = "Pernille",
       ShortName = "nb-NO-PernilleNeural",
       Gender = "Female",
       Locale = "nb-NO",
       LocaleName = "Norwegian Bokmål Norway",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "160"
   },
   new Language()
   {
       Name = "nb-NO, FinnNeural",
       DisplayName = "Finn",
       LocalName = "Finn",
       ShortName = "nb-NO-FinnNeural",
       Gender = "Male",
       Locale = "nb-NO",
       LocaleName = "Norwegian Bokmål Norway",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "145"
   },
   new Language()
   {
       Name = "nb-NO, IselinNeural",
       DisplayName = "Iselin",
       LocalName = "Iselin",
       ShortName = "nb-NO-IselinNeural",
       Gender = "Female",
       Locale = "nb-NO",
       LocaleName = "Norwegian Bokmål Norway",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "154"
   },
   new Language()
   {
       Name = "ne-NP, HemkalaNeural",
       DisplayName = "Hemkala",
       LocalName = "हेमकला",
       ShortName = "ne-NP-HemkalaNeural",
       Gender = "Female",
       Locale = "ne-NP",
       LocaleName = "Nepali Nepal",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "119"
   },
   new Language()
   {
       Name = "ne-NP, SagarNeural",
       DisplayName = "Sagar",
       LocalName = "सागर",
       ShortName = "ne-NP-SagarNeural",
       Gender = "Male",
       Locale = "ne-NP",
       LocaleName = "Nepali Nepal",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "119"
   },
   new Language()
   {
       Name = "nl-BE, DenaNeural",
       DisplayName = "Dena",
       LocalName = "Dena",
       ShortName = "nl-BE-DenaNeural",
       Gender = "Female",
       Locale = "nl-BE",
       LocaleName = "Dutch Belgium",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "134"
   },
   new Language()
   {
       Name = "nl-BE, ArnaudNeural",
       DisplayName = "Arnaud",
       LocalName = "Arnaud",
       ShortName = "nl-BE-ArnaudNeural",
       Gender = "Male",
       Locale = "nl-BE",
       LocaleName = "Dutch Belgium",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "nl-NL, FennaNeural",
       DisplayName = "Fenna",
       LocalName = "Fenna",
       ShortName = "nl-NL-FennaNeural",
       Gender = "Female",
       Locale = "nl-NL",
       LocaleName = "Dutch Netherlands",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "140"
   },
   new Language()
   {
       Name = "nl-NL, MaartenNeural",
       DisplayName = "Maarten",
       LocalName = "Maarten",
       ShortName = "nl-NL-MaartenNeural",
       Gender = "Male",
       Locale = "nl-NL",
       LocaleName = "Dutch Netherlands",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "151"
   },
   new Language()
   {
       Name = "nl-NL, ColetteNeural",
       DisplayName = "Colette",
       LocalName = "Colette",
       ShortName = "nl-NL-ColetteNeural",
       Gender = "Female",
       Locale = "nl-NL",
       LocaleName = "Dutch Netherlands",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "132"
   },
   new Language()
   {
       Name = "pl-PL, AgnieszkaNeural",
       DisplayName = "Agnieszka",
       LocalName = "Agnieszka",
       ShortName = "pl-PL-AgnieszkaNeural",
       Gender = "Female",
       Locale = "pl-PL",
       LocaleName = "Polish Poland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "112"
   },
   new Language()
   {
       Name = "pl-PL, MarekNeural",
       DisplayName = "Marek",
       LocalName = "Marek",
       ShortName = "pl-PL-MarekNeural",
       Gender = "Male",
       Locale = "pl-PL",
       LocaleName = "Polish Poland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "128"
   },
   new Language()
   {
       Name = "pl-PL, ZofiaNeural",
       DisplayName = "Zofia",
       LocalName = "Zofia",
       ShortName = "pl-PL-ZofiaNeural",
       Gender = "Female",
       Locale = "pl-PL",
       LocaleName = "Polish Poland",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "127"
   },
   new Language()
   {
       Name = "ps-AF, LatifaNeural",
       DisplayName = "Latifa",
       LocalName = "لطيفه",
       ShortName = "ps-AF-LatifaNeural",
       Gender = "Female",
       Locale = "ps-AF",
       LocaleName = "Pashto Afghanistan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "165"
   },
   new Language()
   {
       Name = "ps-AF, GulNawazNeural",
       DisplayName = "Gul Nawaz",
       LocalName = " ګل نواز",
       ShortName = "ps-AF-GulNawazNeural",
       Gender = "Male",
       Locale = "ps-AF",
       LocaleName = "Pashto Afghanistan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "170"
   },
   new Language()
   {
       Name = "pt-BR, FranciscaNeural",
       DisplayName = "Francisca",
       LocalName = "Francisca",
       ShortName = "pt-BR-FranciscaNeural",
       Gender = "Female",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "134"
   },
   new Language()
   {
       Name = "pt-BR, AntonioNeural",
       DisplayName = "Antonio",
       LocalName = "Antônio",
       ShortName = "pt-BR-AntonioNeural",
       Gender = "Male",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "138"
   },
   new Language()
   {
       Name = "pt-BR, BrendaNeural",
       DisplayName = "Brenda",
       LocalName = "Brenda",
       ShortName = "pt-BR-BrendaNeural",
       Gender = "Female",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "144"
   },
   new Language()
   {
       Name = "pt-BR, DonatoNeural",
       DisplayName = "Donato",
       LocalName = "Donato",
       ShortName = "pt-BR-DonatoNeural",
       Gender = "Male",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "152"
   },
   new Language()
   {
       Name = "pt-BR, ElzaNeural",
       DisplayName = "Elza",
       LocalName = "Elza",
       ShortName = "pt-BR-ElzaNeural",
       Gender = "Female",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "135"
   },
   new Language()
   {
       Name = "pt-BR, FabioNeural",
       DisplayName = "Fabio",
       LocalName = "Fabio",
       ShortName = "pt-BR-FabioNeural",
       Gender = "Male",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "134"
   },
   new Language()
   {
       Name = "pt-BR, GiovannaNeural",
       DisplayName = "Giovanna",
       LocalName = "Giovanna",
       ShortName = "pt-BR-GiovannaNeural",
       Gender = "Female",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "143"
   },
   new Language()
   {
       Name = "pt-BR, HumbertoNeural",
       DisplayName = "Humberto",
       LocalName = "Humberto",
       ShortName = "pt-BR-HumbertoNeural",
       Gender = "Male",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "146"
   },
   new Language()
   {
       Name = "pt-BR, JulioNeural",
       DisplayName = "Julio",
       LocalName = "Julio",
       ShortName = "pt-BR-JulioNeural",
       Gender = "Male",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "136"
   },
   new Language()
   {
       Name = "pt-BR, LeilaNeural",
       DisplayName = "Leila",
       LocalName = "Leila",
       ShortName = "pt-BR-LeilaNeural",
       Gender = "Female",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "153"
   },
   new Language()
   {
       Name = "pt-BR, LeticiaNeural",
       DisplayName = "Leticia",
       LocalName = "Leticia",
       ShortName = "pt-BR-LeticiaNeural",
       Gender = "Female",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "128"
   },
   new Language()
   {
       Name = "pt-BR, ManuelaNeural",
       DisplayName = "Manuela",
       LocalName = "Manuela",
       ShortName = "pt-BR-ManuelaNeural",
       Gender = "Female",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "135"
   },
   new Language()
   {
       Name = "pt-BR, NicolauNeural",
       DisplayName = "Nicolau",
       LocalName = "Nicolau",
       ShortName = "pt-BR-NicolauNeural",
       Gender = "Male",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "132"
   },
   new Language()
   {
       Name = "pt-BR, ValerioNeural",
       DisplayName = "Valerio",
       LocalName = "Valerio",
       ShortName = "pt-BR-ValerioNeural",
       Gender = "Male",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "131"
   },
   new Language()
   {
       Name = "pt-BR, YaraNeural",
       DisplayName = "Yara",
       LocalName = "Yara",
       ShortName = "pt-BR-YaraNeural",
       Gender = "Female",
       Locale = "pt-BR",
       LocaleName = "Portuguese Brazil",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "136"
   },
   new Language()
   {
       Name = "pt-PT, RaquelNeural",
       DisplayName = "Raquel",
       LocalName = "Raquel",
       ShortName = "pt-PT-RaquelNeural",
       Gender = "Female",
       Locale = "pt-PT",
       LocaleName = "Portuguese Portugal",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "144"
   },
   new Language()
   {
       Name = "pt-PT, DuarteNeural",
       DisplayName = "Duarte",
       LocalName = "Duarte",
       ShortName = "pt-PT-DuarteNeural",
       Gender = "Male",
       Locale = "pt-PT",
       LocaleName = "Portuguese Portugal",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "182"
   },
   new Language()
   {
       Name = "pt-PT, FernandaNeural",
       DisplayName = "Fernanda",
       LocalName = "Fernanda",
       ShortName = "pt-PT-FernandaNeural",
       Gender = "Female",
       Locale = "pt-PT",
       LocaleName = "Portuguese Portugal",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "166"
   },
   new Language()
   {
       Name = "ro-RO, AlinaNeural",
       DisplayName = "Alina",
       LocalName = "Alina",
       ShortName = "ro-RO-AlinaNeural",
       Gender = "Female",
       Locale = "ro-RO",
       LocaleName = "Romanian Romania",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "141"
   },
   new Language()
   {
       Name = "ro-RO, EmilNeural",
       DisplayName = "Emil",
       LocalName = "Emil",
       ShortName = "ro-RO-EmilNeural",
       Gender = "Male",
       Locale = "ro-RO",
       LocaleName = "Romanian Romania",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "144"
   },
   new Language()
   {
       Name = "ru-RU, SvetlanaNeural",
       DisplayName = "Svetlana",
       LocalName = "Светлана",
       ShortName = "ru-RU-SvetlanaNeural",
       Gender = "Female",
       Locale = "ru-RU",
       LocaleName = "Russian Russia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "113"
   },
   new Language()
   {
       Name = "ru-RU, DmitryNeural",
       DisplayName = "Dmitry",
       LocalName = "Дмитрий",
       ShortName = "ru-RU-DmitryNeural",
       Gender = "Male",
       Locale = "ru-RU",
       LocaleName = "Russian Russia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "113"
   },
   new Language()
   {
       Name = "ru-RU, DariyaNeural",
       DisplayName = "Dariya",
       LocalName = "Дария",
       ShortName = "ru-RU-DariyaNeural",
       Gender = "Female",
       Locale = "ru-RU",
       LocaleName = "Russian Russia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "113"
   },
   new Language()
   {
       Name = "si-LK, ThiliniNeural",
       DisplayName = "Thilini",
       LocalName = "තිළිණි",
       ShortName = "si-LK-ThiliniNeural",
       Gender = "Female",
       Locale = "si-LK",
       LocaleName = "Sinhala Sri Lanka",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "142"
   },
   new Language()
   {
       Name = "si-LK, SameeraNeural",
       DisplayName = "Sameera",
       LocalName = "සමීර",
       ShortName = "si-LK-SameeraNeural",
       Gender = "Male",
       Locale = "si-LK",
       LocaleName = "Sinhala Sri Lanka",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "155"
   },
   new Language()
   {
       Name = "sk-SK, ViktoriaNeural",
       DisplayName = "Viktoria",
       LocalName = "Viktória",
       ShortName = "sk-SK-ViktoriaNeural",
       Gender = "Female",
       Locale = "sk-SK",
       LocaleName = "Slovak Slovakia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "118"
   },
   new Language()
   {
       Name = "sk-SK, LukasNeural",
       DisplayName = "Lukas",
       LocalName = "Lukáš",
       ShortName = "sk-SK-LukasNeural",
       Gender = "Male",
       Locale = "sk-SK",
       LocaleName = "Slovak Slovakia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "132"
   },
   new Language()
   {
       Name = "sl-SI, PetraNeural",
       DisplayName = "Petra",
       LocalName = "Petra",
       ShortName = "sl-SI-PetraNeural",
       Gender = "Female",
       Locale = "sl-SI",
       LocaleName = "Slovenian Slovenia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "138"
   },
   new Language()
   {
       Name = "sl-SI, RokNeural",
       DisplayName = "Rok",
       LocalName = "Rok",
       ShortName = "sl-SI-RokNeural",
       Gender = "Male",
       Locale = "sl-SI",
       LocaleName = "Slovenian Slovenia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "126"
   },
   new Language()
   {
       Name = "so-SO, UbaxNeural",
       DisplayName = "Ubax",
       LocalName = "Ubax",
       ShortName = "so-SO-UbaxNeural",
       Gender = "Female",
       Locale = "so-SO",
       LocaleName = "Somali Somalia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "126"
   },
   new Language()
   {
       Name = "so-SO, MuuseNeural",
       DisplayName = "Muuse",
       LocalName = "Muuse",
       ShortName = "so-SO-MuuseNeural",
       Gender = "Male",
       Locale = "so-SO",
       LocaleName = "Somali Somalia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "136"
   },
   new Language()
   {
       Name = "sq-AL, AnilaNeural",
       DisplayName = "Anila",
       LocalName = "Anila",
       ShortName = "sq-AL-AnilaNeural",
       Gender = "Female",
       Locale = "sq-AL",
       LocaleName = "Albanian Albania",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "141"
   },
   new Language()
   {
       Name = "sq-AL, IlirNeural",
       DisplayName = "Ilir",
       LocalName = "Ilir",
       ShortName = "sq-AL-IlirNeural",
       Gender = "Male",
       Locale = "sq-AL",
       LocaleName = "Albanian Albania",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "141"
   },
   new Language()
   {
       Name = "sr-Latn-RS, NicholasNeural",
       DisplayName = "Nicholas",
       LocalName = "Nicholas",
       ShortName = "sr-Latn-RS-NicholasNeural",
       Gender = "Male",
       Locale = "sr-Latn-RS",
       LocaleName = "Serbian Latin, Serbia",

       VoiceType = "Neural",
       Status = "Preview"
   },
   new Language()
   {
       Name = "sr-Latn-RS, SophieNeural",
       DisplayName = "Sophie",
       LocalName = "Sophie",
       ShortName = "sr-Latn-RS-SophieNeural",
       Gender = "Female",
       Locale = "sr-Latn-RS",
       LocaleName = "Serbian Latin, Serbia",

       VoiceType = "Neural",
       Status = "Preview"
   },
   new Language()
   {
       Name = "sr-RS, SophieNeural",
       DisplayName = "Sophie",
       LocalName = "Софија",
       ShortName = "sr-RS-SophieNeural",
       Gender = "Female",
       Locale = "sr-RS",
       LocaleName = "Serbian Cyrillic, Serbia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "132"
   },
   new Language()
   {
       Name = "sr-RS, NicholasNeural",
       DisplayName = "Nicholas",
       LocalName = "Никола",
       ShortName = "sr-RS-NicholasNeural",
       Gender = "Male",
       Locale = "sr-RS",
       LocaleName = "Serbian Cyrillic, Serbia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "128"
   },
   new Language()
   {
       Name = "su-ID, TutiNeural",
       DisplayName = "Tuti",
       LocalName = "Tuti",
       ShortName = "su-ID-TutiNeural",
       Gender = "Female",
       Locale = "su-ID",
       LocaleName = "Sundanese Indonesia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "111"
   },
   new Language()
   {
       Name = "su-ID, JajangNeural",
       DisplayName = "Jajang",
       LocalName = "Jajang",
       ShortName = "su-ID-JajangNeural",
       Gender = "Male",
       Locale = "su-ID",
       LocaleName = "Sundanese Indonesia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "115"
   },
   new Language()
   {
       Name = "sv-SE, SofieNeural",
       DisplayName = "Sofie",
       LocalName = "Sofie",
       ShortName = "sv-SE-SofieNeural",
       Gender = "Female",
       Locale = "sv-SE",
       LocaleName = "Swedish Sweden",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "138"
   },
   new Language()
   {
       Name = "sv-SE, MattiasNeural",
       DisplayName = "Mattias",
       LocalName = "Mattias",
       ShortName = "sv-SE-MattiasNeural",
       Gender = "Male",
       Locale = "sv-SE",
       LocaleName = "Swedish Sweden",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "135"
   },
   new Language()
   {
       Name = "sv-SE, HilleviNeural",
       DisplayName = "Hillevi",
       LocalName = "Hillevi",
       ShortName = "sv-SE-HilleviNeural",
       Gender = "Female",
       Locale = "sv-SE",
       LocaleName = "Swedish Sweden",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "147"
   },
   new Language()
   {
       Name = "sw-KE, ZuriNeural",
       DisplayName = "Zuri",
       LocalName = "Zuri",
       ShortName = "sw-KE-ZuriNeural",
       Gender = "Female",
       Locale = "sw-KE",
       LocaleName = "Swahili Kenya",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "113"
   },
   new Language()
   {
       Name = "sw-KE, RafikiNeural",
       DisplayName = "Rafiki",
       LocalName = "Rafiki",
       ShortName = "sw-KE-RafikiNeural",
       Gender = "Male",
       Locale = "sw-KE",
       LocaleName = "Swahili Kenya",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "121"
   },
   new Language()
   {
       Name = "sw-TZ, RehemaNeural",
       DisplayName = "Rehema",
       LocalName = "Rehema",
       ShortName = "sw-TZ-RehemaNeural",
       Gender = "Female",
       Locale = "sw-TZ",
       LocaleName = "Swahili Tanzania",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "108"
   },
   new Language()
   {
       Name = "sw-TZ, DaudiNeural",
       DisplayName = "Daudi",
       LocalName = "Daudi",
       ShortName = "sw-TZ-DaudiNeural",
       Gender = "Male",
       Locale = "sw-TZ",
       LocaleName = "Swahili Tanzania",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "114"
   },
   new Language()
   {
       Name = "ta-IN, PallaviNeural",
       DisplayName = "Pallavi",
       LocalName = "பல்லவி",
       ShortName = "ta-IN-PallaviNeural",
       Gender = "Female",
       Locale = "ta-IN",
       LocaleName = "Tamil India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "79"
   },
   new Language()
   {
       Name = "ta-IN, ValluvarNeural",
       DisplayName = "Valluvar",
       LocalName = "வள்ளுவர்",
       ShortName = "ta-IN-ValluvarNeural",
       Gender = "Male",
       Locale = "ta-IN",
       LocaleName = "Tamil India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "98"
   },
   new Language()
   {
       Name = "ta-LK, SaranyaNeural",
       DisplayName = "Saranya",
       LocalName = "சரண்யா",
       ShortName = "ta-LK-SaranyaNeural",
       Gender = "Female",
       Locale = "ta-LK",
       LocaleName = "Tamil Sri Lanka",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "75"
   },
   new Language()
   {
       Name = "ta-LK, KumarNeural",
       DisplayName = "Kumar",
       LocalName = "குமார்",
       ShortName = "ta-LK-KumarNeural",
       Gender = "Male",
       Locale = "ta-LK",
       LocaleName = "Tamil Sri Lanka",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "93"
   },
   new Language()
   {
       Name = "ta-MY, KaniNeural",
       DisplayName = "Kani",
       LocalName = "கனி",
       ShortName = "ta-MY-KaniNeural",
       Gender = "Female",
       Locale = "ta-MY",
       LocaleName = "Tamil Malaysia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "83"
   },
   new Language()
   {
       Name = "ta-MY, SuryaNeural",
       DisplayName = "Surya",
       LocalName = "சூர்யா",
       ShortName = "ta-MY-SuryaNeural",
       Gender = "Male",
       Locale = "ta-MY",
       LocaleName = "Tamil Malaysia",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "93"
   },
   new Language()
   {
       Name = "ta-SG, VenbaNeural",
       DisplayName = "Venba",
       LocalName = "வெண்பா",
       ShortName = "ta-SG-VenbaNeural",
       Gender = "Female",
       Locale = "ta-SG",
       LocaleName = "Tamil Singapore",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "83"
   },
   new Language()
   {
       Name = "ta-SG, AnbuNeural",
       DisplayName = "Anbu",
       LocalName = "அன்பு",
       ShortName = "ta-SG-AnbuNeural",
       Gender = "Male",
       Locale = "ta-SG",
       LocaleName = "Tamil Singapore",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "103"
   },
   new Language()
   {
       Name = "te-IN, ShrutiNeural",
       DisplayName = "Shruti",
       LocalName = "శ్రుతి",
       ShortName = "te-IN-ShrutiNeural",
       Gender = "Female",
       Locale = "te-IN",
       LocaleName = "Telugu India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "79"
   },
   new Language()
   {
       Name = "te-IN, MohanNeural",
       DisplayName = "Mohan",
       LocalName = "మోహన్",
       ShortName = "te-IN-MohanNeural",
       Gender = "Male",
       Locale = "te-IN",
       LocaleName = "Telugu India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "103"
   },
   new Language()
   {
       Name = "th-TH, PremwadeeNeural",
       DisplayName = "Premwadee",
       LocalName = "เปรมวดี",
       ShortName = "th-TH-PremwadeeNeural",
       Gender = "Female",
       Locale = "th-TH",
       LocaleName = "Thai Thailand",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "49"
   },
   new Language()
   {
       Name = "th-TH, NiwatNeural",
       DisplayName = "Niwat",
       LocalName = "นิวัฒน์",
       ShortName = "th-TH-NiwatNeural",
       Gender = "Male",
       Locale = "th-TH",
       LocaleName = "Thai Thailand",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "49"
   },
   new Language()
   {
       Name = "th-TH, AcharaNeural",
       DisplayName = "Achara",
       LocalName = "อัจฉรา",
       ShortName = "th-TH-AcharaNeural",
       Gender = "Female",
       Locale = "th-TH",
       LocaleName = "Thai Thailand",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "51"
   },
   new Language()
   {
       Name = "tr-TR, EmelNeural",
       DisplayName = "Emel",
       LocalName = "Emel",
       ShortName = "tr-TR-EmelNeural",
       Gender = "Female",
       Locale = "tr-TR",
       LocaleName = "Turkish Turkey",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "111"
   },
   new Language()
   {
       Name = "tr-TR, AhmetNeural",
       DisplayName = "Ahmet",
       LocalName = "Ahmet",
       ShortName = "tr-TR-AhmetNeural",
       Gender = "Male",
       Locale = "tr-TR",
       LocaleName = "Turkish Turkey",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "108"
   },
   new Language()
   {
       Name = "uk-UA, PolinaNeural",
       DisplayName = "Polina",
       LocalName = "Поліна",
       ShortName = "uk-UA-PolinaNeural",
       Gender = "Female",
       Locale = "uk-UA",
       LocaleName = "Ukrainian Ukraine",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "111"
   },
   new Language()
   {
       Name = "uk-UA, OstapNeural",
       DisplayName = "Ostap",
       LocalName = "Остап",
       ShortName = "uk-UA-OstapNeural",
       Gender = "Male",
       Locale = "uk-UA",
       LocaleName = "Ukrainian Ukraine",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "109"
   },
   new Language()
   {
       Name = "ur-IN, GulNeural",
       DisplayName = "Gul",
       LocalName = "گل",
       ShortName = "ur-IN-GulNeural",
       Gender = "Female",
       Locale = "ur-IN",
       LocaleName = "Urdu India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "157"
   },
   new Language()
   {
       Name = "ur-IN, SalmanNeural",
       DisplayName = "Salman",
       LocalName = "سلمان",
       ShortName = "ur-IN-SalmanNeural",
       Gender = "Male",
       Locale = "ur-IN",
       LocaleName = "Urdu India",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "103"
   },
   new Language()
   {
       Name = "ur-PK, UzmaNeural",
       DisplayName = "Uzma",
       LocalName = "عظمیٰ",
       ShortName = "ur-PK-UzmaNeural",
       Gender = "Female",
       Locale = "ur-PK",
       LocaleName = "Urdu Pakistan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "168"
   },
   new Language()
   {
       Name = "ur-PK, AsadNeural",
       DisplayName = "Asad",
       LocalName = "اسد",
       ShortName = "ur-PK-AsadNeural",
       Gender = "Male",
       Locale = "ur-PK",
       LocaleName = "Urdu Pakistan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "167"
   },
   new Language()
   {
       Name = "uz-UZ, MadinaNeural",
       DisplayName = "Madina",
       LocalName = "Madina",
       ShortName = "uz-UZ-MadinaNeural",
       Gender = "Female",
       Locale = "uz-UZ",
       LocaleName = "Uzbek Latin, Uzbekistan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "105"
   },
   new Language()
   {
       Name = "uz-UZ, SardorNeural",
       DisplayName = "Sardor",
       LocalName = "Sardor",
       ShortName = "uz-UZ-SardorNeural",
       Gender = "Male",
       Locale = "uz-UZ",
       LocaleName = "Uzbek Latin, Uzbekistan",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "112"
   },
   new Language()
   {
       Name = "vi-VN, HoaiMyNeural",
       DisplayName = "HoaiMy",
       LocalName = "Hoài My",
       ShortName = "vi-VN-HoaiMyNeural",
       Gender = "Female",
       Locale = "vi-VN",
       LocaleName = "Vietnamese Vietnam",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "202"
   },
   new Language()
   {
       Name = "vi-VN, NamMinhNeural",
       DisplayName = "NamMinh",
       LocalName = "Nam Minh",
       ShortName = "vi-VN-NamMinhNeural",
       Gender = "Male",
       Locale = "vi-VN",
       LocaleName = "Vietnamese Vietnam",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "204"
   },
   new Language()
   {
       Name = "wuu-CN, XiaotongNeural",
       DisplayName = "Xiaotong",
       LocalName = "晓彤",
       ShortName = "wuu-CN-XiaotongNeural",
       Gender = "Female",
       Locale = "wuu-CN",
       LocaleName = "Chinese Wu, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "238"
   },
   new Language()
   {
       Name = "wuu-CN, YunzheNeural",
       DisplayName = "Yunzhe",
       LocalName = "云哲",
       ShortName = "wuu-CN-YunzheNeural",
       Gender = "Male",
       Locale = "wuu-CN",
       LocaleName = "Chinese Wu, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "244"
   },
   new Language()
   {
       Name = "yue-CN, XiaoMinNeural",
       DisplayName = "XiaoMin",
       LocalName = "晓敏",
       ShortName = "yue-CN-XiaoMinNeural",
       Gender = "Female",
       Locale = "yue-CN",
       LocaleName = "Chinese Cantonese, Simplified",

       VoiceType = "Neural",
       Status = "Preview",
       WordsPerMinute = "214"
   },
   new Language()
   {
       Name = "yue-CN, YunSongNeural",
       DisplayName = "YunSong",
       LocalName = "云松",
       ShortName = "yue-CN-YunSongNeural",
       Gender = "Male",
       Locale = "yue-CN",
       LocaleName = "Chinese Cantonese, Simplified",

       VoiceType = "Neural",
       Status = "Preview",
       WordsPerMinute = "221"
   },
   new Language()
   {
       Name = "zh-CN, XiaoxiaoNeural",
       DisplayName = "Xiaoxiao",
       LocalName = "晓晓",
       ShortName = "zh-CN-XiaoxiaoNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "274"
   },
   new Language()
   {
       Name = "zh-CN, YunxiNeural",
       DisplayName = "Yunxi",
       LocalName = "云希",
       ShortName = "zh-CN-YunxiNeural",
       Gender = "Male",
       Locale = "zh-CN",


       VoiceType = "Neural",
       Status = "GA",

       WordsPerMinute = "293"
   },
   new Language()
   {
       Name = "zh-CN, YunjianNeural",
       DisplayName = "Yunjian",
       LocalName = "云健",
       ShortName = "zh-CN-YunjianNeural",
       Gender = "Male",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "279"
   },
   new Language()
   {
       Name = "zh-CN, XiaoyiNeural",
       DisplayName = "Xiaoyi",
       LocalName = "晓伊",
       ShortName = "zh-CN-XiaoyiNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "263"
   },
   new Language()
   {
       Name = "zh-CN, YunyangNeural",
       DisplayName = "Yunyang",
       LocalName = "云扬",
       ShortName = "zh-CN-YunyangNeural",
       Gender = "Male",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "293"
   },
   new Language()
   {
       Name = "zh-CN, XiaochenNeural",
       DisplayName = "Xiaochen",
       LocalName = "晓辰",
       ShortName = "zh-CN-XiaochenNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "283"
   },
   new Language()
   {
       Name = "zh-CN, XiaohanNeural",
       DisplayName = "Xiaohan",
       LocalName = "晓涵",
       ShortName = "zh-CN-XiaohanNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "259"
   },
   new Language()
   {
       Name = "zh-CN, XiaomengNeural",
       DisplayName = "Xiaomeng",
       LocalName = "晓梦",
       ShortName = "zh-CN-XiaomengNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "272"
   },
   new Language()
   {
       Name = "zh-CN, XiaomoNeural",
       DisplayName = "Xiaomo",
       LocalName = "晓墨",
       ShortName = "zh-CN-XiaomoNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",

       WordsPerMinute = "286"
   },
   new Language()
   {
       Name = "zh-CN, XiaoqiuNeural",
       DisplayName = "Xiaoqiu",
       LocalName = "晓秋",
       ShortName = "zh-CN-XiaoqiuNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "232"
   },
   new Language()
   {
       Name = "zh-CN, XiaoruiNeural",
       DisplayName = "Xiaorui",
       LocalName = "晓睿",
       ShortName = "zh-CN-XiaoruiNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",


       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "243"
   },
   new Language()
   {
       Name = "zh-CN, XiaoshuangNeural",
       DisplayName = "Xiaoshuang",
       LocalName = "晓双",
       ShortName = "zh-CN-XiaoshuangNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "225"
   },
   new Language()
   {
       Name = "zh-CN, XiaoxuanNeural",
       DisplayName = "Xiaoxuan",
       LocalName = "晓萱",
       ShortName = "zh-CN-XiaoxuanNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",


       VoiceType = "Neural",
       Status = "GA",

       WordsPerMinute = "273"
   },
   new Language()
   {
       Name = "zh-CN, XiaoyanNeural",
       DisplayName = "Xiaoyan",
       LocalName = "晓颜",
       ShortName = "zh-CN-XiaoyanNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "279"
   },
   new Language()
   {
       Name = "zh-CN, XiaoyouNeural",
       DisplayName = "Xiaoyou",
       LocalName = "晓悠",
       ShortName = "zh-CN-XiaoyouNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "211"
   },
   new Language()
   {
       Name = "zh-CN, XiaozhenNeural",
       DisplayName = "Xiaozhen",
       LocalName = "晓甄",
       ShortName = "zh-CN-XiaozhenNeural",
       Gender = "Female",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "273"
   },
   new Language()
   {
       Name = "zh-CN, YunfengNeural",
       DisplayName = "Yunfeng",
       LocalName = "云枫",
       ShortName = "zh-CN-YunfengNeural",
       Gender = "Male",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",


       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "320"
   },
   new Language()
   {
       Name = "zh-CN, YunhaoNeural",
       DisplayName = "Yunhao",
       LocalName = "云皓",
       ShortName = "zh-CN-YunhaoNeural",
       Gender = "Male",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "315"
   },
   new Language()
   {
       Name = "zh-CN, YunxiaNeural",
       DisplayName = "Yunxia",
       LocalName = "云夏",
       ShortName = "zh-CN-YunxiaNeural",
       Gender = "Male",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "269"
   },
   new Language()
   {
       Name = "zh-CN, YunyeNeural",
       DisplayName = "Yunye",
       LocalName = "云野",
       ShortName = "zh-CN-YunyeNeural",
       Gender = "Male",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",


       VoiceType = "Neural",
       Status = "GA",

       WordsPerMinute = "278"
   },
   new Language()
   {
       Name = "zh-CN, YunzeNeural",
       DisplayName = "Yunze",
       LocalName = "云泽",
       ShortName = "zh-CN-YunzeNeural",
       Gender = "Male",
       Locale = "zh-CN",
       LocaleName = "Chinese Mandarin, Simplified",


       VoiceType = "Neural",
       Status = "GA",

       WordsPerMinute = "255"
   },
   new Language()
   {
       Name = "zh-CN-henan, YundengNeural",
       DisplayName = "Yundeng",
       LocalName = "云登",
       ShortName = "zh-CN-henan-YundengNeural",
       Gender = "Male",
       Locale = "zh-CN-henan",
       LocaleName = "Chinese Zhongyuan Mandarin Henan, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "285"
   },
   new Language()
   {
       Name = "zh-CN-liaoning, XiaobeiNeural",
       DisplayName = "Xiaobei",
       LocalName = "晓北",
       ShortName = "zh-CN-liaoning-XiaobeiNeural",
       Gender = "Female",
       Locale = "zh-CN-liaoning",
       LocaleName = "Chinese Northeastern Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "Preview",
       WordsPerMinute = "229"
   },
   new Language()
   {
       Name = "zh-CN-shaanxi, XiaoniNeural",
       DisplayName = "Xiaoni",
       LocalName = "晓妮",
       ShortName = "zh-CN-shaanxi-XiaoniNeural",
       Gender = "Female",
       Locale = "zh-CN-shaanxi",
       LocaleName = "Chinese Zhongyuan Mandarin Shaanxi, Simplified",

       VoiceType = "Neural",
       Status = "Preview",
       WordsPerMinute = "263"
   },
   new Language()
   {
       Name = "zh-CN-shandong, YunxiangNeural",
       DisplayName = "Yunxiang",
       LocalName = "云翔",
       ShortName = "zh-CN-shandong-YunxiangNeural",
       Gender = "Male",
       Locale = "zh-CN-shandong",
       LocaleName = "Chinese Jilu Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "279"
   },
   new Language()
   {
       Name = "zh-CN-sichuan, YunxiNeural",
       DisplayName = "Yunxi",
       LocalName = "云希",
       ShortName = "zh-CN-sichuan-YunxiNeural",
       Gender = "Male",
       Locale = "zh-CN-sichuan",
       LocaleName = "Chinese Southwestern Mandarin, Simplified",

       VoiceType = "Neural",
       Status = "Preview",
       WordsPerMinute = "285"
   },
   new Language()
   {
       Name = "zh-HK, HiuMaanNeural",
       DisplayName = "HiuMaan",
       LocalName = "曉曼",
       ShortName = "zh-HK-HiuMaanNeural",
       Gender = "Female",
       Locale = "zh-HK",
       LocaleName = "Chinese Cantonese, Traditional",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "244"
   },
   new Language()
   {
       Name = "zh-HK, WanLungNeural",
       DisplayName = "WanLung",
       LocalName = "雲龍",
       ShortName = "zh-HK-WanLungNeural",
       Gender = "Male",
       Locale = "zh-HK",
       LocaleName = "Chinese Cantonese, Traditional",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "259"
   },
   new Language()
   {
       Name = "zh-HK, HiuGaaiNeural",
       DisplayName = "HiuGaai",
       LocalName = "曉佳",
       ShortName = "zh-HK-HiuGaaiNeural",
       Gender = "Female",
       Locale = "zh-HK",
       LocaleName = "Chinese Cantonese, Traditional",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "194"
   },
   new Language()
   {
       Name = "zh-TW, HsiaoChenNeural",
       DisplayName = "HsiaoChen",
       LocalName = "曉臻",
       ShortName = "zh-TW-HsiaoChenNeural",
       Gender = "Female",
       Locale = "zh-TW",
       LocaleName = "Chinese Taiwanese Mandarin, Traditional",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "272"
   },
   new Language()
   {
       Name = "zh-TW, YunJheNeural",
       DisplayName = "YunJhe",
       LocalName = "雲哲",
       ShortName = "zh-TW-YunJheNeural",
       Gender = "Male",
       Locale = "zh-TW",
       LocaleName = "Chinese Taiwanese Mandarin, Traditional",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "285"
   },
   new Language()
   {
       Name = "zh-TW, HsiaoYuNeural",
       DisplayName = "HsiaoYu",
       LocalName = "曉雨",
       ShortName = "zh-TW-HsiaoYuNeural",
       Gender = "Female",
       Locale = "zh-TW",
       LocaleName = "Chinese Taiwanese Mandarin, Traditional",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "223"
   },
   new Language()
   {
       Name = "zu-ZA, ThandoNeural",
       DisplayName = "Thando",
       LocalName = "Thando",
       ShortName = "zu-ZA-ThandoNeural",
       Gender = "Female",
       Locale = "zu-ZA",
       LocaleName = "Zulu South Africa",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "83"
   },
   new Language()
   {
       Name = "zu-ZA, ThembaNeural",
       DisplayName = "Themba",
       LocalName = "Themba",
       ShortName = "zu-ZA-ThembaNeural",
       Gender = "Male",
       Locale = "zu-ZA",
       LocaleName = "Zulu South Africa",

       VoiceType = "Neural",
       Status = "GA",
       WordsPerMinute = "90"
   }

            };
                applicationDbContext.Language.AddRange(languages);
                await applicationDbContext.SaveChangesAsync();
            }
            using (RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>())
            {
                string[] roles = new string[] { "User", "Admin" };

                var newrolelist = new List<IdentityRole>();
                foreach (string role in roles)
                {
                    if (!_roleManager.Roles.Any(r => r.Name == role))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(role));
                    }
                }

                using (UserManager<IdentityUser> _userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>())
                {
                    IdentityUser user = new IdentityUser()
                    {
                        UserName = "admin@neuralspeak.com",
                        Email = "admin@neuralspeak.com",
                        LockoutEnabled = false,
                        PhoneNumber = "1234567890",
                    };
                    if (!_userManager.Users.Any(r => r.UserName == user.UserName))
                    {
                        var result = await _userManager.CreateAsync(user, "Admin@123");
                        if (result.Succeeded)
                        {
                            var adminRole = await _roleManager.FindByNameAsync("Admin");
                            if (adminRole != null)
                            {
                                IdentityResult roleresult = await _userManager.AddToRoleAsync(user, adminRole.Name);
                            }
                        }
                    }

                }
            }
        }
    }
}