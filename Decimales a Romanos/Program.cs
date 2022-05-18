using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimales_a_Romanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 2365;
            Console.WriteLine("Valor Entero Principal: " + n);
            Console.WriteLine("De tal valor Entero de Numero Romanos: ");
            Console.WriteLine(int_to_Roman(n));
            n = 254;
            Console.WriteLine("Valor Entero Principal: " + n);
            Console.WriteLine("De tal valor Entero de Numero Romanos: ");
            Console.WriteLine(int_to_Roman(n));
            n = 45;
            Console.WriteLine("Valor Entero Principal: " + n);
            Console.WriteLine("De tal valor Entero de Numero Romanos: ");
            Console.WriteLine(int_to_Roman(n));
            n = 8;
            Console.WriteLine("Valor Entero Principal: " + n);
            Console.WriteLine("De tal valor Entero de Numero Romanos: ");
            Console.WriteLine(int_to_Roman(n));
        }

        public static string int_to_Roman(int n)
        {
            string[] roman_symbol = { "MMM", "MM", "M", "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C", "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X", "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };
            int[] int_value = { 3000, 2000, 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var roman_numerals = new StringBuilder();
            var index_num = 0;
            while (n != 0)
            { }
        }
    }
}

