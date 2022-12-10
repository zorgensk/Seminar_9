// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// Выполнить с помощью рекурсии.



int Func(int m, int n)
{
     if(m > n) return n;
    Console.Write(m+" ");
    return Func(m + 1, n) ;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Func(1,n);