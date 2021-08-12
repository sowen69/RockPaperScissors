using System;
using System.Threading;

namespace RockPaperScissors
{
	public class RPS
	{
		public static bool status = true;
		public static void Main(string[] args)
		{
			
			while (status)
			{ 
				Menu();
			}
		}

		public static void Menu()
		{
			Console.Clear();
			TeletypeLine("SHALL WE PLAY A GAME?", ConsoleColor.White);
			TeletypeLine("1. ROCK, PAPER, SCISSORS", ConsoleColor.White);
			TeletypeLine("2. CHESS", ConsoleColor.DarkGray);
			TeletypeLine("3. POKER", ConsoleColor.DarkGray);
			TeletypeLine("4. FIGHTER COMBAT", ConsoleColor.DarkGray);
			TeletypeLine("5. DESERT WARFARE", ConsoleColor.DarkGray);
			TeletypeLine("6. AIR-TO-GROUND ACTIONS", ConsoleColor.DarkGray);
			TeletypeLine("7. THEATERWIDE TACTICAL WARFARE", ConsoleColor.DarkGray);
			Console.WriteLine("");
			TeletypeLine("8. GLOBAL THERMONUCLEAR WAR", ConsoleColor.DarkGray);
			Console.WriteLine("");
			TeletypeLine("9. EXIT", ConsoleColor.Red);
			Console.WriteLine("");
			TeletypeLine("ENTER YOUR GAME OF CHOICE:", ConsoleColor.White);

			string menuOption = Console.ReadLine();
			switch (menuOption) {
				case "9":
					Environment.Exit(0);
					break;
				case "1":
					NewGame(menuOption);
					break;
				case "8":
					for(int i = 0; i < 5; i++)
					{
						Console.BackgroundColor=ConsoleColor.White;
						Console.Clear();
						Thread.Sleep(1);
						Console.BackgroundColor = ConsoleColor.Black;
						Console.Clear();
						Thread.Sleep(1);
					}
					break;
				default:
					TeletypeLine("UNAVAILABLE: PLEASE TRY AGAIN", ConsoleColor.Red);
					break;

			}
		}

		static void NewGame(string menuOption)
		{
			GameRPS rps = new GameRPS(3);

		}

		//Helpers
		static void TeletypeLine(string toTeletype, ConsoleColor colour) {
			Console.ForegroundColor = colour;
			for (int i = 0; i < toTeletype.Length; i++)
			{
				Console.Write(toTeletype.Substring(i, 1));
				Thread.Sleep(2);
			}
			Console.ResetColor();
			Console.WriteLine();
			
		}
	}
}