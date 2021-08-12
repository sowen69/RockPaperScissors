using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Interfaces
{
	public interface IGame
	{
		public string GameName { get; }
		public int GameStatus { get; set; }
		public int GameRounds { get; set; }
		//int AIPlayers { get; set; }
		public void CreatePlayer(string playerType);
		public void ChooseWeapon(string playerType);

	}
}
