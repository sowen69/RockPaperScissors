using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Interfaces
{
	public interface IGame
	{
		public ICollection<IPlayer> Players { get; };
		public string GameName { get; }
		public int GameStatus { get; set; }
		public int GameRounds { get; set; }
		public void CreateAi();
		public void CreatePlayer();
	}
}
