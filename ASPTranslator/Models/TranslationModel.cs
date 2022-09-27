using System.Collections.Generic;

namespace ASPTranslator.Models
{
    public class TranslationModel
    {
        
        public string TargetLanguage { get; set; }
        public string SourceLanguage { get; set; }
        public string TextToTranslate { get; set; }
        public string Translation { get; set; }

        public List<string> languages { get; set; }  
        ////{ "English",
        ////"Spanish",
        ////"French",
        ////"German",
        ////"Italian",
        ////"Portugese"};
        //{ "en", "es", "fr", "de", "it", "pt"};

        public TranslationModel()
        {
            languages = new List<string>()
            { "en", "es", "fr", "de", "it", "pt"};            
            
        }
        
        


    }
}

