using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
	public class Card
	{
		int suit;
		int number;
		public int Suit { get { return suit; } set { suit = value; } }
		public int Value { get { return number; } set { number = value; } }

		/// <summary>
		/// Конструирует карту с мастью от 1 до 4 и значением от 6 до 14
		/// </summary>
		public Card(int s, int v)
		{
			Suit = s;
			Value = v;
		}

		public override string ToString()
		{
			var s = "";
			if (Suit == 1)
				s += "♠";
			if (Suit == 2)
				s += "♣";
			if (Suit == 3)
				s += "♥";
			if (Suit == 4)
				s += "♦";
			if (Value == 11)
				s += "J";
			else if (Value == 12)
				s += "Q";
			else if (Value == 13)
				s += "K";
			else if (Value == 14)
				s += "A";
			else
				s += Value.ToString();
			return s;
		}
	}
}
