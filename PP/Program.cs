﻿////Задание 1
//Console.WriteLine("Введите 1-ое число:");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите 2-ое число:");
//double  b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Выберите операцию: + - Сложение, - - Вычитание, / - Умножение, * - Деление");
//string p = Console.ReadLine();

//double r = 0;

//if (p == "+")
//{
//    r = a + b;
//    Console.WriteLine(r);
//}
//if (p == "-")
//{
//    r = a - b;
//    Console.WriteLine(r);
//}
//if (p == "/")
//{
//    r = a / b;
//    Console.WriteLine(r);
//}
//if (p == "*")
//{
//    r = a * b;
//    Console.WriteLine(r);
//}


///Задание 2

//Console.WriteLine("Введите строку:");
//string k = Console.ReadLine();
//int c = k.Length;

//string[] m = k.Split(',', ' ');
//int w = m.Length;

//string[] r = k.Split('.' , '?' , '!');
//int p = r.Length-1;

//Console.WriteLine("Вывод:");
//Console.WriteLine("Количество символов:" + c);
//Console.WriteLine("Количество слов:" + w);
//Console.WriteLine("Количество предложений:" + p);


///Задание 3
//Console.WriteLine("Таблица умножения");
//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.Write($"{i} * {j} = {i * j}\t");
//    }
//    Console.WriteLine();
//}

//Задание 4

//Console.WriteLine("Введите число:");
//int r = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Факториал числа {r} = {Factorial(r)}");
//    static int Factorial(int n)
//{
//    if (n == 0)
//        return 1;
//    else
//        return n * Factorial(n - 1);
//}

//Задание 5 

//Console.Write("Введите количество чисел: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int a = 0;
//int b = 1;

//for (int i = 0; i < n; i++)
//{
//    Console.Write(a + " ");

//    int t = a;
//    a = b;
//    b = t + b;
//}


//Задание 6
//Console.WriteLine("Введите число n:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Простые числа:");
//for (int i = 2; i <= a; i++)
//{
//    bool m = true;
//    for (int j = 2; j <= Math.Sqrt(i); j++)
//    {
//        if (i % j == 0)
//        {
//            m = false;
//            break;
//        }
//    }
//    if (m)
//    {
//        Console.WriteLine(i);
//    }
//}

//Задание 7

//Random r = new Random();
//int t = r.Next(1, 101);
//int u = 0;
//int a = 0;

//Console.WriteLine("Угадайте число от 1 до 100:");

//while (u != t)
//{
//    Console.Write("Введите ваше предположение: ");
//    string i = Console.ReadLine();

//    if (int.TryParse(i, out u))
//    {
//        a++;

//        if (u != t)
//        {
//            Console.WriteLine(u < t ? "Загаданное число больше." : "Загаданное число меньше.");
//        }
//        else
//        {
//            Console.WriteLine($"Поздравляем! Вы угадали число {t} с {a} попытки(-ок).");
//        }
//    }
//}


//Задание 8

//Console.WriteLine("Выберите фигуру:");
//string a = Console.ReadLine();

//if(a == "круг")
//{
//    Console.WriteLine("Введите число:");
//    int r = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Площадь круга равна:" + (3.14 * (r * r)));
//}
//if (a == "прямоугольник")
//{
//    Console.WriteLine("Введите число:");
//    int s = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Введите число:");
//    int l = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Площадь прямоугольника равна : " + (s*l));
//}
//if (a == "треугольник")
//{
//    Console.WriteLine("Введите число:");
//    int y = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Введите число:");
//    int t = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Введите число:");
//    int h = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Площадь треугольника равна" + ((y + t + h) / 2));
//}

//Задание 9
Console.WriteLine("Выберите единицу измерения: \n1. Длинна\n2. Вес");
double s = double.Parse(Console.ReadLine());

if (s == 1)
{
    Console.Write("Введите длину в метрах: ");
    double m = double.Parse(Console.ReadLine());
    Console.WriteLine("Выбор: \n1. мм\n2. см\n3. дм\n4. км");
    int l = int.Parse(Console.ReadLine());

    switch (l)
    {
        case 1: Console.WriteLine($"{m * 1000} мм"); break;
        case 2: Console.WriteLine($"{m * 100} см"); break;
        case 3: Console.WriteLine($"{m * 10} дм"); break;
        case 4: Console.WriteLine($"{m * 0.001} км"); break;
    }
}
else
{
    Console.Write("Введите вес в киллограммах: ");
    double e = double.Parse(Console.ReadLine());
    Console.WriteLine("Выбор: \n1. мг\n2. гр\n3. тонны\n4. пуды");
    int p = int.Parse(Console.ReadLine());

    switch (p)
    {
        case 1: Console.WriteLine($"{e * 1000000} мг"); break;
        case 2: Console.WriteLine($"{e * 1000} гр"); break;
        case 3: Console.WriteLine($"{e * 0,001} тонны"); break;
        case 4: Console.WriteLine($"{e * 0.06105} пуды"); break;
    }
}

////Задание 10
//Console.WriteLine("Введите число:");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите процент :");
//double z = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"{z}% от {a} равен {(a / 100) * z}");

//Задание 11
//Console.WriteLine("Введите сумму:");
//double sum = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Выбор: \n1. Евро в рубли\n2. Рубли в евро");
//int h = Convert.ToInt32(Console.ReadLine());
//if (h == 1)
//{
//    Console.WriteLine(sum * 97.81);
//}
//else
//if (h == 2)
//{
//    Console.WriteLine(sum / 97.81);
//}

