using System;
using System.Collections.Generic;
using System.Text;

namespace Zad_1_POPRAWA
{
    public class Gambler
    {
		private string name;
		private string surname;
		private int phone_number;
		private bool banned;

		public Gambler()
		{

		}

		public Gambler(string name, string surname, int phone_number, bool banned)
		{
			this.name = name;
			this.surname = surname;
			this.phone_number = phone_number;
			this.banned = banned;
		}
	}
}
