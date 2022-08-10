/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

using System;
class Program
{
	static int SecondPosition(int arg)
	{
		int number = arg;
		int position = -1;
		if(arg >= 100 && arg < 1000) position = (arg / 10) % 10;
		return position;
	}
	static void AnyNumber()
	{	
		Console.Write("Введите целое натуральное трёхзначное число  = ");
		int number = Convert.ToInt32(Console.ReadLine());
		int position = SecondPosition(number);
		if(position > 0)
		{
			Console.WriteLine("Вторая цифра этого числа = " + position + ".");	
		} else
		{
			Console.WriteLine("Введённое чиcло не является трехзначным целым натуральным числом!");
		}
	}
	static void Main(string[] args)
	{
		AnyNumber();
	}
}
