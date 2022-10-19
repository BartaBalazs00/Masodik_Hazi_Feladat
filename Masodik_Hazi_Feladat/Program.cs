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
        static bool CanBeValid(char karakter1, char karakter2)
        {
            if (karakter1 == '{' && karakter2 == '}')
            {
                return true;
            }
            else if (karakter1 == '{' && karakter2 == '{')
            {
                return true;
            }
            else if (karakter1 == '}' && karakter2 == '{')
            {
                return true;
            }
            else if (karakter1 == '}' && karakter2 == '}')
            {
                return true;
            }
            else if (karakter1 == '<' && karakter2 == '>')
            {
                return true;
            }
            else if (karakter1 == '<' && karakter2 == '<')
            {
                return true;
            }
            else if (karakter1 == '>' && karakter2 == '<')
            {
                return true;
            }
            else if (karakter1 == '>' && karakter2 == '>')
            {
                return true;
            }
            else if (karakter1 == '[' && karakter2 == ']')
            {
                return true;
            }
            else if (karakter1 == '[' && karakter2 == '[')
            {
                return true;
            }
            else if (karakter1 == ']' && karakter2 == '[')
            {
                return true;
            }
            else if (karakter1 == ']' && karakter2 == ']')
            {
                return true;
            }
            else if (karakter1 == '(' && karakter2 == ')')
            {
                return true;
            }
            else if (karakter1 == '(' && karakter2 == '(')
            {
                return true;
            }
            else if (karakter1 == ')' && karakter2 == '(')
            {
                return true;
            }
            else if (karakter1 == ')' && karakter2 == ')')
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
            sor = levagottSor;
            if (sor.Length % 2 == 1)
            {
                megoldas = "Invalid";
            }
            else
            {
                bool voltBenneCsere = true;
                while (voltBenneCsere && sor.Length != 0)
                {
                    int elsoIndex = 0;
                    int masodikIndex = 1;
                    while (masodikIndex < sor.Length && !MegegyeznekE(sor[elsoIndex], sor[masodikIndex]))
                    {
                        elsoIndex++;
                        masodikIndex++;
                    }
                    if (masodikIndex < sor.Length)
                    {
                        levagottSor = "";
                        for (int i = 0; i < sor.Length; i++)
                        {
                            if (i != elsoIndex && i != masodikIndex)
                            {
                                levagottSor += sor[i];
                            }
                        }
                        sor = levagottSor;
                    }
                    else
                    {
                        voltBenneCsere = false;
                    }

                }
                if (sor.Length == 0)
                {
                    megoldas = "Valid";
                }
                else
                {
                    voltBenneCsere = true;
                    while (voltBenneCsere && sor.Length != 0)
                    {
                        int elsoIndex = 0;
                        int masodikIndex = 1;
                        while (masodikIndex < sor.Length && !CanBeValid(sor[elsoIndex], sor[masodikIndex]))
                        {
                            elsoIndex++;
                            masodikIndex++;
                        }
                        if (masodikIndex < sor.Length)
                        {
                            levagottSor = "";
                            for (int i = 0; i < sor.Length; i++)
                            {
                                if (i != elsoIndex && i != masodikIndex)
                                {
                                    levagottSor += sor[i];
                                }
                            }
                            sor = levagottSor;
                        }
                        else
                        {
                            voltBenneCsere = false;
                        }
                    }
                    if (sor.Length == 0)
                    {
                        megoldas = "CanBeValid";
                    }
                    else
                    {
                        megoldas = "Invalid";
                    }
                }
            }
            Console.WriteLine(megoldas);
            Console.ReadLine();
        }
    }
}
