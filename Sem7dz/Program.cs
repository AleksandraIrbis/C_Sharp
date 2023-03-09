//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
Console.WriteLine("задача 1");
Console.WriteLine("введите количество строк");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int cols=Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
double[,] GetMatrix(int rows, int cols, int min, int max)
{
    double[,] matrix= new double[rows, cols];
    for(int i=0; i < rows; i++)
    {
        for(int j=0; j < cols; j++)
        {
            matrix[i, j]=Convert.ToDouble(rnd.Next(-1000, 1000)/10.0);
        
        }
    }
    return matrix;
}
void PrintrMatrix(double[,]matr)
{
     for( int i=0; i<matr.GetLength(0); i++)
    {
        for(int m=0; m<matr.GetLength(1); m++)
        {
            Console.Write(matr[i, m] +"\t");
        }
        Console.WriteLine();
    }
   
}
double[,]resultMatrix = GetMatrix(rows,cols,-1000,1000);
PrintrMatrix(resultMatrix);


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Задача 2");
Console.WriteLine("Введите строку массива");
int stroka= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите столбец массива");
int stolb= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("вывожу данный элемент из массива выше");
if(stroka<=rows && stolb<=cols)
{
    Console.WriteLine(resultMatrix[stroka-1,stolb-1]);
}
else 
{
    Console.WriteLine("Чел, ты же сам вводил число строк и столбцов, откуда я тебе возьму ячейку вне этого массива 0-0 ?");
}

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("задача 3");
Console.WriteLine("введите количество строк");
int etaj=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int podjezd=Convert.ToInt32(Console.ReadLine());
int[,] dom= new int[etaj, podjezd];
int[,] GetDom(int etaj, int podjezd, int minimum, int maximum)
{
    for(int i=0; i < etaj; i++)
    {
        for(int j=0; j < podjezd; j++)
        {
            dom[i, j]= new Random().Next(0, 10);
        
        }
    }
    return dom;
}
void PrintrDom(int[,]matr)
{
     for( int i=0; i<matr.GetLength(0); i++)
    {
        for(int m=0; m<matr.GetLength(1); m++)
        {
            Console.Write(matr[i, m] +"\t");
        }
        Console.WriteLine();
    }
   
}
int[,] resultDom = GetDom(etaj,podjezd,0, 10);
Console.WriteLine("Наш массив будет такой:");
PrintrDom(resultDom);
int jilcy=0;
int i=0;
double result=1;
for(int j=0; j< podjezd; j++ )
{
    for(i=0; i < etaj; i++)
    {
        jilcy=jilcy+dom[i,j]; 
    }
     result=jilcy/(double)(etaj); 
     Console.WriteLine($" Среднее ар. чисел в {j+1} столбце равно {result}"); 
     jilcy=0;
} 

