//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1 с использованием рекурсии
Console.WriteLine("Задача 1");
Console.WriteLine("Введите число N: ");
int N= Convert.ToInt32(Console.ReadLine());
int start=N;
int end=1;
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + "," + PrintNumbers(start -1, end));
}

Console.WriteLine(PrintNumbers(N, 1));

//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Задача 2");
Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int PrintSum(int m)
{
    if (m== n-1) return 0;
    return m +PrintSum(m-1);
}

Console.WriteLine($" Сумма  чисел в промежутке от {m} до {n} включительно равна: {PrintSum(m)}");
//у нас есть число. мы берем его, и прибавляем к нему его же, но меньше на единицу, одновременно записывая м-1 как новое м. И так до тех пор, пока м не будет равно н. 
//Тогда мы пишем стоп для проги и она выводит результат

//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
Console.WriteLine("Задача 3");
static uint Result(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Result(n - 1, 1);
    else
        return Result(n - 1, Result(n, m - 1));
}
 
Console.WriteLine(Result(2, 2)); 






