using System;

namespace Palindrome_3d_space_cube_table
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер задачи (19, 20, 23): ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {
                case 19:
                    TaskNineTeen();
                    break;
                case 20:
                    TaskTwenty();
                    break;
                case 23:
                    TaskTwentyThree();
                    break;
                default:
                    Console.WriteLine("Такой задачи не существует. Введите верную (19, 20 или 23)");
                    break;
            }

            #region Задача 20
            /*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            A(3, 6, 8); B(2, 1, -7), -> 15.84
            A(7, -5, 0); B(1, -1, 9)-> 11.53*/

            static void TaskTwenty()
            {
                Console.WriteLine("Введите координату Х первой точки: ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату Y первой точки: ");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату Z первой точки: ");
                double z1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату Х второй точки: ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату Y второй точки: ");
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату Z второй точки: ");
                double z2 = Convert.ToDouble(Console.ReadLine());

                double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
                Console.WriteLine($"Расстояние между точками в 3D пространстве = {result:f2}");
            }
            #endregion

            #region Задача 23
           /* Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
            3-> 1, 8, 27
            5-> 1, 8, 27, 64, 125*/

            static void TaskTwentyThree()
            {
                Console.WriteLine("Введите число: ");
                int N = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= N; i++)
                {
                    double res = Math.Pow(i, 3);
                    Console.Write(res + " ");
                }               
            }
            #endregion


            static void TaskNineTeen()
            {

            }

        }
    }
}










            /* Console.WriteLine("Введите пятизначное число: ");
             string stringNumber = Console.ReadLine();
             int number = Convert.ToInt32(stringNumber);
             int[] array = new int[stringNumber.Length];
             for (int i = 0; i < stringNumber.Length; i++)
             {
                 array[i] = stringNumber[i];
             }
             if (number >= 10000 & number <= 99999)
             {
                 IsPalindrom(number);
             }
             else
             {
                 Console.WriteLine("Число не пятизначное");
             }

         }

         static bool IsPalindrom(int number)
         {
             string str = Convert.ToString(number);
             for (int i = 0; i < str.Length / 2; i++)
             {
                 if (str[i] != str[str.Length - 1 - i])
                 {
                     return false;
                 }
             }
             return true;*/

