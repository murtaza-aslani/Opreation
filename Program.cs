using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operation
{
    class Program
    {
        static void Main()
        {
            

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the seconde number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("---------------------");
            // ضرب
            int multiplicationResult = num1 * num2;
            Console.WriteLine("multiplication: " + multiplicationResult);

            // تفریق
            int subtractionResult = num1 - num2;
            Console.WriteLine("subtraction: " + subtractionResult);

            // تقسیم
            int divisionResult = num1 / num2;
            Console.WriteLine("division: " + divisionResult);

            Console.ReadLine();
        }
    }

}
