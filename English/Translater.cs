using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace English
{
    class Translater
    {
        static string basic = "https://translate.yandex.net/api/v1.5/tr.json/translate?";
        static string lang = "lang=ru-en&";
        static string key = "key=trnsl.1.1.20191103T142321Z.c1d1bc68e657050e.ef668791518b18db8bc50825bb0ab787007587f4&";
        static string text ="text=";
        public static string translite(string strToTranslate) {
            string answer;
            WebRequest request = WebRequest.Create(basic+lang+key+text+strToTranslate);
            WebResponse response = request.GetResponse();
            using (System.IO.Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    dynamic data = JObject.Parse(reader.ReadToEnd());
                    answer = (string)data.text[0];
                    //Console.WriteLine(data.text);
                }
            }
            response.Close();

            return answer;
        }

    }
}
