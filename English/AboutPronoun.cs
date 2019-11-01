using LingvoNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    class AboutPronoun
    {
        public static void About(Pronoun pronoun, ref Person person, ref Number number, ref Gender gender) {
            switch (pronoun) {
                case Pronoun.Я:
                    person = Person.First;
                    number = Number.Singular;
                    break;
                case Pronoun.Мы:
                    person = Person.First;
                    number = Number.Plural;
                    break;
                case Pronoun.Ты:
                    person = Person.Second;
                    number = Number.Singular;
                    break;
                case Pronoun.Вы:
                    person = Person.Second;
                    number = Number.Plural;
                    break;
                case Pronoun.Он:
                    person = Person.Third;
                    number = Number.Singular;
                    gender = Gender.M;
                    break;
                case Pronoun.Она:
                    person = Person.Third;
                    number = Number.Singular;
                    gender = Gender.F;
                    break;
                case Pronoun.Оно:
                    person = Person.Third;
                    number = Number.Singular;
                    gender = Gender.N;
                    break;
                case Pronoun.Они:
                    person = Person.Third;
                    number = Number.Plural;
                    break;

            }
        }
    }
}
