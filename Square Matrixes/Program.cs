using System.Net;
// ввод размерности квадратной таблицы
int N;
while (true)
    {
    Console.WriteLine("Введите размерность квадратной таблицы (N)");
    if (int.TryParse(Console.ReadLine(), out N))
        {
            if (N > 0)//проверка введённого числа, которое не может быть меньше или равно нулю и должно быть целым числом
            {
                break;
            }
        }
    else
        {
            Console.WriteLine("Размерность квадратной таблицы должна быть целым числом");
        }
    }
//создание массивов 
int [,] Anxn = new int[N,N];
int [,] Bnxn = new int [N,N];
//ввод пользователем диапазона для заполнения массивов случайными числами
int LowerLimit, UpperLimit;
while (true)
    {
        Console.WriteLine("Введите нижний предел для случайных целых чисел для заполнения");
        if (int.TryParse(Console.ReadLine(), out LowerLimit))
            {
                break;
            }
        else
            {
                Console.WriteLine("Нижний предел должнен быть целым числом");
            }
    }
//ввод и проверка верхнего значения диапазона, которое не может быть меньше нижнего
while (true)
    {
    Console.WriteLine("Введите верхний предел для случайных целых чисел для заполнения");
    if (int.TryParse(Console.ReadLine(), out UpperLimit))
        {
            if (LowerLimit<UpperLimit)
            {
                break;
            }
        }
    else
        {
            Console.WriteLine("Верхний предел должнен быть целым числом и не может быть меньше нижнего");
        }
    }
//заполнение матриц случайными числами в заданном диапазоне
Random Range = new Random();
Console.WriteLine("Матрица Anxn:");
for (int i = 0; i < Anxn.GetLength(0);i++)
    {
        for (int j = 0; j < Anxn.GetLength(1); j++)
            {
                Anxn[i,j] = Range.Next(LowerLimit,UpperLimit+1);
            }
    }
//вывод заполненной таблицы Anxn
for (int i = 0; i < Anxn.GetLength(0);i++)
    {
        for (int j = 0; j < Anxn.GetLength(1); j++)
            {
                Console.Write(Anxn[i,j] + "\t");
            }
            Console.WriteLine();
    }
Console.WriteLine("--------------------------------");
Console.WriteLine("Матрица Bnxn:");
//заполнение и вывод второй матрицы
for (int i = 0; i < Bnxn.GetLength(0);i++)
    {
        for (int j = 0; j < Bnxn.GetLength(1); j++)
            {
                Bnxn[i,j] = Range.Next(LowerLimit,UpperLimit+1);
            }
    }
for (int i = 0; i < Bnxn.GetLength(0);i++)
    {
        for (int j = 0; j < Bnxn.GetLength(1); j++)
            {
                Console.Write(Bnxn[i,j] + "\t");
            }
            Console.WriteLine();
    }
//создание третьей матрицы, в которой будут храниться значения после сложения и вычитания матриц
int [,] Cnxn = new int [N,N];
//сложение матриц и вывод результата
for (int i = 0; i < Cnxn.GetLength(0); i++)
    {
        for (int j = 0; j < Cnxn.GetLength(1); j++)
        {
            Cnxn[i,j] = Anxn[i,j] + Bnxn[i,j];
        }
    }
Console.WriteLine("Сумма матриц Anxn и Bnxn:");
for (int i = 0; i < Cnxn.GetLength(0);i++)
    {
        for (int j = 0; j < Cnxn.GetLength(1); j++)
            {
                Console.Write(Cnxn[i,j] + "\t");
            }
            Console.WriteLine();
    }
//вычитание матриц и вывод результата
for (int i = 0; i < Cnxn.GetLength(0); i++)
    {
        for (int j = 0; j < Cnxn.GetLength(1); j++)
        {
            Cnxn[i,j] = Anxn[i,j] - Bnxn[i,j];
        }
    }
Console.WriteLine("Вычитание матрицы Bxnx из Axnx:");
for (int i = 0; i < Cnxn.GetLength(0);i++)
    {
        for (int j = 0; j < Cnxn.GetLength(1); j++)
            {
                Console.Write(Cnxn[i,j] + "\t");
            }
            Console.WriteLine();
    }