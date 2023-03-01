//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("задача 1");
Console.WriteLine("Введите размер массива");
int size= Convert.ToInt32(Console.ReadLine());
int count=0;
int[] array = new int[size]; // Дичь, которая говорит, что у нас есть некоторый массив целых чисел под названием "arr", с наполнением из 8 чисел
Random rand = new Random();// это новое рандомное число в переменной "rand", которая берет любое рандомное число
Console.WriteLine("вывожу массив:");
for(int i=0; i<size; i++)
   {
    array[i] = rand.Next(100,1000);// взяли и сказали что каждое следующее число в массиве будет рандомно браться из переменной ранд в диапазоне от 0 до 1000
    Console.WriteLine(array[i]);
    if(array[i]% 2 == 0)

    {
        count++;
    }
   }
Console.WriteLine($"В данном рандомно созданном массиве четных чисел:{count}" );


 //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
 Console.WriteLine("задача 2");
Console.WriteLine("Введите размер массива");
int lenght= Convert.ToInt32(Console.ReadLine());
int sum=0;
int[] slugcat = new int[lenght];
Console.WriteLine("вывожу массив:");
for(int i=0; i<lenght; i++)
   {
    slugcat[i] = rand.Next(-1000,1000);
    Console.WriteLine(slugcat[i]);
    if(i%2==0)
    {
        sum=sum+ slugcat[i];
       
    }
   }
  
   Console.WriteLine($"Сумма нечетных элементов в этом массиве равна {sum}");

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("задача 3");
Console.WriteLine("Введите размер массива");
int Lenght= Convert.ToInt32(Console.ReadLine());
int[] lizzard = new int[Lenght];
int max= 0;
int min= 999;
Console.WriteLine("вывожу массив:");
for(int i=0; i<Lenght; i++)
{
    lizzard[i] = rand.Next(0,1000);
    Console.WriteLine(lizzard[i]);
    if(lizzard[i]<min)
    {
        min= lizzard[i];
    }
    else if(lizzard[i]>max)
    {
        max=lizzard[i];
    }

}
int result=0;
result= max-min;
Console.WriteLine($"Разница между максимальным({max}) и минимальным ({min})элементами равна{result}");





