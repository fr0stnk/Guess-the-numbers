using System;

namespace TestOne
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Random randNum = new Random();
			//Initialization
			int num, num1, trnum, trnum1, count;
			bool success;
			string difStr = "easy";
			int difficult = 3;

			//EntryText
			Console.WriteLine(" Guess the numbers Game!");
			Console.WriteLine(" Made by fr0stnk\n");

			//Choosing Difficulty
			Console.WriteLine(" -----------------------");
			Console.WriteLine("|   Choose difficulty   |");
			Console.WriteLine("| (easy, medium, hard)  |");
			Console.WriteLine(" -----------------------\n");
			Console.Write("...");
			difStr = Console.ReadLine();

			//Difficulty
			switch (difStr)
			{
				case "easy": difficult = 3; break;
				case "medium": difficult = 5; break;
				case "hard": difficult = 7; break;
				default: break;
			}

			//Part of programm
			num = randNum.Next(difficult);
			num1 = randNum.Next(difficult);
			success = false;
			count = 0;

			//Working Part
			Console.WriteLine("\nResult of summing: " + (num + num1));
			Console.WriteLine("Try to guess used numbers\n");
			while (success != true)
			{
				count++;
				Console.WriteLine("Guess try #" + count);
				Console.WriteLine("Number 1: ");
				trnum = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Number 2: ");
				trnum1 = Convert.ToInt32(Console.ReadLine());
				if (trnum == num && trnum1 == num1)
				{
					Console.WriteLine("The numbers are guessed right");
					success = true;
				}
				else if (trnum == num || trnum1 == num1)
					Console.WriteLine("One number guessed right\n");
				else 
					Console.WriteLine("You made a mistake in both numbers\n");
			}
			//don't touch next string
			//string str = num == 666 ? "crap" : "allright";
		}
	}
}
