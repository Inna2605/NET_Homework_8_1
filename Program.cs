//Створіть набір методів для роботи з масивами:
//■ Метод для отримання усіх парних чисел у масиві;
//■ Метод для отримання усіх непарних чисел у масиві;
//■ Метод для отримання усіх простих чисел у масиві;
//■ Метод для отримання усіх чисел Фібоначчі в масиві.
//Використовуйте механізми делегатів.

using NET_Homework_8_1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
MyArray myArray = new MyArray();
myDelegate objDel = new myDelegate(myArray.Rand);
objDel += myArray.Print;
objDel += myArray.Even;
objDel += myArray.NotEven;
objDel += myArray.Prime;
objDel += myArray.Fibonacci;

objDel.Invoke();