using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Greeter greeter = new Greeter();

            greeter.SayHello("Aaron");

            string greeting = greeter.GetRandomGreeting();

            greeting = "Random greeting: " + greeting;

            greeter.SaySomething(greeting);
        }
        [TestMethod]
        public void MyTestMethod()
        {
            Calculator calculator = new Calculator();

            int fourHopefully = calculator.Add(2, 2);
            Console.WriteLine(fourHopefully);
        }

        [TestMethod]
        public void VehicleTest()
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Make = "blah";
            vehicle.SetModel("blahblah 2.0");

            Console.WriteLine(vehicle.Make);
            Console.WriteLine(vehicle.GetModel());
        }

    }
}
