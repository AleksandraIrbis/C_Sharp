//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("задача 1");
Console.WriteLine("Введите возводимое число ");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень возведения");
int expo=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Pow(number, expo)); 

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.WriteLine("задача 2");
Console.WriteLine("Введите число ");
string numbers=(Console.ReadLine());
int sum=0;
for(int i=0; i<numbers.Length; i++)
{
    int result=Convert.ToInt32(numbers[i]. ToString());
    sum=sum+ result;
   
    }
Console.WriteLine("Происходит магия,подождите...");  
Console.WriteLine(sum);


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("задача 3");
int[] array = new int[8]; // Дичь, которая говорит, что у нас есть некоторый массив целых чисел под названием "arr", с наполнением из 8 чисел
Random rand = new Random();// это новое рандомное число в переменной "rand", которая берет любое рандомное число
Console.WriteLine("Вывожу (а вот автор проги уже не очень вывозит) рандомный массив из 8 чисел от 0 до 1000");
for(int i=0; i<arr.Length; i++)
   {array[i] = rand.Next(0,1000);// взяли и сказали что каждое следующее число в массиве будет рандомно браться из переменной ранд в диапазоне от 0 до 1000
   Console.WriteLine(array[i]);}