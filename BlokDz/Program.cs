Console.WriteLine("задача 1");
Console.WriteLine("Введите элементы через пробел: ");
string[] input=Console.ReadLine().Split();
string[] group = Array.FindAll(input, element => element.Length<4);
foreach (var element in group) Console.WriteLine(element);

// заполняем массив с клавы. далее с группу записываем все элементы, длинна которых меньше 4. выводим все элементы в группе последовательно))))
