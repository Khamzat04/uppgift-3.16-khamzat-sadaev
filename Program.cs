using System;

//Uppgift 3.16

public class Program
{
	public static void Main()
	{

		Console.WriteLine("Hur lång är din låt. ? ");
		int time = int.Parse(Console.ReadLine());
		int minimum = int.Parse(Console.ReadLine());
		int total = (time * 60) + minimum;
		int t = 260;
		int m = 165;

		// programmet frågar om hur lång är låten, om låten är mer än 260 secunder eller mindre än 165 säger den vi vill inte ha den, men annars och den är mellan 260 och 165 sekunder så säger den 
		if (total <= t && total >= m)                                                                                                                                       // din låt får vara med Radion.
		{
			Console.WriteLine(" din låt får vara med Radion! ");
		}


		else { Console.WriteLine("tyvär så kan vi inte lägga din låt i Radion!"); }







	}
}