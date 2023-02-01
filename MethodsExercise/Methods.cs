﻿using System;
using MethodsExercise;
using Microsoft.VisualBasic;

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
    public static void Add(params int[] ListNumbers)
    {
		int total = 0;
        foreach (int i in ListNumbers)
        {
            total += i;
        }
        Console.WriteLine(total);

    }

    public static void Subtract(params int[] ListNumbers)
    {
		int total = 0;
        foreach (int i in ListNumbers)
        {
            total -= i;
        }
        Console.WriteLine(total);

    }

    public static void Divide(params int[] ListNumbers)
    {

        int total = ListNumbers[0];

        for (int num = 1; num < ListNumbers.Count(); num++)
        {
            total = total / ListNumbers[num];
        }

        Console.WriteLine(total);

    }

    public static void Multiply(params int[] ListNumbers)
    {

        int total = ListNumbers[0];

        for (int num = 1; num < ListNumbers.Count(); num++)
        {

            total = total * ListNumbers[num];
        }

        Console.WriteLine(total);
    }

}

