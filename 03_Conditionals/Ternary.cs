using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void TestMethod1()
        {
            int age = 100;

            //bool isAdult = (age >= 18) ? true : false;

            string isAdult = (age >= 18) ? "yes" : "no";

            Console.WriteLine((age >= 100) ? "how does it feel to be a century old?" : "hi");
        }
    }
}
