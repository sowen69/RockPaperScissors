using RockPaperScissors.Interfaces;
using RockPaperScissors.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
	class GameRPS : IGame
	{
		private IPlayer Human;
		private IPlayer AI;
		private int round = 0;
		private int rounds = 0;

		// Lookup Matrix of results
		//	  R   P   S
		// R  0  -1   1
		//
		// P  1   0  -1
		//
		// S -1   1   0

		// ROW then COLUMN
		// 0  = DRAW, play again
		// 1  = WIN
		// -1 = LOOSE


		private int[,] Results = new int[3, 3]{
			{0,-1,1 },
			{1,0,-1 },
			{-1,1,0}
		};

		public GameRPS(int rounds)
		{
			CreatePlayer("Real");
			CreatePlayer("AI");

			// Only start a game with an odd number of rounds
			if (rounds % 2 == 0)
			{
				this.rounds = rounds + 1;
			}
			else
			{
				this.rounds = rounds ;
			}

			
			while (round < rounds)
			{
				Console.Clear();
				Console.WriteLine($"RESULTS: {Human.PlayerName}: {AI.PlayerName}: ");
								
				ChooseWeapon("REAL");
				ChooseWeapon("AI");
				// If a draw play again don't decreace round
				if (Human.CurrentWeapon == AI.CurrentWeapon)
				{
					Console.WriteLine("IT'S A DRAW. LET'S TRY AGAIN");
					break;
				}
				
				// Calculate result
				int result = Results[Human.CurrentWeapon, AI.CurrentWeapon];
				switch (result)
				{
					case -1:
						Console.WriteLine("YOU LOOSE");
						//update AI win count
						break;
					case 1:
						Console.WriteLine("YOU'RE A WINNER");
						//update Human win count
						break;
					default:
						break;
				}

				if(Human.WinCount > (rounds/2)+0.5 || AI.WinCount > (rounds / 2)+.5)
				{
					GameOver();
				}
				
				
				// EXPANSION: Update game results to player history
				// Player.Update();

				round++;
			}
		}

		private void GameOver()
		{
			throw new NotImplementedException();
		}

		private void CreatePlayer(string playerType)
		{
			if(playerType == "AI")
			{
				int whichAiPlayer = new Random().Next(1, 5);
				AI = new AiPlayer(whichAiPlayer);
				Console.WriteLine($"{Human.PlayerName} YOU WILL BE PLAYING {AI.PlayerName}");
			} 
			else if(playerType == "Real")
			{
				Console.WriteLine("PLEASE ENTER YOUR NAME:");
				string playerName = Console.ReadLine();
				Human = new Player(playerName);
				Console.WriteLine($"WELCOME {Human.PlayerName}!");
			}
			else
			{
				throw new Exception();
			}
			
		}
		private void ChooseWeapon(string playerType) 
		{
			if (playerType == "AI")
			{
				
			}
			else if (playerType == "Real")
			{
				Console.WriteLine($"Round {round}: Choose your weapon {Human}! Rock(R), Paper(P), Scissors(S) or Give Up(Q)");
				string results = Console.ReadLine();
				switch (results)
				{
					case "Q":
					case "q":
						// return to main menu
						break;
					case "R":
					case "r":
						Human.CurrentWeapon = 1;
						break;
					case "P":
					case "p":
						Human.CurrentWeapon = 2;
						break;
					case "S":
					case "s":
						Human.CurrentWeapon = 3;
						break;
					default:
						Console.WriteLine("Try AGAIN");
						break;
				}
			}
			else
			{
				throw new Exception();
			}
		}
	}
}
