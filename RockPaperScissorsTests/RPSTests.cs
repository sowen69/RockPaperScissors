using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RockPaperScissors;
using RockPaperScissors.Interfaces;
using RockPaperScissors.Players;
using System;

namespace RockPaperScissorsTests
{
	[TestClass]
	public class RPSTests
	{
		IPlayer player;
		IPlayer aiPlayer;
		Weapon playerWeapon;
		Weapon mockAiPlayerWeapon;
		Mock<IGame> game;
		Mock<IPlayer> mockAiPlayer;


		[TestInitialize]
		public void TestInitialize()
		{
			SetupPlayer();
			SetupAiPlayer();
			SetupMockAiPlayer();
			SetupMockGame();	
		}

		private void SetupPlayer()
		{
			player = new Player("David");
			playerWeapon = Weapon.Paper;
		}

		private void SetupAiPlayer()
		{
			aiPlayer = new AiPlayer(2);
		}

		private void SetupMockAiPlayer()
		{
			mockAiPlayer = new Mock<IPlayer>();
			mockAiPlayerWeapon = Weapon.Scissors;
			mockAiPlayer.SetupGet(a=>a.CurrentWeapon).Returns(mockAiPlayerWeapon);
			mockAiPlayer.SetupGet(a => a.PlayerName).Returns("Susan");
		}

		private void SetupMockGame()
		{
			game = new Mock<IGame>();
			game.SetupGet(g => g.GameName).Returns("Rock, Paper, Scissors");
			game.SetupGet(g => g.GameRounds).Returns(3);
			game.SetupGet(g => g.GameStatus).Returns(1);
		}

		[TestMethod]
		public void CanCreatePlayer()
		{
			Assert.IsTrue(player.PlayerName == "David");
		}
		[TestMethod]
		public void CanCreateAiPlayer()
		{
			
			Assert.IsTrue(aiPlayer.PlayerName == "Sam");
		}
		[TestMethod]
		public void PlayerCanHaveWeapon()
		{
			player.CurrentWeapon= playerWeapon;

			Assert.IsTrue(player.CurrentWeapon == Weapon.Paper);

		}

		[TestMethod]
		public void PlayerCanPickDifferentWeapon()
		{
			player.CurrentWeapon = Weapon.Rock;

			Assert.IsTrue(player.CurrentWeapon == Weapon.Rock);
		}
		[TestMethod]
		public void AICanPickRandomWeapon()
		{
			int randWeapon = 2;
			aiPlayer.CurrentWeapon = (Weapon)randWeapon;
			
			Assert.IsTrue(aiPlayer.CurrentWeapon == Weapon.Scissors);
		}
		[TestMethod]
		public void CanStartGameWithOnlyOddNumberOfRounds()
		{
		}
	}
}
