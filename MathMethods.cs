using System;

public class MathMethods
{
	public MathMethods()
	{

	}

	public static int Add (params int[] numbers) {
		int sum = 0;
		
		foreach (int n in numbers)
		{
			sum += n;
		}

		Console.WriteLine("Sum: ", sum);
	}

	Add(1, 2, 3);
}