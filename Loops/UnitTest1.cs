using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total < 10)
            {
                Console.WriteLine(total);
                // total = total + 1;
                //total += 1;
                total++;

            }

            total = 0;

            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal reached");
                    break;
                }
                total++;
            }

            Random randy = new Random();
            int counter;
            bool keepLooping = true;

            while (keepLooping)
            {
                counter = randy.Next(0, 20);

                if (counter == 6 || counter == 10)
                {
                    continue;
                }

                Console.WriteLine(counter);

                if (counter == 15)
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 31;

            //LCV Loop Control Variable
            // Setup        Keep Looping Condition   Do after each loop
            //    1            2               3
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            for (Random randy = new Random(); randy.Next(0, 10) != 8; Console.WriteLine("ahhh"))
            {

            }

            string[] instructors = { "Andrew", "Mike", "Josh", "Amanda" };
            for (int i = 0; i < instructors.Length; i++)
            {
                Console.WriteLine($"{instructors[i]} welcomes you");
            }


        }
        [TestMethod]
        public void ForEachLoops()
        {
            string[] instructors = { "Andrew", "Mike", "Josh", "Amanda" };

            foreach (string instructor in instructors)
            {
                Console.WriteLine(instructor);
            }

            foreach (char letter in "Dan")
            {
                Console.WriteLine(letter);
                Console.WriteLine("Dan"[2]);
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;

            do
            {
                Console.WriteLine("Hello!");
                Console.WriteLine(iterator++);
            }
            while (iterator < 10);

            do
            {
                Console.WriteLine("Do this anyway");
            } while (false);

            while (false)
            {
                Console.WriteLine("this never happens");
            }
        }
        [TestMethod]
        public void Challenge()
        {
            //supercalifragilisticexpialidocious

            string word = "supercalifragilisticexpialidocious";

            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

            foreach (char letter in word)
            {
                if (letter == 'i')
                {
                    Console.WriteLine('i');
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }
                Console.WriteLine(word.Length);
        }
    }
}
    