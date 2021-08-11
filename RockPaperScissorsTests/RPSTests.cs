using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace RockPaperScissorsTests
{
	[TestClass]
	public class RPSTests
	{
		[TestMethod]
		public void CanCreatePlayer()
		{
			var player = new Player("David");
			player.init();

			Assert.IsTrue(player.PlayerName == "David");
			

		}
		[TestMethod]
		public void CanStartGame()
		{
		}
	}
}
