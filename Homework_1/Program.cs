// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Func(int m, int n)
{
     if(m > n) return n;
    Console.Write(m+" ");
    return Func(m + 1, n) ;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Func(1,n);