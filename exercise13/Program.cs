string? str;
int num;

Console.Write("Введите число: ");
str = Console.ReadLine();
Console.WriteLine();

num = Convert.ToInt32(str);

num = num / 100;

if (num > 0){    
    Console.WriteLine("Третья цифра: " + num);
}else{
    Console.WriteLine("Третьей цифры нет!");
}