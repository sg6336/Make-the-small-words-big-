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
            //Kata.SmallWordHelper("The quick brown fox jumps over the lazy dog");
        }
    }

    public class Kata
    {
        public static string SmallWordHelper(string sentence)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
            String[] strings = sentence.Split(' ');
            List<string> strlist = new List<string>();
            foreach (string str in strings)
            {
                if (str.Length <= 3)
                {
                    strlist.Add(str.ToUpper());
                    continue;
                }

                string strnew = "";
                foreach  (char ch in str)
                {
                    bool flag = true;
                    foreach  (char vo in vowels)
                    {
                        if (ch == vo || ch == Char.ToUpper(vo))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        strnew += ch;
                    }
                }
                strlist.Add(strnew);
            }

            sentence = String.Join(" ", strlist.ToArray());

            return sentence;
        }
    }
}
