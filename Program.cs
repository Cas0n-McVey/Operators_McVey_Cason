using System;

namespace Operators_McVey_Cason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTEGERS");
            // Initializes an integer that multipies two integers
            int intMult = 6 * 45;
            // Initialized an integer that adds two integers
            int intAdd = 55 + 66;
            // Prints the maximum and minimum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}.");

            //Initializes boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.\n");



            Console.WriteLine("SHORTS");
            // Initializes an short that multipies two shorts
            short shortMult = 50 * 4;
            // Initialized an short that adds two shorts
            short shortAdd = 100 + 100;
            // Prints the maximum and minimum of the two short variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. " +
                $"The min of the two is {Math.Min(shortMult, shortAdd)}.");

            //Initializes boolean to see if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            // Prints if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.\n");



            Console.WriteLine("LONGS");
            // Initializes an long that multipies two longs
            long longMult = 5 * 50;
            // Initialized an long that adds two longs
            long longAdd = 110 + 110;
            // Prints the maximum and minimum of the two long variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}. " +
                $"The min of the two is {Math.Min(longMult, longAdd)}.");

            //Initializes boolean to see if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            // Prints if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.\n");



            Console.WriteLine("FLOATS");
            // Initializes an float that multipies two floats
            float floatMult = 8.7f * 17.99f;
            // Initialized an float that adds two floats
            float floatAdd = 66.66f + 90.98f;
            // Prints the maximum and minimum of the two float variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. " +
                $"The min of the two is {Math.Min(floatMult, floatAdd)}.");

            //Initializes boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // Prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.\n");



            Console.WriteLine("DOUBLES");
            // Initializes an double that multipies two doubles
            double doubleMult = 9.55 * 17.32;
            // Initialized an double that adds two doubles
            double doubleAdd = 90.39 + 90.99;
            // Prints the maximum and minimum of the two double variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. " +
                $"The min of the two is {Math.Min(doubleMult, doubleAdd)}.");

            //Initializes boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // Prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.\n");



            Console.WriteLine("DECIMALS");
            // Initializes an decimal that multipies two decimals
            decimal decimalMult = (decimal)(6.50 * 28.50);
            // Initialized an decimal that adds two decminals
            decimal decimalAdd = (decimal)(100.50 + 80.25);
            // Prints the maximum and minimum of the two decimal variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}. " +
                $"The min of the two is {Math.Min(decimalMult, decimalAdd)}.");

            //Initializes boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // Prints if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.");



        }
    }
}
