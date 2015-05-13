using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        { 
            var integers = new int[] { 2414, 7, 3174, 4888 };
            foreach (var integer in integers)
            {
                Console.WriteLine(integer + " == " + RomanNumerals.Translate(integer));
            }

            var numerals = new string[] { "XC", "XXX", "MX", "MLXII", "CDXV" };
            foreach (var numeral in numerals)
            {
                Console.WriteLine(numeral + " == " + Integers.Translate(numeral));
            }
        }
    }

    public class Integers
    {
        public static int Translate(string romanNumeral)
        {
            var result = 0;
            var numeral = romanNumeral;

            foreach (var item in Denomination.Table)
            {
                if (numeral.Length < item.Symbol.Length) continue;

                while (numeral.Length > 0 && numeral.Substring(0, item.Symbol.Length) == item.Symbol)
                {
                    result += item.Value;
                    numeral = numeral.Remove(0, item.Symbol.Length);
                }                
            }

            return result;
        }
    }

    public class Denomination
    {
        public int Value { get; set; }
        public string Symbol { get; set; }

        // TEST
        public static readonly Denomination[] Table =
            {
                new Denomination { Value = 1000, Symbol = "M" },
                new Denomination { Value = 900, Symbol = "CM" },
                new Denomination { Value = 500, Symbol = "D" },
                new Denomination { Value = 400, Symbol = "CD" },
                new Denomination { Value = 100, Symbol = "C" },
                new Denomination { Value = 90, Symbol = "XC" },
                new Denomination { Value = 50, Symbol = "L" },
                new Denomination { Value = 40, Symbol = "XL" },
                new Denomination { Value = 10, Symbol = "X" },
                new Denomination { Value = 9, Symbol = "IX" },
                new Denomination { Value = 5, Symbol = "V" },
                new Denomination { Value = 4, Symbol = "IV" },
                new Denomination { Value = 1, Symbol = "I" }
            };
    }

    public class RomanNumerals
    {      
        public static string Translate(int number)
        {
            var result = new StringBuilder();
            var remainder = number;
     
            foreach (var current in Denomination.Table)
            {
                while (remainder >= current.Value)
                {
                    result.Append(current.Symbol);
                    remainder -= current.Value;
                }
            }
     
            return result.ToString();
        }
    }
}
