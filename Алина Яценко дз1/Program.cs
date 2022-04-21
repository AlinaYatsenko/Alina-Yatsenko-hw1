using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите свое имя:");
			string name = Console.ReadLine();
			Console.WriteLine($"Привет, {name}");
			Console.WriteLine("Введите свой возраст:");
			string age = Console.ReadLine();
			byte convertedAge = Convert.ToByte(age);
			if (convertedAge <= 10)
			{
				Console.WriteLine("Проходи тест, юный гений!");
			}
			else
			{
				Console.WriteLine("Быстрее проходи тест, чтобы узнать количество правильных ответов");
			}
			Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("3 простых вопросов на разные темы, которые заставят вас напрячься ");
			Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("В чём измеряется давление?");
			Console.WriteLine("1. Амперы");
			Console.WriteLine("2. Джоули");
			Console.WriteLine("3. Паскали");
			Console.WriteLine("Выбирите вариант ответа: ");
			int stranica = Convert.ToInt32(Console.ReadLine());
			if (stranica == 1)
			{
				Console.WriteLine("Не правильный ответ");
			}
			if (stranica == 2)
			{
				Console.WriteLine("Не правильный ответ");
			}
			if (stranica == 3)
			{
				Console.WriteLine("Правильный ответ");
			}
			Console.WriteLine("Отцом какой науки считается Геродот?");
			Console.WriteLine("1. Геометрия");
			Console.WriteLine("2. География");
			Console.WriteLine("3. История");
			Console.WriteLine("Выбирите вариант ответа: ");
			int stranica2 = Convert.ToInt32(Console.ReadLine());
			if (stranica2 == 1)
			{
				Console.WriteLine("Не правильный ответ");
			}
			if (stranica2 == 2)
			{
				Console.WriteLine("Не правильный ответ");
			}
			if (stranica2 == 3)
			{
				Console.WriteLine("Правильный ответ");
			}
			Console.WriteLine("Какое прозвище было у Пушкина в кругу друзей-лицеистов?");
			Console.WriteLine("1. Француз");
			Console.WriteLine("2. Мавр");
			Console.WriteLine("3. Кудрявый");
			Console.WriteLine("Выбирите вариант ответа: ");
			int stranica3 = Convert.ToInt32(Console.ReadLine());
			if (stranica3 == 1)
			{
				Console.WriteLine("Правильный ответ");
			}
			if (stranica3 == 2)
			{
				Console.WriteLine("Не правильный ответ");
			}
			if (stranica3 == 3)
			{
				Console.WriteLine("Не правильный ответ");
			}
		}
	}
}
