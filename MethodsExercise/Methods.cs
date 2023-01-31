using System;
using MethodsExercise;
namespace MethodsExercise;

internal class Methods
{
	
	
		public static void Story()
		{
			Console.WriteLine("Enter your ex's name.");
			string exName = Console.ReadLine();
			Console.WriteLine("Enter your least favorite color.");
			string leastFavColor = Console.ReadLine();
			Console.WriteLine("Enter somthing that smells bad.");
			string badSmell = Console.ReadLine();
			Console.WriteLine("Enter a number.");
			string num = Console.ReadLine();
			Console.WriteLine("Enter something that can explode.");
			string bomb = Console.ReadLine();

			Console.WriteLine($"There once was a monster named {exName}. It was a horrible {leastFavColor} creature \n" +
				$"that smelled like {badSmell}. Which is why everybody was excited when it exploded into {num} peices after \n" +
				$"it stepped onto a {bomb}");

		}

	
}

