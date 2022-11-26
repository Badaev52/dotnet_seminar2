string? str;
int num;

Console.Write("Введите число от 1 до 7: ");
str = Console.ReadLine();
Console.WriteLine();

num = Convert.ToInt32(str);

if(num > 0 && num < 8){

    if(num == 6 || num == 7)    Console.WriteLine("ДА");
    else                        Console.WriteLine("НЕТ");
}else{
    Console.WriteLine("Не правильно введенное число!");
}