﻿using System;
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
            Verb verb;
            Pronoun pronoun;
            Times time;
            while (true) { 
                verb = vl.getRandom();
                pronoun = (Pronoun)new Random().Next(8);
                time = (Times)new Random().Next(1,9);


                Console.WriteLine("Глагол: "+verb.Word);
                Console.WriteLine("Местоимение: "+pronoun);

                Console.WriteLine(timesVerbcs.getStringTime(verb, pronoun, time));
                Console.ReadLine();
            }

           
            
        }
    }
}
