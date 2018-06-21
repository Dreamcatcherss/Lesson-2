using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstVariable = "\nмоя строка 1 ";
            string secondVariable = "\tмоя строка 2";
            string thirdVariable = "\aмоя строка 3";

            Console.WriteLine(firstVariable);
            Console.WriteLine(secondVariable);
            Console.WriteLine(thirdVariable);

            Console.ReadKey();
            
        }
    }
}
