//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("задача 1");
Console.WriteLine("Введите число");
bool check = false;
int number;
while (check != true)
{
    string array = Console.ReadLine();
    if (int.TryParse(array, out number))
    {
        for (int i = 0; array[i]> 0; i++)
        {
           Console.WriteLine(array[i]);
        } 
         break;      
       
    }
    else
    {
        Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
    }
}