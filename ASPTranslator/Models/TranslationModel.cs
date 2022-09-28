using System.Collections.Generic;

namespace ASPTranslator.Models
{
    public class TranslationModel
    {

        public string TargetLanguage { get; set; }
        public string SourceLanguage { get; set; }
        public string TextToTranslate { get; set; }
        public string Translation { get; set; }

        public Dictionary<string, string> LanguagesDic { get; set; }
                
       
        public TranslationModel()
        {
            
            //Instantiate Dictionary
            LanguagesDic = new Dictionary<string, string>
            {
                { "en", "English" },
                { "es", "Spanish" },
                { "fr", "French" },
                { "de", "German" },
                { "it", "Italian" },
                { "pt", "Portugese" }
            };

            

        }
        
        


    }
}

