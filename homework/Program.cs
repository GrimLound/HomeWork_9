// Задача 64:
// Выполнить с помощью рекурсии.Задайте значение N
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
PrintNumbers(number);*/
//----------------------------------------------------------------------------------------------------

// Задача 66:
// Выполнить с помощью рекурсии.Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintSummNumbers(number1, number2));
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


//Рекурсивно выводит сумму чисел от M до N.                                                           (В задаче: 1)
int PrintSummNumbers(int M, int N){
    if(M == N) return M;
    if(N < M) return 0;
    else return (PrintSummNumbers(M + 1, N) + M);
}