//Задание 12

//Console.WriteLine("Рандомные числа:");
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//    Console.WriteLine($"Число {i + 1}: {a[i]}"); // Выводим каждое сгенерированное число
//}

//int min = a.Min();
//int indexMin = Array.IndexOf(a, min);
//Console.WriteLine("Минимальное:" + min);
//Console.WriteLine("Индекс минимального:" + indexMin);


//int max = a.Max();
//int indexMax = Array.IndexOf(a, max);
//Console.WriteLine("Максимальное:" + max);
//Console.WriteLine("Индекс максимального:" + indexMax);

// Задание 13
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//}

//Console.WriteLine("Исходный массив:");
//PrintArray(a);

//Console.WriteLine("\nСортировка по возрастанию (пузырьком):");
//BubbleSort(a, true);
//PrintArray(a);

//Console.WriteLine("\nСортировка по убыванию (пузырьком):");
//BubbleSort(a, false);
//PrintArray(a);

//Console.WriteLine("\nСортировка по возрастанию (вставками):");
//InsertionSort(a, true);
//PrintArray(a);

//Console.WriteLine("\nСортировка по убыванию (вставками):");
//InsertionSort(a, false);
//PrintArray(a);


//// Метод для сортировки пузырьком
//static void BubbleSort(int[] a, bool g)
//{
//    int n = a.Length;
//    for (int i = 0; i < n - 1; i++)
//    {
//        for (int j = 0; j < n - i - 1; j++)
//        {
//            if ((g && a[j] > a[j + 1]) || (!g && a[j] < a[j + 1]))
//            {
//                int t = a[j];
//                a[j] = a[j + 1];
//                a[j + 1] = t;
//            }
//        }
//    }
//}

//// Метод для сортировки вставками
//static void InsertionSort(int[] a, bool g)
//{
//    int n = a.Length;
//    for (int i = 1; i < n; i++)
//    {
//        int k = a[i];
//        int j = i - 1;

//        while (j >= 0 && ((g && a[j] > k) || (!g && a[j] < k)))
//        {
//            a[j + 1] = a[j];
//            j = j - 1;
//        }
//        a[j + 1] = k;
//    }
//}

//// Метод для вывода массива
//static void PrintArray(int[] a)
//{
//    Console.WriteLine(string.Join(", ", a));
//}

// Задание 14

//Console.WriteLine("Рандомные числа:");
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//    Console.WriteLine($"Число {i + 1}: {a[i]}"); // Выводим каждое сгенерированное число
//}
//Console.WriteLine("Введите элемент для поиска:");
//int m = int.Parse(Console.ReadLine());

//int index = Array.IndexOf(a, m);

//if (index >= 0)
//{
//    Console.WriteLine($"Число {m} найдено на индексе {index}.");

//}
//else
//{
//    Console.WriteLine("Число не найдено.");
//}

//Задание 15

//Console.WriteLine("Рандомные числа:");
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//    Console.WriteLine($"Число {i + 1}: {a[i]}"); // Выводим каждое сгенерированное число
//}
//Console.WriteLine("Массив в обратном порядке:");

//// Вывод элементов массива в обратном порядке
//for (int i = a.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(a[i]);
//}

//Задание 16

    //    int[,] A = { { 1, 2 }, { 3, 4 } }; int[,] B = { { 5, 6 }, { 7, 8 } };
    //    // Сложение
    //    Console.WriteLine("Сложение:"); PrintMatrix(Add(A, B));
    //    // Вычитание
    //    Console.WriteLine("\nВычитание:"); PrintMatrix(Subtract(A, B));
    //    // Умножение
    //    Console.WriteLine("\nУмножение:"); PrintMatrix(Multiply(A, B));
    //    // Транспонирование
    //    Console.WriteLine("\nТранспонирование A:"); PrintMatrix(Transpose(A));
    //    Console.WriteLine("\nТранспонирование B:"); PrintMatrix(Transposeу(B));
    
    //static int[,] Add(int[,] A, int[,] B) => new int[,]
    //    {             { A[0, 0] + B[0, 0], A[0, 1] + B[0, 1] },
    //        { A[1, 0] + B[1, 0], A[1, 1] + B[1, 1] }         };
    //static int[,] Subtract(int[,] A, int[,] B) =>
    //    new int[,]         {
    //        { A[0, 0] - B[0, 0], A[0, 1] - B[0, 1] },             { A[1, 0] - B[1, 0], A[1, 1] - B[1, 1] }
    //    };
    //static int[,] Multiply(int[,] A, int[,] B) => new int[,]
    //    {             { A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0], A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1] },
    //        { A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0], A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1] }         };
    //static int[,] Transpose(int[,] A) =>
    //    new int[,]         {
    //        { A[0, 0], A[1, 0] },             { A[0, 1], A[1, 1] }
    //    };
    //static int[,] Transposeу(int[,] B) =>
    //    new int[,]         {
    //        { B[0, 0], B[1, 0] },             { B[0, 1], B[1, 1] }
    //    };
    //static void PrintMatrix(int[,] matrix)
    //{
    //    Console.WriteLine($"{matrix[0, 0]} {matrix[0, 1]}"); Console.WriteLine($"{matrix[1, 0]} {matrix[1, 1]}");
    //}



