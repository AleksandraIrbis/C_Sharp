//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("задача 1");
Console.WriteLine("введите количество строк");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int cols=Convert.ToInt32(Console.ReadLine());
int[,] table = new int[rows, cols];
FillMatrixRandom(table);
PrintMatrix(table);
SortToLower(table);
Console.WriteLine();
PrintMatrix(table);

void FillMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
}

void SortToLower(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
//проверить строку на максимальное число и посавить его на первое место.
//можно перестроить массив или создать новый


//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("задача 2");
Console.WriteLine("введите количество строк");
int stroka=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int stolb=Convert.ToInt32(Console.ReadLine());
int[,] neo= new int[stroka, stolb];
int[,] GetNeo(int stroka, int stolb, int minimum, int maximum)
{
    for(int i=0; i < stroka; i++)
    {
        for(int j=0; j < stolb; j++)
        {
            neo[i, j]= new Random().Next(0, 10);
        
        }
    }
    return neo;
}
void PrintrNeo(int[,]matr)
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
int[,] resultNeo = GetNeo(stroka,stolb,0, 10);
Console.WriteLine("Наш массив будет такой:");
PrintrNeo(resultNeo);
int sum = 100;
int index = 0;
for (int i = 0; i < neo.GetLength(0); i++)
{
    int temp = 0;
    for (int j = 0; j < neo.GetLength(1); j++) // посчитать каждую строку, сравнить с temp(по дефолту ноль, но так сумма первой строки) и если сумма меньше темпа, то перезаписать темп
        {
            temp= temp+ neo[i,j];
        }
    if (temp < sum)
    {
        sum = temp;
        index = i;
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов: {index+1}");
    
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("задача 3");
Console.WriteLine("введите количество строк");
int row1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int col1=Convert.ToInt32(Console.ReadLine());
int[,] matrix1= new int[row1, col1];
int[,] GetMatrix1(int row1, int col1, int min, int max)
{
    for(int i=0; i < row1; i++)
    {
        for(int j=0; j < col1; j++)
        {
            matrix1[i, j]= new Random().Next(0, 10);
        
        }
    }
    return matrix1;
}
void PrintMatrix1(int[,]matr)
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
int[,] resultMatrix1 = GetMatrix1(row1,col1,0, 10);
Console.WriteLine("Наш  первый массив будет такой:");
PrintMatrix1(resultMatrix1);



Console.WriteLine("введите количество строк второго массива");
int row2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов второго массива");
int col2=Convert.ToInt32(Console.ReadLine());
int[,] matrix2= new int[row2, col2];
int[,] GetMatrix2(int row2, int col2, int minimum, int maximum)
{
    for(int i=0; i < row2; i++)
    {
        for(int j=0; j < col2; j++)
        {
            matrix2[i, j]= new Random().Next(0, 10);
        
        }
    }
    return matrix2;
}
void PrintMatrix2(int[,]matr)
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
int[,] resultMatrix2 = GetMatrix2(row2,col2,0, 10);
Console.WriteLine("Наш второй массив будет такой:");
PrintMatrix2(resultMatrix2);




int[,] GetMultiplic(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) 
    {
        Console.WriteLine("Матрицы нельзя перемножить,количество столбцов первой матрицы и строк второй должно совпадать, ЭТО БАЗА");}
    int[,] multiplic = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                multiplic[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return multiplic;
}
void PrintMultiplic(int[,]matr)
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
int[,] resultMuliplic = GetMultiplic(matrix1,matrix2);
Console.WriteLine("Наш итоговый массив будет такой:");
PrintMultiplic(resultMuliplic);
 

 //Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
 
Console.WriteLine("Задача 4");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}