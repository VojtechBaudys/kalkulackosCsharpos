using System.Data;

namespace kalkulackosCsharpos.Entity;
public class MathProblem
{
	private string _problem;
	
	public MathProblem()
	{
		_problem = "";
	}

	public void AddToText(string character)
	{
		_problem += character;
	}

	public string Evaluate()
	{
		DataTable dt = new DataTable();

		var result = dt.Compute(_problem, "");
		_problem = result.ToString()!;
		
		return _problem;
	}
}