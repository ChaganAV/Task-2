// See https://aka.ms/new-console-template for more information
Console.Write("Введите 2 числа, сначала первое: ");
string? sNumber1 = Console.ReadLine();

Console.Write("Теперь второе: ");
string? sNumber2 = Console.ReadLine();

int number1 = Convert.ToInt32(sNumber1);
int number2 = Convert.ToInt32(sNumber2);

if (number1>number2)
    Console.WriteLine($"Число {number1} больше {number2}");
else
    Console.WriteLine($"Число {number2} больше {number1}");