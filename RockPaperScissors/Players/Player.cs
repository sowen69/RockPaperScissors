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
		private Weapon currentWeapon;
		public Player(string playerName)
		{
			PlayerName = playerName;
		}

		public Weapon CurrentWeapon
		{
			get { return currentWeapon; }
			set { currentWeapon = value; }
		}
		public string PlayerName { get; set; }
		public string PlayerHistory { get; set; }

		public int WinCount { get; set; }
	}
}
