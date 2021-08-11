using RockPaperScissors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Players
{
	class AiPlayer:IPlayer
	{
		private readonly string[] playernames = new string[5] { "Derek", "Susan", "Sam", "Indra", "Tom" };
		private string playerName;
		private int currentWeapon;

		public AiPlayer(int aiPlayer)
		{
			PlayerName = playernames[aiPlayer];
		}

		public string PlayerName 
		{ 
			get { return playerName; } 
			set { playerName = value; } 
		}

		public int CurrentWeapon 
		{
			get { return currentWeapon; } 
			set { currentWeapon = value; }
		}

		public int WinCount => throw new NotImplementedException();

		public void init()
		{
			throw new NotImplementedException();
		}
	}
}
