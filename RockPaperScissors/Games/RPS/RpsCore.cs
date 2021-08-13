using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Games.RPS
{
	public static class RpsCore
	{
		private static int[,] winMatrix = new int[3, 3]
		{
			{ 0,-1, 1 },
			{ 1, 0,-1 },
			{-1, 1, 0 }
		};



		public static Weapon RandomWeapon()
		{
			Weapon randWeapon = (Weapon)new Random().Next(1, 3);
			return randWeapon;
		}

		public static int CheckResult(Weapon playerOneWeapon, Weapon playerTwoWeapon)
		{
			return winMatrix[((int)playerOneWeapon), 
				((int)playerTwoWeapon)];
		}

		public static string RequestName()
		{
			return "";
		}
	}
}
