﻿// Задача 64:
// Выполнить с помощью рекурсии.Задайте значение N
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
PrintNumbers(number1);
//----------------------------------------------------------------------------------------------------

//-----------------------------------------------МЕТОДЫ-----------------------------------------------

//Рекурсивно выводит числа от N до 1.                                                                 (В задаче: 1)
void PrintNumbers(int N){
    if(N <= 0) return;

    if(N != 1){
       Console.Write($"{N}, "); 
    }
    else{
        Console.Write($"{N}.");
    }
    N--;
    PrintNumbers(N);
}