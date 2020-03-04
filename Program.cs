using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Завд. ном. 11
            //Сортування покращенна бульбашка/обмін
            //ДЗ - інформ. двувим. мас.
            /*-----------------------------------*/

            Console.Write("Кол-во элементов массива:\t");
            int n = int.Parse(Console.ReadLine());
            int[] myArr = new int[n];

            Random(myArr);
            Console.WriteLine("\n\nОтсортированный массив в порядке возрастания:");
            SortByAscending(myArr);
            Count(myArr);

            Console.ReadLine();
        }

        static void Random(int[] myArr)
        {
            Random random = new Random();

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = random.Next(-50, 50);
                Console.Write(myArr[i] + " ");
            }
        }

        static void SortByAscending(int[] myArr)
        {
            bool flag = true;

            while (flag)
            {
                flag = false;
                for (int i = 0; i < myArr.Length - 1; i++)
                {
                    if (myArr[i] > myArr[i + 1])
                    {
                        int b = myArr[i];
                        myArr[i] = myArr[i + 1];
                        myArr[i + 1] = b;
                        flag = true;
                    }
                }
            }
        }

        static void Count(int[] myArr)
        {
            int count = 0;
            int sum = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 5 == 0)
                {
                    sum += myArr[i];
                    count++;
                }
                Console.Write(myArr[i] + " ");
            }

            Console.Write("\n\nСумма / 5 без остатка:\t" + sum);
            Console.Write("\nКол-во / 5 без остатка:\t" + count);
        }
    }
}
