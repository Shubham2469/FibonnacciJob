using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemoConsole
{
    public class Fibonacci
    {
            public List<int> GetFibonacci(int number)
            {
                List<int> res = new List<int>();
                int firstNumber = 0;
                int secondNumber = 1;
                int result = 0;
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
                res.Add(firstNumber);
                res.Add(secondNumber);
                for (int i = 0; i < number; i++)
                {
                    result = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = result;
                    res.Add(result);

                }
                return res;

            }

        }
}
