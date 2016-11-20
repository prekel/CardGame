using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CardGame
{
	public class Main
	{
	    public static void Init()
		{
			Random rand = new Random();
			Card[] a = new Card[10];
			//Card a = new Card(1, 6);
			for (int i = 0; i < 10; i++)
			{
				a[i] = new Card(rand.Next(1, 5), rand.Next(6, 15));
			}
		}
		//public static void CardClick(object sender, RoutedEventArgs e)
		//{
		//}
		public static void CardClick1(int n, int v)
		{

		}

	}
}
