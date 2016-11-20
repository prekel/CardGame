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
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Main.Init();

			start.Click += StartClick;


			//button1_6.Click -= Azaza;
			//button1_6.Click += new RoutedEventHandler(button1_6Click);
			//button1_6.Click += button1_6Click;
			button1_6.Click += button1_6Click;
			button1_7.Click += button1_7Click;
			button1_8.Click += button1_8Click;
			button1_9.Click += button1_9Click;
			button1_10.Click += button1_10Click;
			button1_J.Click += button1_JClick;
			button1_Q.Click += button1_QClick;
			button1_K.Click += button1_KClick;
			button1_A.Click += button1_AClick;

			button2_6.Click += button2_6Click;
			button2_7.Click += button2_7Click;
			button2_8.Click += button2_8Click;
			button2_9.Click += button2_9Click;
			button2_10.Click += button2_10Click;
			button2_J.Click += button2_JClick;
			button2_Q.Click += button2_QClick;
			button2_K.Click += button2_KClick;
			button2_A.Click += button2_AClick;

			button3_6.Click += button3_6Click;
			button3_7.Click += button3_7Click;
			button3_8.Click += button3_8Click;
			button3_9.Click += button3_9Click;
			button3_10.Click += button3_10Click;
			button3_J.Click += button3_JClick;
			button3_Q.Click += button3_QClick;
			button3_K.Click += button3_KClick;
			button3_A.Click += button3_AClick;

			button4_6.Click += button4_6Click;
			button4_7.Click += button4_7Click;
			button4_8.Click += button4_8Click;
			button4_9.Click += button4_9Click;
			button4_10.Click += button4_10Click;
			button4_J.Click += button4_JClick;
			button4_Q.Click += button4_QClick;
			button4_K.Click += button4_KClick;
			button4_A.Click += button4_AClick;
		}

		//public void button1_6Click(object sender, RoutedEventArgs e)
		//{
		//	
		//}

		public void StartClick(object sender, RoutedEventArgs e)
		{
			//Main.Init();
			var timebegin = DateTime.Now;
			var a = Card.CardArray(10);
			cardBox.Content = "";
			foreach (var i in a)
			{
				cardBox.Content += i.ToString() + '\n';
			}
		}

		public void button1_6Click(object sender, RoutedEventArgs e) => Main.CardClick1(1, 6);
		public void button1_7Click(object sender, RoutedEventArgs e) => Main.CardClick1(1, 7);
		public void button1_8Click(object sender, RoutedEventArgs e) => Main.CardClick1(1, 8);
		public void button1_9Click(object sender, RoutedEventArgs e) => Main.CardClick1(1, 9);
		public void button1_10Click(object sender, RoutedEventArgs e) => Main.CardClick1(1, 10);
		public void button1_JClick(object sender, RoutedEventArgs e) => Main.CardClick1(1, 11);
		public void button1_QClick(object sender, RoutedEventArgs e) => Main.CardClick1(1, 12);
		public void button1_KClick(object sender, RoutedEventArgs e) => Main.CardClick1(1, 13);
		public void button1_AClick(object sender, RoutedEventArgs e) => Main.CardClick1(1, 14);

		public void button2_6Click(object sender, RoutedEventArgs e) => Main.CardClick1(2, 6);
		public void button2_7Click(object sender, RoutedEventArgs e) => Main.CardClick1(2, 7);
		public void button2_8Click(object sender, RoutedEventArgs e) => Main.CardClick1(2, 8);
		public void button2_9Click(object sender, RoutedEventArgs e) => Main.CardClick1(2, 9);
		public void button2_10Click(object sender, RoutedEventArgs e) => Main.CardClick1(2, 10);
		public void button2_JClick(object sender, RoutedEventArgs e) => Main.CardClick1(2, 11);
		public void button2_QClick(object sender, RoutedEventArgs e) => Main.CardClick1(2, 12);
		public void button2_KClick(object sender, RoutedEventArgs e) => Main.CardClick1(2, 13);
		public void button2_AClick(object sender, RoutedEventArgs e) => Main.CardClick1(2, 14);

		public void button3_6Click(object sender, RoutedEventArgs e) => Main.CardClick1(3, 6);
		public void button3_7Click(object sender, RoutedEventArgs e) => Main.CardClick1(3, 7);
		public void button3_8Click(object sender, RoutedEventArgs e) => Main.CardClick1(3, 8);
		public void button3_9Click(object sender, RoutedEventArgs e) => Main.CardClick1(3, 9);
		public void button3_10Click(object sender, RoutedEventArgs e) => Main.CardClick1(3, 10);
		public void button3_JClick(object sender, RoutedEventArgs e) => Main.CardClick1(3, 11);
		public void button3_QClick(object sender, RoutedEventArgs e) => Main.CardClick1(3, 12);
		public void button3_KClick(object sender, RoutedEventArgs e) => Main.CardClick1(3, 13);
		public void button3_AClick(object sender, RoutedEventArgs e) => Main.CardClick1(3, 14);

		public void button4_6Click(object sender, RoutedEventArgs e) => Main.CardClick1(4, 6);
		public void button4_7Click(object sender, RoutedEventArgs e) => Main.CardClick1(4, 7);
		public void button4_8Click(object sender, RoutedEventArgs e) => Main.CardClick1(4, 8);
		public void button4_9Click(object sender, RoutedEventArgs e) => Main.CardClick1(4, 9);
		public void button4_10Click(object sender, RoutedEventArgs e) => Main.CardClick1(4, 10);
		public void button4_JClick(object sender, RoutedEventArgs e) => Main.CardClick1(4, 11);
		public void button4_QClick(object sender, RoutedEventArgs e) => Main.CardClick1(4, 12);
		public void button4_KClick(object sender, RoutedEventArgs e) => Main.CardClick1(4, 13);
		public void button4_AClick(object sender, RoutedEventArgs e) => Main.CardClick1(4, 14);
	}
}
