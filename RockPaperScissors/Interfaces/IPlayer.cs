﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Interfaces
{
	public interface IPlayer
	{
		Weapon CurrentWeapon { get; set; }
		string PlayerName {  get; set; }
		int WinCount { get; set; }

		// Game History
	}
}
