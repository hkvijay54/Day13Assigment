using System;


namespace Day13Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uc1//
            Console.WriteLine("FIND THE MAXIMUM INTEGER NUMBER!");
            int output = UC1FIND_MAXIMUM_NUMBER.MaximumIntegerNumber(11, 5, 40);
            Console.WriteLine(output);

            Console.WriteLine("FIND THE MAXIMUM Float NUMBER!");
            float floatoutput = (float)UC2_USEFLOAT_FIND_MAX_NUMBER.MaximumFloatNumber(2.3, 4.5, 6.6);
            Console.WriteLine(floatoutput);
        }
    }
}