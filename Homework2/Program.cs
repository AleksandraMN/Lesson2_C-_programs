/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

using System;
class Program
{
	static int thirdPosition(int arg)
	{
		int number = arg;
		int position = 0;
		if(arg >= 100 && arg < 1000) position = arg  % 10;
		if(arg >= 1000 && arg < 10000) position = (arg / 10) % 10;
		if(arg >= 10000 && arg < 100000) position = (arg / 100) % 10;
		if(arg >= 100000 && arg < 1000000) position = (arg / 1000) % 10;
		if(arg >= 1000000) position = -2;
		if(arg < 100) position = -1;
		if(arg < 0) position = -2;
		return position;
	}
		static void AnyNumber()
		{
			Console.Write("Введите целое натуральное число от 100 до 999999 = ");
			int number = Convert.ToInt32(Console.ReadLine());
			int position = thirdPosition(number);
			if(position >= 0)
			{
				Console.WriteLine("Третья цифра этого числа = " + position + ".");	
			} 
			else if (position > -2 && position < 0)
			{
				Console.WriteLine("Третьей цифры нет!");
			} 
			else 
			{
				Console.WriteLine("Вы не ввели заданное число!");
			}
		}

		static void Main(string[] args)
		{
			AnyNumber();
		}
}


