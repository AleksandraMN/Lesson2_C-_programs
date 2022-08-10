/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

using System;
class Program
{
	static void SelectDay()
	{
		string [] daysWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
		int n = daysWeek.Length;
		WriteSelect(daysWeek);
		Console.WriteLine("\nУкажите цифру, обозначающую день недели от 1 до 7, чтобы данная программа проверила - является ли этот день выходным?");
		int numberDayWeek = Convert.ToInt32(Console.ReadLine());
		if (numberDayWeek < (n - 1) && numberDayWeek > 0)
		{
			Console.WriteLine(daysWeek[numberDayWeek-1] + " - нет, не является выходным днем!");
		} 
		else if (numberDayWeek >= (n - 1) && numberDayWeek <= n)
		{
			Console.WriteLine(daysWeek[numberDayWeek-1] + " - да, является выходным днем!");
		} else
		{
			Console.WriteLine("Вы не ввели заданную цифру!");
		}
	}
	static void WriteSelect(string[] args)
	{
		for(int i = 0; i < args.Length-1; i++)
		{
			Console.WriteLine(i+1 + " - " + args[i] + ", ");
		}
		Console.Write(args.Length + " - " + args[args.Length-1] + ". ");
	}
	static void Main(string[] args)
	{
		SelectDay();
	}
}

