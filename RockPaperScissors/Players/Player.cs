using RockPaperScissors.Games.RPS;
using RockPaperScissors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
	public class Player:IPlayer
	{
		private string playerName;
		private int winCount;
		private Weapon currentWeapon;
		private bool isHuman;
		public Player(bool isHuman)
		{
			this.isHuman = isHuman;
			this.playerName = isHuman ? RpsCore.RequestName() : "AI Sam";
		}

		public Weapon CurrentWeapon
		{
			get { return currentWeapon; }
			set { currentWeapon = value; }
		}
		public string PlayerName 
		{
			get { return playerName; }
			set { playerName = value; }
		}

		public int WinCount
		{
			get { return winCount; }
			set { winCount = value; }
		}
		public bool IsHuman 
		{ 
			get { return isHuman; } 
			set { isHuman = value; } 
		}
	}
}
