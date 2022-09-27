

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ASPTranslator.Models
{
	public class GoogleApi { 
	
		public GoogleApi() { }

		public TranslationModel GetTranslation(TranslationModel translation) { 

			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Post,
				RequestUri = new Uri("https://google-translate1.p.rapidapi.com/language/translate/v2"),
				Headers =
				{
					{ "X-RapidAPI-Key", "fe96c29976msh7164fa7f072bef1p19efc6jsn0ad83cbe2bb2" },
					{ "X-RapidAPI-Host", "google-translate1.p.rapidapi.com" },
				},
							Content = new FormUrlEncodedContent(new Dictionary<string, string>
				{
					{ "q", translation.TextToTranslate },
					{ "target", translation.TargetLanguage },
					{ "source", translation.SourceLanguage },
				}),
			};
			string translationText;
			using (var response = client.SendAsync(request).Result)
			{
				response.EnsureSuccessStatusCode();
                var body = response.Content.ReadAsStringAsync().Result;
				translationText = JObject.Parse(body)["data"]["translations"][0]["translatedText"].ToString();
                /*Console.WriteLine(body)*/;
            }

			translation.Translation = translationText;
			return translation;
		}
	}
	
}
