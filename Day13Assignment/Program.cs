using System;


namespace Day13Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("FIND THE MAXIMUM INTEGER NUMBER!");
            int output = UC1FIND_MAXIMUM_NUMBER.MaximumIntegerNumber(11, 5, 40);
            Console.WriteLine(output);

            Console.WriteLine("FIND THE MAXIMUM Float NUMBER!");
            float floatoutput = (float)UC2_USEFLOAT_FIND_MAX_NUMBER.MaximumFloatNumber(2.3, 4.5, 6.6);
            Console.WriteLine(floatoutput);

            Console.WriteLine("FIND THE MAXIMUM String Value!");
            string stringoutput = (string)Uc3maximum_3_strings.MaximumString("apple ", "ball", "cat");
            Console.WriteLine(stringoutput);

            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMax<int> gen = new GenericMax<int>(intArray);
            gen.PrintMaxValue();

            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMax<double> genDouble = new GenericMax<double>(doubleArray);
            genDouble.PrintMaxValue();

            string[] stringArray = { "111", "222", "333", "55", "999" };
            GenericMax<string> genString = new GenericMax<string>(stringArray);
            genString.PrintMaxValue();

            Console.WriteLine("Find Max Integer Number!");
            GenericMaximum<int> generic = new GenericMaximum<int>(112, 344, 432);
            generic.MaxMethod();
        }
    }
}