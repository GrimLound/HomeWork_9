// Задача 64:
// Выполнить с помощью рекурсии.Задайте значение N
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задача 64:");
Console.WriteLine("Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
Console.WriteLine();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine($"Числа от {number} до 1: ");
PrintNumbers(number);
Console.WriteLine();
Console.WriteLine("----------------------------------------");
Console.WriteLine("Для продолжения нажмите 'Enter': ");
Console.ReadLine();
Console.Clear();
//----------------------------------------------------------------------------------------------------

// Задача 66:
// Выполнить с помощью рекурсии.Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задача 66:");
Console.WriteLine("Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine($"Сумма чисел от {number1} до {number2}: ");
Console.WriteLine(PrintSummNumbers(number1, number2));
Console.WriteLine("----------------------------------------");
Console.WriteLine("Для продолжения нажмите 'Enter': ");
Console.ReadLine();
Console.Clear();
//----------------------------------------------------------------------------------------------------

// Задача 68:
// Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Задача 68:");
Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии.");
Console.WriteLine();
Console.Write("Введите первое неотрицательное число: ");
int number3 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе неотрицательное число: ");
int number4 = int.Parse(Console.ReadLine()!);
Console.Clear();
if(number3 <= 0 || number4 <= 0){
    Console.WriteLine("Числа должны быть положительные!");
}
else{
    Console.WriteLine(Acherman(number3, number4));
}
Console.WriteLine("----------------------------------------");
Console.WriteLine("Для завершения нажмите 'Enter': ");
Console.ReadLine();
Console.Clear();
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


//Рекурсивно выводит сумму чисел от M до N.                                                           (В задаче: 2)
int PrintSummNumbers(int M, int N){
    if(M == N) return M;
    if(N < M) return 0;
    else return (PrintSummNumbers(M + 1, N) + M);
}


//Метод вычисления функции Аккермана с помощью рекурсии                                               (В задаче: 3)
int Acherman(int M, int N){
    if (M == 0)
        {
            return N + 1;
        }
        else if((M > 0) && (N == 0))
        {
            return Acherman(M - 1, 1);
        }
        else if((M > 0) && (N > 0))
        {
            return Acherman(M - 1, Acherman(M, N - 1));
        }
        else{
           return N + 1; 
        }   
}