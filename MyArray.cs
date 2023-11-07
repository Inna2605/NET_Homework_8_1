//Створіть набір методів для роботи з масивами:
//■ Метод для отримання усіх парних чисел у масиві;
//■ Метод для отримання усіх непарних чисел у масиві;
//■ Метод для отримання усіх простих чисел у масиві;
//■ Метод для отримання усіх чисел Фібоначчі в масиві.
//Використовуйте механізми делегатів.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_8_1
{
    public delegate void myDelegate();
    internal class MyArray
    {
        int[]myArrays= new int[10];
        public void Rand()//Заповнення рандомом
        {
            Random random = new Random();
            for(int i = 0; i < myArrays.Length; i++)
            {
                myArrays[i] = random.Next(-50, 50);
            }
        }
        public void Print()//Вивід на екран
        {
            Console.WriteLine("Масив рандомних чисел:");
            for (int i = 0; i < myArrays.Length; i++)
            {
                Console.Write($"{myArrays[i]} ");
            }
        }
        public int Arr()
        {
            for(int i = 0;i < myArrays.Length; i++)
            {
                return myArrays[i];
            }
            return 0;
        }
        public void Even()//парні числа
        {
            Console.WriteLine("\n\nПарні числа у масиві:");
            for (int i = 0; i < myArrays.Length; i++)
            {
                if (myArrays[i]%2 == 0)
                    Console.Write($"{myArrays[i]} ");
            }
        }
        public void NotEven()//непарні числа
        {
            Console.WriteLine("\n\nНепарні числа у масиві:");
            for (int i = 0; i < myArrays.Length; i++)
            {
                if (myArrays[i] % 2 != 0)
                    Console.Write($"{myArrays[i]} ");
            }
        }
        public bool IsPrime(int number)//перевірка на прості числа
        {
            if (number <= 1)
                return false;
            if (number == 2 || number == 3)
                return true;
            if (number % 2 == 0 || number % 3 == 0)
                return false;
            if ((number % 5 != 0) && (number % 7 != 0))
                return true;
            return false;
        }
        public void Prime()//прості числа
        {
            Console.WriteLine("\n\nПрості числа у масиві:");
            for (int i =  0; i < myArrays.Length; ++i)
            {
                if (i <= myArrays.Length)
                {
                    if (i == myArrays.Length) return;
                    if (IsPrime(myArrays[i]))
                    {
                        Console.Write($"{myArrays[i]} ");
                    }
                }
            }  
        }
        public bool IsFibonacci(int number)//перевірка на числа Фібоначчі
        {
            if (number < 0)
                return false;
            if (number == 0 || number == 1)
                return true;
            int F = 2, A = 1;
            for (int i = 2; F <= number; i++)
            {
                F += A;
                A = F - A;
                if (number == F)
                    return true;
            }
            return false;
        }
        public void Fibonacci()//Фібоначчі
        {
            Console.WriteLine("\n\nЧисла Фібоначчі у масиві:");
            for (int i = 0; i < myArrays.Length; i++)
            {
                if (IsFibonacci(myArrays[i]))
                {
                    Console.Write($"{myArrays[i]} ");
                }
            }
        }
    }
}
