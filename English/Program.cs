using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LingvoNET;

namespace English
{
    class Program
    {
        static void Main(string[] args)
        {
            VErbsLocal vl = new VErbsLocal("verbs.txt");
            TimesVerbcs timesVerbcs = new TimesVerbcs();

            while (true) { 
                Verb verb = vl.getRandom();
                Pronoun pronoun = (Pronoun)new Random().Next(8);
                Times time = (Times)new Random().Next(1,9);


                Console.WriteLine("VERB: "+verb.Word);
                Console.WriteLine("pronoun: "+pronoun);

                timesVerbcs.getStringTime(verb, pronoun, time);
                Console.ReadLine();
            }

            //// строка для перевода
            //var str = "";
            ////массив местоимений
            //string[] verbs = new string[] { "писать", "рисовать", "играть"};
            //Console.WriteLine("start");
            //while (true)
            //{
            //    // выбираем местоимение(из 8) и время (из 9)
            //    var randTime = new Random().Next(1, 3);

            //    Person person;
            //    Number number;
            //    Gender gender;
            //    gender = Gender.P;
            //    //определяем, единичное или множественное число
            //    if (randMest == 1 || randMest == 3 || randMest == 5 || randMest == 6 || randMest == 7)
            //    {
            //        number = Number.Singular;

            //    }
            //    else number = Number.Plural;
            //    //определяем склонение местоимения
            //    if (randMest == 1 || randMest == 2) person = Person.First;
            //    else if (randMest == 3 || randMest == 4) person = Person.Second;
            //    else person = Person.Third;

            //    switch (randMest) {
            //        case 5: gender = Gender.M; break;
            //        case 6: gender = Gender.F; break;
            //        case 7: gender = Gender.N; break;
            //        case 8: gender = Gender.P; break;
            //    }
            //    var verb = Verbs.FindOne(verbs[new Random().Next(1, verbs.Length)]);//поиск глагола "рисовать"
            //    if (verb != null)
            //    {
            //        switch (randTime)
            //        {
            //            case 1: str = verb.Past(Voice.Active, gender);  break;
            //            case 2: str = verb[Voice.Active, person, number]; break;
            //            case 3: str = verb.Future(Voice.Active, person, number); break;
            //        }
            //    }





            //    Console.WriteLine(str);                                                                 //....
            //    Console.ReadKey();
            //}
            //    Console.WriteLine("end");

            Console.ReadKey();
            
        }
    }
}
