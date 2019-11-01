using LingvoNET;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    class VErbsLocal
    {
        Dictionary<int,string> dictionary;


        public VErbsLocal(string pathToFileVerbs) {
            dictionary = new Dictionary<int, string>();
            readFile(pathToFileVerbs);
        }
        //считываем все слова из файла в словарик
        void readFile(string path) {
            int count = 0;
            string s;
            StreamReader f = new StreamReader(path, Encoding.UTF8);
            while ((s = f.ReadLine()) != null)
            {
                dictionary.Add(count, f.ReadLine());
                count++;
            }
            f.Close();
        }


        //получаем рандомное слово из словаря
        public Verb getRandom() {
            return Verbs.FindOne( dictionary[
                                            new Random().Next(0,dictionary.Count-1)
                                            ]);
        }
    }
}
