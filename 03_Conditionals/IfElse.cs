using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void TestMethod1()
        {
            int age = 35;

            if (age > 18)
            {
                Console.WriteLine("you are an adult, congrats.");
            }else if (age < 18)
            {
                Console.WriteLine("you are not an adult. go away kid.");
            }else
            {
                Console.WriteLine("blah");
            }

        }
    }
}
