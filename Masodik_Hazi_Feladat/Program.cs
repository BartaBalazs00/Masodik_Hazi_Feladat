using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodik_Hazi_Feladat
{
    class Program
    {
        static bool MegegyeznekE(char karakter1, char karakter2)
        {
            string megoldas = "";
            if (karakter1 == '{' && karakter2 == '}')
            {
                return true;
            }
            else if (karakter1 == '<' && karakter2 == '>')
            {
                return true;
            }
            else if (karakter1 == '[' && karakter2 == ']')
            {
                return true;
            }
            else if (karakter1 == '(' && karakter2 == ')')
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            string sor = Console.ReadLine();
            while (sor.Length < 1 || sor.Length > 10000)
            {
                sor = Console.ReadLine();
            }
            
            string zarojelek = "()[]{}<>";
            string levagottSor = "";
            string megoldas = "Valid";
            for (int i = 0; i < sor.Length; i++)
            {
                int index = 0;
                while (index < zarojelek.Length && zarojelek[index] != sor[i] )
                {
                    index++;
                }
                if (index < zarojelek.Length)
                {
                    levagottSor += zarojelek[index];
                }
            }
            if (levagottSor.Length %2 == 1)
            {
                megoldas = "Invalid";
            }
            else
            {
            }

            Console.WriteLine(megoldas);
            Console.ReadLine();
        }
    }
}
