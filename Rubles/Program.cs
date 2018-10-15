using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubles
{
    namespace Pluralize
    {
        public static class PluralizeTask
        {
            public static string PluralizeRubles(int count)
            {
                // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
                int lastdigit = (count % 100);
                if (lastdigit > 10 && lastdigit < 20)
                {
                    return "рублей";
                }
                else
                {
                    switch (count % 10)
                    {
                        case 1:
                            return "рубль";
                        case 2:
                            return "рубля";
                        case 3:
                            return "рубля";
                        case 4:
                            return "рубля";
                        default:
                            return "рублей";
                    }
                }
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
