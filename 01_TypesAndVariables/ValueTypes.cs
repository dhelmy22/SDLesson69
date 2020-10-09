using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            // PascalCase
            //camelCase
            //snake_case

            // declare a variable
            bool IsDeclared;

            // initialize a varable (assign a value)
            IsDeclared = true;



        }

        [TestMethod]
        public void Characters()
        {
            // characters HAVE to use single quotes (' ')
            char character = 'a';
            char symbol = '?';
            char specialCharacter = '\n';
            // CR = Carriage Return
            //LF = Line Feed
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte signedByteExample = -128;
            short shortExample = 32767;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;

        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            Console.WriteLine(1.452352353523523523523542345235235252345234524352452345245243523452345235);

            double doubleExample = 1.8745634634634634634634653465346534634563465d;
            Console.WriteLine(doubleExample);

            decimal decimalExample = 1.6546546546546546546546546546546546546546546546546m;
            Console.WriteLine(decimalExample);
        }


        enum PastryType { Cake, Croissant, Cookies, Scone, Danish, Baguette};

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            Console.WriteLine(myPastry);

        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateTime birthday = new DateTime(1980, 3, 22);
            Console.WriteLine(birthday);

            TimeSpan age = today - birthday;

        }
    }
}
