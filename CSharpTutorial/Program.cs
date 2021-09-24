using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modulus operator - returns the remainder of a division
            var mod = 20 % 3;
            Console.WriteLine($"Remainder of { mod}");
           
            // Equals is an assignment, double equals is a boolean
            var a = 1;
            var b = 1;
            var IsAAndBEqual = (a == b);
            if (IsAAndBEqual == true)
            {
                Console.WriteLine("The variables are equal!");
            }
            else
            {
                Console.WriteLine("The values do not match.");
            }

            // Increment/Decrement 
            var c = 5;
            var d = ++c; // d is 6, c is 6
            var e = d++; // e is 6, d is 7, e is assigned to the current value of d, d is then incremented

            // LOGICAL OPERATORS

            var Equals = (d == c);
            var NotEquals = (d != c);
            var GreaterThan = (d > c);
            var LessThan = (d < c);
            var And = (d< 5 && c < 5);
            var Or = (d < 5 || c < 5);
            var Not = (!(c==0));
        }
    }
}
