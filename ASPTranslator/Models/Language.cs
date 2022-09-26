using System;

namespace ASPTranslator.Models
{
    public class Language
    {
        public static string SelectSourceLanguage()
        {
            string sL = "";
            Console.WriteLine("What language do you want to translate from?");
            var sourceLanguage = Console.ReadLine().ToLower();
            switch (sourceLanguage)
            {
                case "english":
                    sL = "en";
                    return sL;

                case "spanish":
                    sL = "es";
                    return sL;

                case "french":
                    sL = "fr";
                    return sL;

                case "german":
                    sL = "de";
                    return sL;

                case "russian":
                    sL = "ru";
                    return sL;

                case "japanese":
                    sL = "ja";
                    return sL;

                default:
                    sL = "en";
                    return sL;

            }

        }


        public static string SelectTargetLanguage()
        {
            string tL = "";
            Console.WriteLine("what language do you want to translate to?");
            var targetLanguage = Console.ReadLine().ToLower();
            switch (targetLanguage)
            {
                case "english":
                    tL = "en";
                    return tL;

                case "spanish":
                    tL = "es";
                    return tL;

                case "french":
                    tL = "fr";
                    return tL;

                case "german":
                    tL = "de";
                    return tL;

                case "russian":
                    tL = "ru";
                    return tL;

                case "japanese":
                    tL = "ja";
                    return tL;

                default:
                    tL = "es";
                    return tL;
            }




        }
    }
}
