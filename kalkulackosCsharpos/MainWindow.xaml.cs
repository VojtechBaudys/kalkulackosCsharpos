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
			MyDisplay.Text += (string)element.Content;
			_mathProblem.AddToText((string)element.Tag);
		}
		
		private void ButtonEvaluate(object sender, RoutedEventArgs e)
		{
			string result = _mathProblem.Evaluate();
			MyDisplay.Text = result;
		}

		private void ButtonNewMathProblem(object sender, RoutedEventArgs e)
		{
			CreateNewMathProblem();
		}
	}
}