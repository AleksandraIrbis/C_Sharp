//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("задача 1");
Console.WriteLine("Введите элементы через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество положительных элементов: {count}");

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1   y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("задача 2");
Console.WriteLine("Введите числа k1, k2, b1, b2  ");
int[] numbers=Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//(b2 - b1) / (k1 - k2)
double x=(numbers[3] - numbers[2]) /((double)numbers[0] - numbers[1]);
double y=numbers[0]*x+numbers[2];
Console.WriteLine($"Точка пересечения прямых будет по координатам {x} и {y}");
