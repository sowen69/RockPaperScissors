using RockPaperScissors;
using RockPaperScissors.Interfaces;
using RockPaperScissors.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RockPaperScissors
{
	public class GameRPS : IGame
	{
		private IPlayer Human;
		private IPlayer AI;
		private int round = 0;
		private int rounds = 0;
		private int gameStatus = 0;

		// Lookup Matrix of results
		//	  R   P   S
		// R  0  -1   1
		// P  1   0  -1
		// S -1   1   0

		// ROW then COLUMN
		// 0  = DRAW, play again
		// 1  = WIN
		// -1 = LOOSE


		private int[,] Results = new int[3, 3]
		{
			{ 0,-1, 1 },
			{ 1, 0,-1 },
			{-1, 1, 0 }
		};

		public string GameName { get { return "Rock, Paper, Scissors"; } }

		public int GameRounds { get { return rounds; } set { rounds = value; } }

		public int GameStatus { get { return gameStatus; } set { gameStatus = value; } }

		public GameRPS(int noOfRounds)
		{
			CreatePlayer("HUMAN");
			CreatePlayer("AI");

			// Only start a game with an odd number of rounds
			if (noOfRounds % 2 == 0)
			{
				GameRounds = noOfRounds + 1;
			}
			else
			{
				GameRounds = noOfRounds;
			}

			
			while (round < rounds)
			{
				Console.Clear();
				Console.WriteLine($"WE ARE PLAYING BEST OUT OF {rounds}");
				Console.WriteLine($"RESULTS THIS GAME: {Human.PlayerName} HAS WON {Human.WinCount} {AI.PlayerName} HAS WON {AI.WinCount}");
								
				ChooseWeapon("HUMAN");
				ChooseWeapon("AI");

				// If it's a draw play again don't decreace round
				if (Human.CurrentWeapon == AI.CurrentWeapon)
				{
					Console.WriteLine("IT'S A DRAW. LET'S TRY AGAIN");
					continue;
				}
				
				// Calculate result
				int result = Results[((int)Human.CurrentWeapon), ((int)AI.CurrentWeapon)];
				switch (result)
				{
					case -1:
						Console.WriteLine("YOU LOOSE");
						AI.WinCount++;
						break;
					case 1:
						Console.WriteLine("YOU'RE A WINNER");
						Human.WinCount++;
						break;
					default:
						break;
				}

				if(Human.WinCount >= (rounds / 2) +0.5 || AI.WinCount >= (rounds / 2) +0.5)
				{
					GameOver();
					break;
				}
								
				// EXPANSION: Update game results to player history

				round++;
			}
		}

		private void GameOver()
		{
			Console.WriteLine($"IT'S ALL OVER: {Human.PlayerName}: {Human.WinCount} {AI.PlayerName}: {AI.WinCount}");
			Console.WriteLine("Press any key to continue");
			Console.ReadLine();
			string[] args = {""};
			RPS.Main(args);

		}

		private void Quit()
		{
			Console.WriteLine("YOU QUIT!");
			GameOver();
		}

		public void CreatePlayer(string playerType)
		{
			switch (playerType)
			{
				case "AI":
					{
						int whichAiPlayer = new Random().Next(1, 5);
						AI = new AiPlayer(whichAiPlayer);
						Console.WriteLine($"{Human.PlayerName} YOU WILL BE PLAYING {AI.PlayerName}");
						break;
					}

				case "HUMAN":
					{
						Console.WriteLine("PLEASE ENTER YOUR NAME:");
						string playerName = Console.ReadLine();
						Human = new Player(playerName);
						Console.WriteLine($"WELCOME {Human.PlayerName}!");
						break;
					}

				default:
					throw new Exception("PlayerType must be Human or AI");
			}

		}
		public void ChooseWeapon(string playerType) 
		{
			switch (playerType)
			{
				case "AI":
					int randWeapon = (int)new Random().Next(1, 3);
					AI.CurrentWeapon = (Weapon)randWeapon; 
					Console.WriteLine($"{AI.PlayerName} PICKED {AI.CurrentWeapon}");
					break;
				case "HUMAN":
					{
						//Console.Clear();
						Console.WriteLine($"ROUND {round+1}: CHOOSE YOUR WEAPON {Human.PlayerName}! Rock(R), Paper(P), Scissors(S) or Quit(Q)");
						string results = Console.ReadLine().ToLower();
						switch (results)
						{
							case "q":
								Quit();
								break;
							case "r":
								Human.CurrentWeapon = Weapon.Rock;
								break;
							case "p":
								Human.CurrentWeapon = Weapon.Paper;
								break;
							case "s":
								Human.CurrentWeapon = Weapon.Scissors;
								break;
							default:
								Console.WriteLine("TRY AGAIN");
								ChooseWeapon("HUMAN");
								break;
						}
						Console.WriteLine($"{Human.PlayerName} PICKED {Human.CurrentWeapon.ToString()}");
						break;
					}

				default:
					throw new Exception("PlayerType must be Human or AI");
			}
		}
	}
}
