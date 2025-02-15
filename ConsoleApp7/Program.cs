/* Описать функцию SumRange(A, B) целого типа, находящую сумму всех целых
чисел от A до B включительно (A и B — целые). Если A > B, то функция возвращает 0. С
помощью этой функции найти суммы чисел от A до B и от B до C, если даны числа A, B,
C. */

// вариант 6
int SumRange(int A, int B)
{
    if (A > B) return 0;
    int sum = 0;
    for (int i = A; i <= B; i++)
    {
        sum += i;
    }
    return sum;
}

// ПРОГРАММА

// ввод значений A,B,C
Console.Write("Введите A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите C: ");
int C = Convert.ToInt32(Console.ReadLine());


// вычисление A+B, B+C
int sumAB = SumRange(A, B);
int sumBC = SumRange(B, C);


// вывод результата
Console.WriteLine($"Сумма чисел от {A} до {B}: {sumAB}\nСумма чисел от {B} до {C}: {sumBC}");