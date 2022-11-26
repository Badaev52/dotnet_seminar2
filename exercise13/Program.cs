string? str;
int num;

Console.Write("Введите число: ");
str = Console.ReadLine();
Console.WriteLine();

num = Convert.ToInt32(str);

if ((num / 100) > 0){
    num = num % 1000;
    num = num / 100;    
    Console.WriteLine("Третья цифра: " + num);
}else{
    Console.WriteLine("Третьей цифры нет!");
}