using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RockPaperScissors;
using RockPaperScissors.Games.RPS;
using RockPaperScissors.Interfaces;
using RockPaperScissors.Players;
using System;

namespace RockPaperScissorsTests
{
	[TestClass]
	public class RPSCoreTests
	{
		//IPlayer player;
		//IPlayer aiPlayer;
		//Weapon playerWeapon;
		//Weapon mockAiPlayerWeapon;
		//Mock<IGame> game;
		//Mock<IPlayer> mockAiPlayer;


		//[TestInitialize]
		//public void TestInitialize()
		//{
		//	SetupPlayer();
		//	SetupAiPlayer();
		//	SetupMockAiPlayer();
		//	SetupMockGame();	
		//}

		//private void SetupPlayer()
		//{
		//	player = new Player("David");
		//	playerWeapon = Weapon.Paper;
		//}

		//private void SetupAiPlayer()
		//{
		//	aiPlayer = new AiPlayer(2);
		//}

		//private void SetupMockAiPlayer()
		//{
		//	mockAiPlayer = new Mock<IPlayer>();
		//	mockAiPlayerWeapon = Weapon.Scissors;
		//	mockAiPlayer.SetupGet(a=>a.CurrentWeapon).Returns(mockAiPlayerWeapon);
		//	mockAiPlayer.SetupGet(a => a.PlayerName).Returns("Susan");
		//}

		//private void SetupMockGame()
		//{
		//	game = new Mock<IGame>();
		//	game.SetupGet(g => g.GameName).Returns("Rock, Paper, Scissors");
		//	game.SetupGet(g => g.GameRounds).Returns(3);
		//	game.SetupGet(g => g.GameStatus).Returns(1);
		//}

		//[TestMethod]
		//public void CanCreatePlayer()
		//{
		//	Assert.IsTrue(player.PlayerName == "David");
		//}
		//[TestMethod]
		//public void CanCreateAiPlayer()
		//{
			
		//	Assert.IsTrue(aiPlayer.PlayerName == "Sam");
		//}
		//[TestMethod]
		//public void PlayerCanHaveWeapon()
		//{
		//	player.CurrentWeapon= playerWeapon;

		//	Assert.IsTrue(player.CurrentWeapon == Weapon.Paper);

		//}



		[TestMethod]
		public void CanPickRandomWeapon()
		{
			Weapon testWeapon =	RpsCore.RandomWeapon();
			Assert.IsTrue(
				testWeapon==Weapon.Paper||
				testWeapon==Weapon.Rock||
				testWeapon==Weapon.Scissors);
		}
		[TestMethod]
		public void ResultsRockRockReturnsDraw()
		{
			Weapon playerOneWeapon = Weapon.Rock;
			Weapon playerTwoWeapon = Weapon.Rock;

			int Result = RpsCore.CheckResult(playerOneWeapon, playerTwoWeapon);
			Assert.AreEqual(0, Result);
		}
		[TestMethod]
		public void ResultsPaperPaperReturnsDraw()
		{
			Weapon playerOneWeapon=Weapon.Paper;
			Weapon playerTwoWeapon=Weapon.Paper;

			int Result = RpsCore.CheckResult(playerOneWeapon, playerTwoWeapon);
			Assert.AreEqual(0, Result);
		}
		[TestMethod]
		public void ResultsScissorsScissorsReturnsDraw()
		{
			Weapon playerOneWeapon = Weapon.Scissors;
			Weapon playerTwoWeapon = Weapon.Scissors;

			int Result = RpsCore.CheckResult(playerOneWeapon, playerTwoWeapon);
			Assert.AreEqual(0, Result);
		}
		[TestMethod]
		public void ResultsPlayerOneRockBeatsPlayerTwoScissors()
		{
			Weapon playerOneWeapon = Weapon.Rock;
			Weapon playerTwoWeapon = Weapon.Scissors;

			int Result = RpsCore.CheckResult(playerOneWeapon, playerTwoWeapon);
			Assert.AreEqual(1, Result);
		}

		[TestMethod]
		public void ResultsPlayerOnePaperBeatsPlayerTwoRock()
		{
			Weapon playerOneWeapon = Weapon.Paper;
			Weapon playerTwoWeapon = Weapon.Rock;

			int Result = RpsCore.CheckResult(playerOneWeapon, playerTwoWeapon);
			Assert.AreEqual(1, Result);
		}
		[TestMethod]
		public void ResultsPlayerOneScissorsBeatsPlayerTwoPaper()
		{
			Weapon playerOneWeapon = Weapon.Scissors;
			Weapon playerTwoWeapon = Weapon.Paper;

			int Result = RpsCore.CheckResult(playerOneWeapon, playerTwoWeapon);
			Assert.AreEqual(1, Result);
		}


		[TestMethod]
		public void ResultsPlayerTwoRockBeatsPlayerOneScissors()
		{
			Weapon playerOneWeapon = Weapon.Scissors;
			Weapon playerTwoWeapon = Weapon.Rock;

			int Result = RpsCore.CheckResult(playerOneWeapon, playerTwoWeapon);
			Assert.AreEqual(-1, Result);
		}

		[TestMethod]
		public void ResultsPlayerTwoPaperBeatsPlayerOneRock()
		{
			Weapon playerOneWeapon = Weapon.Rock;
			Weapon playerTwoWeapon = Weapon.Paper;

			int Result = RpsCore.CheckResult(playerOneWeapon, playerTwoWeapon);
			Assert.AreEqual(-1, Result);
		}
		[TestMethod]
		public void ResultsPlayerTwoScissorsBeatsPlayerOnePaper()
		{
			Weapon playerOneWeapon = Weapon.Paper;
			Weapon playerTwoWeapon = Weapon.Scissors;

			int Result = RpsCore.CheckResult(playerOneWeapon, playerTwoWeapon);
			Assert.AreEqual(-1, Result);
		}
	}
}
