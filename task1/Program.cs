// Задача 1: Напишите программу, которая принимает на вход трёхзначное
//число и на выходе показывает вторую цифру этого числа.


int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int a = Prompt("Введите трехзначное число > ");
if (a < 1000 && a > 99)
{
    int b = a / 10;
    int result = b % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}