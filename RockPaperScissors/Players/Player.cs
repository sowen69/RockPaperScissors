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
		private int currentWeapon;
		public Player(string playerName)
		{
			PlayerName = playerName;
		}

		public void init()
		{
			Console.WriteLine($"THANK YOU {PlayerName}, LETS PLAY!");
		}
		public int CurrentWeapon
		{
			get { return currentWeapon; }
			set { currentWeapon = value; }
		}
		public string PlayerName { get; set; }
		public string PlayerHistory { get; set; }

		public int WinCount => throw new NotImplementedException();
	}
}
