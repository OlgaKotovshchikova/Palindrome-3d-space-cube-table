using System;

namespace Palindrome_3d_space_cube_table
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
             * 14212->нет
             * 12821->да
             * 23432->да*/
            
            Console.WriteLine("Введите пятизначное число: ");
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
            return true;
        }
    }
}
