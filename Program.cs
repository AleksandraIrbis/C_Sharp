Console.Write("Задача номер 1         ");
Console.Write("введите первое число");
int FirstValue=Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число");
int SecondValue=Convert.ToInt32(Console.ReadLine());
if (FirstValue > SecondValue)
 {
    Console.WriteLine("число "+ FirstValue + " больше числа " + SecondValue);
 }
 else 
 {
    Console.WriteLine("число "+ SecondValue + " больше числа " + FirstValue);
 }

Console.Write("Задача номер 2        ");
Console.Write("введите первое число ");
int FirstNumber=Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int SecondNumber=Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число ");
int ThirdNumber=Convert.ToInt32(Console.ReadLine());
if (FirstNumber> SecondNumber)
{
    if (FirstNumber> ThirdNumber)
    { Console.WriteLine("число " + FirstNumber+ " больше всех предложенных");}
}
if (SecondNumber > ThirdNumber)
{Console.WriteLine("число "+ SecondNumber+" больше всех предложенных");}
 else 
 {Console.WriteLine("число "+ ThirdNumber+ " больше всех предложенных");}


Console.Write("Задача номер 3        ");
Console.Write("введите число ");
int Mouse=Convert.ToInt32(Console.ReadLine());
if (Mouse%2 ==0)
{
    Console.WriteLine("Поздравляю, это число четное!");
    }
else
{ 
    Console.WriteLine("Увы, это число нечетное...");
    }

Console.Write("Задача номер 4       ");
Console.Write("введите число ");
int Ball=Convert.ToInt32(Console.ReadLine());
int Cat=0;
while (Ball> Cat)
{ 
    if (Cat%2== 0)
    {
    Console.WriteLine(Cat);}
    Cat++;
}
Console.WriteLine("Кажется это все четные числа от  0 до " + Ball);