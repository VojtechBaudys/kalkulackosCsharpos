using System;
using System.Windows;
using System.Windows.Controls;
using kalkulackosCsharpos.Entity;

namespace kalkulackosCsharpos
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private MathProblem _mathProblem;
		public MainWindow()
		{
			InitializeComponent();
			CreateNewMathProblem();
		}

		private void CreateNewMathProblem()
		{
			_mathProblem = new MathProblem();
			MyDisplay.Text = "";
		}

		private void ButtonBase(object sender, RoutedEventArgs e)
		{
			Button element = (Button)sender;
			string content = (string)element.Content;
			MyDisplay.Text += content;
			_mathProblem.AddToText(content);
		}
		
		private void ButtonEvaluate(object sender, RoutedEventArgs e)
		{
			int result = _mathProblem.Evaluate();
			MyDisplay.Text = result.ToString();
		}
	}
}