using RockPaperScissors.Interfaces;


namespace RockPaperScissors.Players
{
	public class AiPlayer:IPlayer
	{
		private readonly string[] playernames = new string[5] { "Derek", "Susan", "Sam", "Indra", "Tom" };
		private string playerName;
		private Weapon currentWeapon;

		public AiPlayer(int aiPlayer)
		{
			PlayerName = playernames[aiPlayer];
		}

		public string PlayerName 
		{ 
			get { return playerName; } 
			set { playerName = value; } 
		}

		public Weapon CurrentWeapon 
		{
			get { return currentWeapon; } 
			set { currentWeapon = value; }
		}

		public int WinCount { get; set; }

	}
}
