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
        Times time;

        Person person;
        Number number;
        Gender gender;

        string tempVerb;
        public void setVerbAndPronoun(Verb verb, Pronoun pronoun) { this.verb = verb; this.pronoun = pronoun; }


        public string getStringTime(Verb verb, Pronoun pronoun, Times time) {
            this.verb = verb;
            this.pronoun = pronoun;
            this.time = time;

            AboutPronoun.About(pronoun,ref person, ref number, ref gender);

            startTimeMethod(time);
            return $"STRING: {pronoun} {tempVerb}";
            
        }
        public void startTimeMethod(Times time) {
            
            switch (time) {
                case Times.PastQuestion:
                    tempVerb = PastQuestion();
                    break;
                case Times.PastSimple:
                    tempVerb = PastSimple();
                    break;
                case Times.PastNegative:
                    tempVerb = PastNegative();
                    break;
                case Times.PresentQuestion:
                    tempVerb = PresentQuestion();
                    break;
                case Times.PresentSimple:
                    tempVerb = PresentSimple();
                    break;
                case Times.PresentNegative:
                    tempVerb = PresentNegative();
                    break;
                case Times.FutureQuestion:
                    tempVerb = FutureQuestion();
                    break;
                case Times.FutureSimple:
                    tempVerb = FutureSimple();
                    break;
                case Times.FutureNEgative:
                    tempVerb = FutureNEgative();
                    break;

            }

            
        }
        // Время: прошлое; Тип: вопрос;
        public string PastQuestion() { return verb.Past(Voice.Active, gender)+"?" ; }
        // Время: прошлое; Тип: утверждение;
        public string PastSimple() { return verb.Past(Voice.Active, gender); }
        // Время: прошлое; Тип: отрицание;
        public string PastNegative() { return "не "+verb.Past(Voice.Active, gender) ; }



        // Время: настоящее; Тип: вопрос;
        public string PresentQuestion() { return verb[Voice.Active, person, number]+"?"; }
        // Время: настоящее; Тип: утверждение;
        public string PresentSimple() { return verb[Voice.Active, person, number]; }
        // Время: настоящее; Тип: отрицание;
        public string PresentNegative() { return "не "+ verb[Voice.Active, person, number]; }



        // Время: будущее; Тип: вопрос;
        public string FutureQuestion() { return verb.Future(Voice.Active, person, number)+"?"; }
        // Время: будущее; Тип: утверждение;
        public string FutureSimple() { return verb.Future(Voice.Active, person, number); }
        // Время: будущее; Тип: отрицание;
        public string FutureNEgative() { return "не "+verb.Future(Voice.Active, person, number); }
    }
}
