using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leson_10._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            int d = 0;
            
                
                while (i < num)
                {
                    if (num % i == 0)
                    {
                        d++;
                        break;
                    }
                    else
                    {
                        i++;
                    };

                }

                if (d == 0)
                {
                    Console.WriteLine("Simple");
                }
                else
                {
                    Console.WriteLine("Not Simple");
                }

            
        }
    }
}
