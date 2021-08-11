using System;
using System.Threading;

namespace RockPaperScissors
{
	class RPS
	{
		static void Main(string[] args)
		{
			//TODO: Read args and start relevant game

			string options;
			Menu();
			options=Console.ReadLine();
			if (options == "4")
			{
				NewGame(options);
			}
			else
			{
				TeletypeLine("UNAVAILABLE: PLEASE TRY AGAIN", ConsoleColor.DarkRed);
				Menu();
				options = Console.ReadLine();
			}
		}

		static void Menu()
		{
			Console.Clear();
			TeletypeLine("SHALL WE PLAY A GAME?", ConsoleColor.White);
			TeletypeLine("1. CHESS", ConsoleColor.DarkGray);
			TeletypeLine("2. POKER", ConsoleColor.DarkGray);
			TeletypeLine("3. FIGHTER COMBAT", ConsoleColor.DarkGray);
			TeletypeLine("4. ROCK, PAPER, SCISSORS", ConsoleColor.White);
			TeletypeLine("5. DESERT WARFARE", ConsoleColor.DarkGray);
			TeletypeLine("6. AIR-TO-GROUND ACTIONS", ConsoleColor.DarkGray);
			TeletypeLine("7. THEATERWIDE TACTICAL WARFARE", ConsoleColor.DarkGray);
			Console.WriteLine("");
			TeletypeLine("8. GLOBAL THERMONUCLEAR WAR", ConsoleColor.Yellow);
			Console.WriteLine("");
			TeletypeLine("9. EXIT", ConsoleColor.Red);
			Console.WriteLine("");
			TeletypeLine("ENTER YOUR CHOICE:", ConsoleColor.White);
		}

		static void NewGame(string options)
		{
			//Expansion for additional games

			GameRPS rps = new GameRPS();

		}

		//Helpers
		static void TeletypeLine(string toTeletype, ConsoleColor colour) {
			Console.ForegroundColor = colour;
			for (int i = 0; i < toTeletype.Length; i++)
			{
				Console.Write(toTeletype.Substring(i, 1));
				Thread.Sleep(30);
			}
			Console.ResetColor();
			Console.WriteLine();
			
		}
	}
}
