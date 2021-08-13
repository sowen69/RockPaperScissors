using RockPaperScissors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Games.RPS
{
	public class Game : IGame
	{
		private ICollection<IPlayer> players;
		public Game(int gameRounds)
		{
			GameRounds = gameRounds;
			Player Ai = new Player(false);
			Player Human = new Player(true);
			players.Add(Ai);
			players.Add(Human);
		}

		public ICollection<IPlayer> Players { get { return players; } }

		public string GameName => throw new NotImplementedException();

		public int GameStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int GameRounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void ChooseWeapon(string playerType)
		{
			throw new NotImplementedException();
		}

		public void CreateAi()
		{
			throw new NotImplementedException();
		}

		public void CreatePlayer(string playerType)
		{
			throw new NotImplementedException();
		}

		public void CreatePlayer()
		{
			throw new NotImplementedException();
		}

		
	}
}
