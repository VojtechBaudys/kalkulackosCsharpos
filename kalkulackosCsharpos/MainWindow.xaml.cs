using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using kalkulackosCsharpos.Entity;
using MahApps.Metro.Controls;

namespace kalkulackosCsharpos
{
	// NuGet packages //
	// MahApps.Metro
	// WpfAnimatedGif
	
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : MetroWindow
	{
		private MathProblem _mathProblem;
		
		public MainWindow()
		{
			InitializeComponent();
			CreateNewMathProblem();
		}
		
		// Math problem init
		private void CreateNewMathProblem()
		{
			_mathProblem = new MathProblem();
			RenderProblem();
		}
		
		// Render display
		private void RenderProblem()
		{
			MyDisplay.Text = _mathProblem.GetProblemText();
			PrevProblem.Text = "";
		}

		private void RenderPrevProblem()
		{
			PrevProblem.Text = _mathProblem.GetPrevProblemText();
		}

		// EVENTS //
		
		// Base buttons click
		private void ButtonBase(object sender, RoutedEventArgs e)
		{
			Button element = (Button)sender;
			_mathProblem.AddToProblem((string)element.Tag, (string)element.Content);
			RenderProblem();
		}
		
		// Evaluate button click
		private void ButtonEvaluate(object sender, RoutedEventArgs e)
		{
			_mathProblem.Evaluate();
			RenderProblem();
			RenderPrevProblem();
		}

		// New math problem button click
		private void ButtonNewMathProblem(object sender, RoutedEventArgs e)
		{
			CreateNewMathProblem();
		}

		// Remove last char button click
		void ButtonRemoveLast(object sender, RoutedEventArgs e)
		{
			_mathProblem.RemoveLastChar();
			RenderProblem();
		}
	}
}