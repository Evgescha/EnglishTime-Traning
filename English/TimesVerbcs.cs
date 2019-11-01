using LingvoNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    public class TimesVerbcs
    {
        Verb verb;
        Pronoun pronoun;

        Person person;
        Number number;
        Gender gender;

        public void setVerbAndPronoun(Verb verb, Pronoun pronoun) { this.verb = verb; this.pronoun = pronoun; }


        public string getStringTime(Verb verb, Pronoun pronoun, Times time) {
            this.verb = verb;
            this.pronoun = pronoun;

            AboutPronoun.About(pronoun,ref person, ref number, ref gender);
            Console.WriteLine("person: " +person);
            Console.WriteLine("number: " +number);
            Console.WriteLine("gender: " +gender);

            Console.WriteLine($"STRING: {pronoun} {verb[Voice.Active, person, number]}" );

            return null;
        }

        // Время: прошлое; Тип: вопрос;
        public string PastQuestion() { return null; }
        // Время: прошлое; Тип: утверждение;
        public string PastSimple() { return null; }
        // Время: прошлое; Тип: отрицание;
        public string PastNegative() { return null; }



        // Время: настоящее; Тип: вопрос;
        public string PresentQuestion() { return null; }
        // Время: настоящее; Тип: утверждение;
        public string PresentSimple() { return null; }
        // Время: настоящее; Тип: отрицание;
        public string PresentNegative() { return null; }



        // Время: будущее; Тип: вопрос;
        public string FutureQuestion() { return null; }
        // Время: будущее; Тип: утверждение;
        public string FutureSimple() { return null; }
        // Время: будущее; Тип: отрицание;
        public string FutureNEgative() { return null; }
    }
}
