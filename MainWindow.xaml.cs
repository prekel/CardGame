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
using System.Timers;

namespace CardGame
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		int Count, starttime = 10, amount = 10, scoreCount = 0, leftCount = 10, correctCount = 0, wrongCount = 0, wrongCardsCount = 0;
		private static Timer timer;
		Card[] Cards, correctCards, wrongCards;

		public MainWindow()
		{
			InitializeComponent();
			//Main.Init();

			start.Click += StartClick;

			timer = new Timer(1000);
			Cards = Card.CardArray(amount);
			correctCards = Card.CardNullArray(amount);
			wrongCards = Card.CardNullArray(amount);
			//for (var i = 0; i < amount; i++)
			//{
			//	correctCards[i] = new Card();
			//}

			leftBlock.Text = amount.ToString();

			//timer.Elapsed += TimerTenSec;
			////timer.Interval = 5000;
			//timer.AutoReset = true;
			//timer.Enabled = true;

			//button1_6.Click -= Azaza;
			//button1_6.Click += new RoutedEventHandler(button1_6Click);
			//button1_6.Click += button1_6Click;
			//button1_6.Click += button1_6Click;
			//button1_7.Click += button1_7Click;
			//button1_8.Click += button1_8Click;
			//button1_9.Click += button1_9Click;
			//button1_10.Click += button1_10Click;
			//button1_J.Click += button1_JClick;
			//button1_Q.Click += button1_QClick;
			//button1_K.Click += button1_KClick;
			//button1_A.Click += button1_AClick;
			//button2_6.Click += button2_6Click;
			//button2_7.Click += button2_7Click;
			//button2_8.Click += button2_8Click;
			//button2_9.Click += button2_9Click;
			//button2_10.Click += button2_10Click;
			//button2_J.Click += button2_JClick;
			//button2_Q.Click += button2_QClick;
			//button2_K.Click += button2_KClick;
			//button2_A.Click += button2_AClick;
			//button3_6.Click += button3_6Click;
			//button3_7.Click += button3_7Click;
			//button3_8.Click += button3_8Click;
			//button3_9.Click += button3_9Click;
			//button3_10.Click += button3_10Click;
			//button3_J.Click += button3_JClick;
			//button3_Q.Click += button3_QClick;
			//button3_K.Click += button3_KClick;
			//button3_A.Click += button3_AClick;
			//button4_6.Click += button4_6Click;
			//button4_7.Click += button4_7Click;
			//button4_8.Click += button4_8Click;
			//button4_9.Click += button4_9Click;
			//button4_10.Click += button4_10Click;
			//button4_J.Click += button4_JClick;
			//button4_Q.Click += button4_QClick;
			//button4_K.Click += button4_KClick;
			//button4_A.Click += button4_AClick;
			//button1_6.Click += button1_6Click;
			//button1_6.Click += button1_6Click;
			//button1_7.Click += button1_7Click;
			//button1_8.Click += button1_8Click;
			//button1_9.Click += button1_9Click;
			//button1_10.Click += button1_10Click;
			//button1_J.Click += button1_JClick;
			//button1_Q.Click += button1_QClick;
			//button1_K.Click += button1_KClick;
			//button1_A.Click += button1_AClick;
			//button2_6.Click += button2_6Click;
			//button2_7.Click += button2_7Click;
			//button2_8.Click += button2_8Click;
			//button2_9.Click += button2_9Click;
			//button2_10.Click += button2_10Click;
			//button2_J.Click += button2_JClick;
			//button2_Q.Click += button2_QClick;
			//button2_K.Click += button2_KClick;
			//button2_A.Click += button2_AClick;
			//button3_6.Click += button3_6Click;
			//button3_7.Click += button3_7Click;
			//button3_8.Click += button3_8Click;
			//button3_9.Click += button3_9Click;
			//button3_10.Click += button3_10Click;
			//button3_J.Click += button3_JClick;
			//button3_Q.Click += button3_QClick;
			//button3_K.Click += button3_KClick;
			//button3_A.Click += button3_AClick;
			//button4_6.Click += button4_6Click;
			//button4_7.Click += button4_7Click;
			//button4_8.Click += button4_8Click;
			//button4_9.Click += button4_9Click;
			//button4_10.Click += button4_10Click;
			//button4_J.Click += button4_JClick;
			//button4_Q.Click += button4_QClick;
			//button4_K.Click += button4_KClick;
			//button4_A.Click += button4_AClick;


			button1_6.Click += CardbuttonClick;
			button1_6.Click += CardbuttonClick;
			button1_7.Click += CardbuttonClick;
			button1_8.Click += CardbuttonClick;
			button1_9.Click += CardbuttonClick;
			button1_10.Click += CardbuttonClick;
			button1_J.Click += CardbuttonClick;
			button1_Q.Click += CardbuttonClick;
			button1_K.Click += CardbuttonClick;
			button1_A.Click += CardbuttonClick;
			button2_6.Click += CardbuttonClick;
			button2_7.Click += CardbuttonClick;
			button2_8.Click += CardbuttonClick;
			button2_9.Click += CardbuttonClick;
			button2_10.Click += CardbuttonClick;
			button2_J.Click += CardbuttonClick;
			button2_Q.Click += CardbuttonClick;
			button2_K.Click += CardbuttonClick;
			button2_A.Click += CardbuttonClick;
			button3_6.Click += CardbuttonClick;
			button3_7.Click += CardbuttonClick;
			button3_8.Click += CardbuttonClick;
			button3_9.Click += CardbuttonClick;
			button3_10.Click += CardbuttonClick;
			button3_J.Click += CardbuttonClick;
			button3_Q.Click += CardbuttonClick;
			button3_K.Click += CardbuttonClick;
			button3_A.Click += CardbuttonClick;
			button4_6.Click += CardbuttonClick;
			button4_7.Click += CardbuttonClick;
			button4_8.Click += CardbuttonClick;
			button4_9.Click += CardbuttonClick;
			button4_10.Click += CardbuttonClick;
			button4_J.Click += CardbuttonClick;
			button4_Q.Click += CardbuttonClick;
			button4_K.Click += CardbuttonClick;
			button4_A.Click += CardbuttonClick;
		}

		//public void button1_6Click(object sender, RoutedEventArgs e)
		//{
		//	
		//}

		public void StartClick(object sender, RoutedEventArgs e)
		{
			//Main.Init();
			//var timebegin = DateTime.Now;

			start.IsEnabled = false;

			//timer = new Timer(1000);
			timer.Stop();
			timer.Elapsed += TimerOneSec;
			timer.Interval = 1000;
			timer.AutoReset = true;
			timer.Enabled = true;
			timer.Start();
			timeBlock.Text = starttime.ToString();


			cardBox.Text = "";
			foreach (var i in Cards)
			{
				cardBox.Text += i.ToString() + ' ';
			}
		}

		public void TimerOneSec(object sender, ElapsedEventArgs e)
		{
			Action action = () =>
			{
				Count++;
				timeBlock.Text = (starttime - Count).ToString();
				if (Count == starttime)
				{
					//cardBox.Text = "";
					Count = 0;
					var timer = (Timer)sender;
					timer.Stop();

				}
			};
			Dispatcher.Invoke(action);
		}

		public void CardbuttonClick(object sender, RoutedEventArgs e)
		{
			var b = (Button)sender;
			var c = new Card(b.Content.ToString());
			for (var i = 0; i < amount; i++)
			{
				if (c.ToString() == Cards[i].ToString())
				{
					correctCount++;
					leftCount = amount - correctCount;
					correctBlock.Text = correctCount.ToString();
					leftBlock.Text = leftCount.ToString();
					correctCards[correctCount - 1] = Cards[i]; 
					Cards[i] = Card.Null();
					return;
				}
			}
			wrongCount++;
			//wrongCardsCount++;
			//wrongCards[wrongCardsCount - 1] = Cards[amount - wrongCount];
			for (var i = amount - 1; i >= 0; i--)
			{
				if (Cards[i].ToString() != "0")
				{
					wrongCards[wrongCardsCount++] = Cards[i];
					Cards[i] = Card.Null();
					wrongBlock.Text = wrongCount.ToString();
					if (i > 0)
						return;
				}
			}
			for (var i = 0; i < amount; i++)
			{
				Cards[i] = wrongCards[i];
			}
			wrongCards = Card.CardNullArray(amount);
			wrongCardsCount = 0;
			scoreCount++;
			scoreBlock.Text = scoreCount.ToString();

			cardBox.Text = "";
			foreach (var i in Cards)
			{
				cardBox.Text += i.ToString() + ' ';
			}
		}

		//public void CardClick(int n, int v)
		//{
		//	var c = new Card(n, v);
		//	foreach (var i in a)
		//	{
		//		if (c.ToString() == i.ToString())
		//		{
		//			correctCount++;
		//			correctBlock.Text = correctCount.ToString();
		//			return;
		//		}
		//	}
		//	wrongCount++;
		//	wrongBlock.Text = wrongCount.ToString();
		//}

		//public void button1_6Click(object sender, RoutedEventArgs e) => CardClick(1, 6);
		//public void button1_7Click(object sender, RoutedEventArgs e) => CardClick(1, 7);
		//public void button1_8Click(object sender, RoutedEventArgs e) => CardClick(1, 8);
		//public void button1_9Click(object sender, RoutedEventArgs e) => CardClick(1, 9);
		//public void button1_10Click(object sender, RoutedEventArgs e) => CardClick(1, 10);
		//public void button1_JClick(object sender, RoutedEventArgs e) => CardClick(1, 11);
		//public void button1_QClick(object sender, RoutedEventArgs e) => CardClick(1, 12);
		//public void button1_KClick(object sender, RoutedEventArgs e) => CardClick(1, 13);
		//public void button1_AClick(object sender, RoutedEventArgs e) => CardClick(1, 14);

		//public void button2_6Click(object sender, RoutedEventArgs e) => CardClick(2, 6);
		//public void button2_7Click(object sender, RoutedEventArgs e) => CardClick(2, 7);
		//public void button2_8Click(object sender, RoutedEventArgs e) => CardClick(2, 8);
		//public void button2_9Click(object sender, RoutedEventArgs e) => CardClick(2, 9);
		//public void button2_10Click(object sender, RoutedEventArgs e) => CardClick(2, 10);
		//public void button2_JClick(object sender, RoutedEventArgs e) => CardClick(2, 11);
		//public void button2_QClick(object sender, RoutedEventArgs e) => CardClick(2, 12);
		//public void button2_KClick(object sender, RoutedEventArgs e) => CardClick(2, 13);
		//public void button2_AClick(object sender, RoutedEventArgs e) => CardClick(2, 14);

		//public void button3_6Click(object sender, RoutedEventArgs e) => CardClick(3, 6);
		//public void button3_7Click(object sender, RoutedEventArgs e) => CardClick(3, 7);
		//public void button3_8Click(object sender, RoutedEventArgs e) => CardClick(3, 8);
		//public void button3_9Click(object sender, RoutedEventArgs e) => CardClick(3, 9);
		//public void button3_10Click(object sender, RoutedEventArgs e) => CardClick(3, 10);
		//public void button3_JClick(object sender, RoutedEventArgs e) => CardClick(3, 11);
		//public void button3_QClick(object sender, RoutedEventArgs e) => CardClick(3, 12);
		//public void button3_KClick(object sender, RoutedEventArgs e) => CardClick(3, 13);
		//public void button3_AClick(object sender, RoutedEventArgs e) => CardClick(3, 14);

		//public void button4_6Click(object sender, RoutedEventArgs e) => CardClick(4, 6);
		//public void button4_7Click(object sender, RoutedEventArgs e) => CardClick(4, 7);
		//public void button4_8Click(object sender, RoutedEventArgs e) => CardClick(4, 8);
		//public void button4_9Click(object sender, RoutedEventArgs e) => CardClick(4, 9);
		//public void button4_10Click(object sender, RoutedEventArgs e) => CardClick(4, 10);
		//public void button4_JClick(object sender, RoutedEventArgs e) => CardClick(4, 11);
		//public void button4_QClick(object sender, RoutedEventArgs e) => CardClick(4, 12);
		//public void button4_KClick(object sender, RoutedEventArgs e) => CardClick(4, 13);
		//public void button4_AClick(object sender, RoutedEventArgs e) => CardClick(4, 14);
	}
}
