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

		/// <summary> Конструирует карту с мастью от 1 до 4 и значением от 6 до 14 </summary>
		public Card(int s, int v)
		{
			Suit = s;
			Value = v;
		}

		public Card(string s)
		{
			if (s[0] == '♠')
				Suit = 1;
			if (s[0] == '♣')
				Suit = 2;
			if (s[0] == '♥')
				Suit = 3;
			if (s[0] == '♦')
				Suit = 4;
			if (s[1] == '6')
				Value = 6;
			if (s[1] == '7')
				Value = 7;
			if (s[1] == '8')
				Value = 8;
			if (s[1] == '9')
				Value = 9;
			if (s[1] == '1')
				Value = 10;
			if (s[1] == 'J')
				Value = 11;
			if (s[1] == 'Q')
				Value = 12;
			if (s[1] == 'K')
				Value = 13;
			if (s[1] == 'A')
				Value = 14;
		}

		public static Card[] CardArray(int n)
		{
			var rand = new Random();
			var a = new Card[n];
			//Card a = new Card(1, 6);
			for (var i = 0; i < n; i++)
			{
				a[i] = new Card(rand.Next(1, 5), rand.Next(6, 15));
			}
			return a;
			
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
