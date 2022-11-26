string? str;
int num;

Console.Write("Введите число: ");
str = Console.ReadLine();
Console.WriteLine();

num = Convert.ToInt32(str);

num = num / 10;
num = num % 10;

// num = num % 100;
// num = num / 10;

Console.WriteLine(num);