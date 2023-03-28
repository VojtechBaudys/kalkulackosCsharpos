using System;
using System.Data;

namespace kalkulackosCsharpos.Entity;
public class MathProblem
{
	private string _problem;
	private string _problemText;
	private string _prevProblem;
	private string _prevProblemText;

	public MathProblem()
	{
		_problem = "";
		_problemText = "";
		_prevProblem = "";
		_prevProblemText = "";
	}
	
	// getters

	public string GetProblemText()
	{
		return _problemText;
	}
	
	public string GetPrevProblemText()
	{
		return _prevProblemText;
	}
	
	public void AddToProblem(string character, string characterText)
	{
		if (CheckLastChar(character))
		{
			_problem += character;
			_problemText += characterText;
		}
	}
	
	public void Evaluate()
	{
		DataTable dt = new DataTable();
		string result;
		
		try
		{
			result = dt.Compute(_problem, "").ToString()!;
			_prevProblem = _problem;
			_prevProblemText = _problemText + "=";
			_problem = result;
		}
		catch
		{
			result = "ERROR";
			_problem = "";
		}
		
		_problemText = result;
	}

	public void RemoveLastChar()
	{
		if (_problem.Length > 0)
		{
			_problem = _problem.Remove(_problem.Length - 1, 1);
			_problemText = _problemText.Remove(_problemText.Length - 1, 1);	
		}
	}

	private bool CheckLastChar(string character)
	{
		char[] charArray = _problem.ToCharArray();
		string characters = "+-*/.";

		if (charArray.Length > 0 && characters.Contains(character))
		{
			if (characters.Contains(charArray[^1]))
			{
				return false;
			}
		}
		return true;
	}
}