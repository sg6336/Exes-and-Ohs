using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.XO("xxxm");
        }
    }

    public static class Kata
    {
        public static bool XO(string input)
        {
            int o = 0;
            int x = 0;
            input = input.ToLower();
            char[] arr = input.ToCharArray();
            o = input.Count(c => c == 'o');
            x = input.Count(c => c == 'x');

            if (o == x) return true;
            else return false;
        }
    }
}


