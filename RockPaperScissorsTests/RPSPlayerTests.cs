using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsTests
{
	[TestClass]
	public class RPSPlayerTests
	{
		[TestMethod]
		void CanCreateHumanPlayer()
		{
			var player = new Player(true);
		}
	}
}
