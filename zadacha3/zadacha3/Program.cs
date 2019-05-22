using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();

            StringBuilder filteredText = new StringBuilder();

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == ')' || txt[i] == '(')
                    filteredText.Append(txt[i]);
            }

            txt = filteredText.ToString();

            List<char> brakets = new List<char>();

            bool balanced = true;

            if (txt[0] == ')')
            {
                balanced = false;
            }
            else
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    if (txt[i] == '(')
                        brakets.Add('(');
                    if (txt[i] == ')')
                        brakets.Add('(');
                if (txt[i] == ')')
                {
                    if (brakets.Count > 0)
                    {
                            brakets.Remove('(');
                    }
                    else
                    {
                            balanced = false;
                    }
                }
            }
        }
            if (balanced == false || brakets.Count != 0)
            {
                Console.WriteLine("Not balanced");
            }
            else
            {
                Console.WriteLine("Balanced");
            }
        }
    }
    }



