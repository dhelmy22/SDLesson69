﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
   public class Greeter
    {
        // Method
        // 1- access modifier - determines from where this class can be used (public)
        // 2- return type - what kind of thing is this method going to output, if anything 
        // 3- signature - a) name of method (sayhello) b) input parameters (name)
        // 4- body

        //1     2           3
        public void SayHello(string name)
        {
            //4
            Console.WriteLine($"Hello, {name}!");
        }
        public void SaySomething(string speech)
        {
            Console.WriteLine(speech);
        }

        public string GetRandomGreeting()
        {
            Random randy = new Random();
            string[] greetings = new string[] { "Hello", "Howdy", "Salve", "Hola", "Privet", "Greetings" };

            int randomNumber = randy.Next(0, greetings.Length);

            string greeting = greetings.ElementAt(randomNumber);
            //string greeting = greetings[randomNumber];

            return greeting;
        }
    }
}
