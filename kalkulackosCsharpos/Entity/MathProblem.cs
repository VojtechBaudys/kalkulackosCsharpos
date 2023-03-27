using System.Data;

namespace kalkulackosCsharpos.Entity;
public class MathProblem
{
	private string _text;
	
	public MathProblem()
	{
		_text = "";
	}

	public void AddToText(string character)
	{
		_text += character;
	}

	public int Evaluate()
	{
		DataTable dt = new DataTable();

		int result = (int)dt.Compute(_text, "");
		_text = result.ToString();
		
		return result;
	}
}