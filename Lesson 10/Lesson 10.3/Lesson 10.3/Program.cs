using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            public static int StrangeSum(int[] inputArray)
            {
                int sum = 0;
                for (int i = 0; i < inputArray.Length; i++)//O(n)
                {
                    for (int j = 0; j < inputArray.Length; j++)//n
                    {
                        for (int k = 0; k < inputArray.Length; k++)//n
                        {
                            int y = 0;

                            if (j != 0)
                            {
                                y = k / j;
                            }

                            sum += inputArray[i] + i + k + j + y;
                        }
                    }
                }

                return sum; //O(N^3)
            }


        }
    }
}
