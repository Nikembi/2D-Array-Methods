using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Methods
    {
        // Method definition

        // Method overloading:
        // same method name with different parameters, changing data types of parameters, sequence of parameters

        static int avg;// global 
        static int AddNumbers(int a, int b)
        {
            // total variable is local to AddNumber method 
            avg = 10;

            int total = a + b;// local
            Console.WriteLine(total);

            return total;
        }
        static float AddNumbers(int a, float b)
        {
            avg = 30;
            float total = a + b;
            Console.WriteLine(total);
            return total;
        }// scope ends here
        static void AddNumbers(float a, int b)
        {
            float total = a + b;
            Console.WriteLine(total);
        }
        static void AddNumbers(float a, float b)
        {
            float total = a + b;
            Console.WriteLine(total);
        }
        static void AddNumbers(int a, int b, int c)
        {
            int total = a + b + c;
            Console.WriteLine(total);
        }
        // Methods: name, parameters, return types
        // Define 2D Arrays jagged -> [,]
        static int factorial(int number)
        {
            int fact = 1;
            for (; number != 1; number = number - 1)
            {
                fact = fact * number;
            }
            Console.WriteLine(fact);
            return fact;
        }
        static void printDataInArray(int[] temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }
        static void FillDataInArray(int[] arr)
        {
            // put some data in array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter number on index " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // 2 dimensional arrays to n dimensions.
        public static void Main()
        {
            int result = AddNumbers(10, 20);// arguments
            Console.WriteLine(result);
            result = factorial(5);

            int[] arr = new int[5];// index => 0,...4
            FillDataInArray(arr);
            printDataInArray(arr);

            int[,] twoDArray = new int[3, 4];
            int[,] temp2DArray = new int[3, 4] {
            {1,2,3,4 },
            {11,12,13,14},
            {21,22,23,24}
            };
            Console.WriteLine(temp2DArray[0, 0]);
            Console.WriteLine(temp2DArray[0, 1]);
            Console.WriteLine(temp2DArray[0, 2]);
            Console.WriteLine(temp2DArray[0, 3]);

            for (int i = 0; i < 3; i++)// rows 3
            {
                for (int j = 0; j < 4; j++)// cols 4
                {
                    twoDArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)// rows 3
            {
                Console.Write("[");
                for (int j = 0; j < 4; j++)// cols 4
                {
                    Console.Write(twoDArray[i, j] + " , ");
                }
                Console.Write(" ]");
                Console.WriteLine();
            }

        }
    }
}
