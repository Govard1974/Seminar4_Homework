// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
/*

int CalculatePower(int A, int B)

{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень B: ");
int B = Convert.ToInt32(Console.ReadLine());


int result = CalculatePower(A, B);

Console.WriteLine($"{A} в степени {B} равно {result}");
*/

// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
/*

int CalculateSumOfDigits(int n) 
{
    int sum = 0;
    for (; n != 0; n /= 10)
    {
        sum += n % 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = CalculateSumOfDigits(number);

Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
*/

// Задача 29: Напишите программу, которая задаёт массив 
// из m элементов на основе данных, которые введет пользователь и выводит их на экран.

/*

Console.Write("Введите размер массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];
for (int i = 0; i < m; i++)
{
     Console.Write($"Введите элемент массива [{i}]: ");
     array[i] = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("Элементы массива:");
foreach (int element in array)
{
    Console.Write(element + " ");
}
Console.WriteLine();
*/
