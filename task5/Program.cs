// Задача 5 *: Напишите программу, которая генерирует несколько
// случайных чисел, и в цикле проверяет, кратны ли эти числа 
// предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет
// 15 -> нет
// 12 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите число которому кратно случайное число>");
int number = new Random().Next(10, 100);
while (number % value != 0)
{
    System.Console.WriteLine($"{number} = нет");
    number = new Random().Next(10, 100);
}

System.Console.WriteLine($"{number} = да");