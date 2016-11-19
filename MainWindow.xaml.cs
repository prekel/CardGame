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

			//button1_6.Click -= Azaza;
			//button1_6.Click += new RoutedEventHandler(button1_6Click);
			button1_6.Click += Main.CardClick;
			//button1_6.Click += button1_6Click;
			button1_7.Click += Main.CardClick;
			button1_8.Click += Main.CardClick;
			button1_9.Click += Main.CardClick;
			button1_10.Click += Main.CardClick;
			button1_J.Click += Main.CardClick;
			button1_Q.Click += Main.CardClick;
			button1_K.Click += Main.CardClick;
			button1_A.Click += Main.CardClick;

			button2_6.Click += Main.CardClick;
			button2_7.Click += Main.CardClick;
			button2_8.Click += Main.CardClick;
			button2_9.Click += Main.CardClick;
			button2_10.Click += Main.CardClick;
			button2_J.Click += Main.CardClick;
			button2_Q.Click += Main.CardClick;
			button2_K.Click += Main.CardClick;
			button2_A.Click += Main.CardClick;

			button3_6.Click += Main.CardClick;
			button3_7.Click += Main.CardClick;
			button3_8.Click += Main.CardClick;
			button3_9.Click += Main.CardClick;
			button3_10.Click += Main.CardClick;
			button3_J.Click += Main.CardClick;
			button3_Q.Click += Main.CardClick;
			button3_K.Click += Main.CardClick;
			button3_A.Click += Main.CardClick;

			button4_6.Click += Main.CardClick;
			button4_7.Click += Main.CardClick;
			button4_8.Click += Main.CardClick;
			button4_9.Click += Main.CardClick;
			button4_10.Click += Main.CardClick;
			button4_J.Click += Main.CardClick;
			button4_Q.Click += Main.CardClick;
			button4_K.Click += Main.CardClick;
			button4_A.Click += Main.CardClick;
		}

		//public void button1_6Click(object sender, RoutedEventArgs e)
		//{
		//	
		//}

		//public void button1_6Click(object sender, RoutedEventArgs e) => Main.CardClick1(1, 6);
	}
}
