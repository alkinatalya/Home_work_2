﻿// Задача 2: Напишите программу, которая выводит случайное трёхзначное
// число и удаляет вторую цифру этого числа.

int value = new Random().Next(100, 1000);

System.Console.WriteLine(value);

int firstNumber = value / 100;
int secondNumber = value % 10;
int result = firstNumber * 10 + secondNumber;
// System.Console.Write(firstNumber);
//System.Console.WriteLine(secondNumber);
System.Console.WriteLine(result);