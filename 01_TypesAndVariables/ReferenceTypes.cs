using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Andrew";
            string lastName = "Torr";

            string concatenatedFullName = firstName + " " + lastName;
            Console.WriteLine(concatenatedFullName);

            // compositing

            string compositeName = string.Format("my name is {0} {1}", firstName, lastName);
            Console.WriteLine(compositeName);

            // interpolation

            string interpolatedName = $"{firstName} {lastName}";
            Console.WriteLine(interpolatedName);

        }

        [TestMethod]
        public void Classes()
        {
            Random randy = new Random();
            //randy is now an Object of type/class Random

            int randomNumber = randy.Next(1, 11);
            Console.WriteLine(randomNumber);

            int otherRandomNumber = randy.Next(1, 11);
            Console.WriteLine(otherRandomNumber);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World!";
            string[] stringArray = { "Hello", "world", "why", "is it", "always", stringExample, "?" };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            // update array
            stringArray[0] = "hello there";
            Console.WriteLine(stringArray[0]);

            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("hello");

            List<int> listOfInts = new List<int>();
            listOfInts.Add(456);

            int firstInt = listOfInts[0];

            Queue<string> fistInFirstOut = new Queue<string>();

            fistInFirstOut.Enqueue("i'm first");
            fistInFirstOut.Enqueue("i'm next");

            string firstItem = fistInFirstOut.Dequeue();
            string nextItem = fistInFirstOut.Dequeue();

            Console.WriteLine(firstItem);
            Console.WriteLine(nextItem);

            Dictionary<string, string> keyAndValue = new Dictionary<string, string>();
            keyAndValue.Add("name", "Andrew");

            //SortedList
            //HashSet
            //Stack
        }
    }
}
