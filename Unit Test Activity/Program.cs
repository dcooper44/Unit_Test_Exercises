using System;

namespace Unit_Test_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }        
    }


    public class UnitTestExamples
    {
        public decimal ConvertToOppositeType(decimal degrees, string type)
        {
            if(type.Equals("f", StringComparison.OrdinalIgnoreCase))
            {
                
                var value = (degrees - 32) * (5m / 9m);    
                return Decimal.Round(value);
                
            }
            else if(type.Equals("c", StringComparison.OrdinalIgnoreCase))
            {
                var value = (degrees * (9m / 5m)) + 32;
                return Decimal.Round(value);

            }
            else
            {
                return 44;
            }                
        }

        public string FizzBuzzBaz(int number)
        {
            if (((number % 3 == 0) || number.ToString().Contains('3')) && ((number % 5 == 0) || number.ToString().Contains('5')) && ((number % 7 == 0) || number.ToString().Contains('7')))
            {                                
                return "FizzBuzzBaz";
            }
            else if (((number % 3 == 0) || number.ToString().Contains('3')) && ((number % 5 == 0) || number.ToString().Contains('5')))
            {
                return "FizzBuzz";
            }
            else if (((number % 3 == 0) || number.ToString().Contains('3')) && ((number % 7 == 0) || number.ToString().Contains('7')))
            {
                return "FizzBaz";
            }
            else if((number % 5 == 0 || number.ToString().Contains('5')) && (number % 7 == 0 || number.ToString().Contains('7')))
            {
                return "BuzzBaz";
            }
            else if((number % 3 == 0) || number.ToString().Contains('3'))
            {
                return "Fizz";
            }
            else if (number % 5 == 0 || number.ToString().Contains('5'))
            {
                return "Buzz";
            }
            else if(number % 7 == 0 || number.ToString().Contains('7'))
            {
                return "Baz";
            }
            else
            {
                return default;
            }


        }
    }
   
}



