namespace EvaluateRPN
{
	using System.Collections.Generic;

	/// <summary>
	/// Evaluate the value of an arithmetic expression in Reverse Polish Notation. 
	/// Valid operators are +, -, *, /. Each operand may be an integer or another expression.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			string[] tokens = { "2", "1", "+", "3", "*" };
			var result = EvaluateReversePolishNotation(tokens);
		}

		public static int EvaluateReversePolishNotation(string[] tokens)
		{
			var stack = new Stack<int>();

			foreach (var token in tokens)
			{
				int convertedValue;
				if (int.TryParse(token, out convertedValue))
					stack.Push(convertedValue);
				else
				{
					var op2 = stack.Pop();
					var op1 = stack.Pop();

					switch (token)
					{
						case "+":
							stack.Push(op1 + op2);
							break;
						case "-":
							stack.Push(op1 - op2);
							break;
						case "*":
							stack.Push(op1 * op2);
							break;
						case "/":
							stack.Push(op1 / op2);
							break;
					}
				}
			}

			return stack.Pop();
		}
	}
}
