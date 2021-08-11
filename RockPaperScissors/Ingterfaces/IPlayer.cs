using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Interfaces
{
	interface IPlayer
	{
		int CurrentWeapon { get; set; }
		string PlayerName {  get; set; }
		int WinCount { get; }

		public void init();
		// Player Name
		// Game History
		// 
	}
}
