// Written By: Matthew Hillyer
// Date: 3/29/2015
// Hangman Final Project for CIS115
// Version Week 4, 1.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS115FinalProject
{
	class Program
	{
		static void Main(string[] args)
		{
			char guessOne;
			char guessTwo;
			char guessThree;
			char guessFour;
			char guessFive;
			string word = "HILLYER";

			Console.WriteLine("Hangman!");
			Console.WriteLine();
			Console.WriteLine();
			Console.Write("What is your guess? ");
			guessOne = Convert.ToChar(Console.ReadLine());
			Console.WriteLine();
			Console.Write("What is your guess? ");
			guessTwo = Convert.ToChar(Console.ReadLine());
			Console.WriteLine();
			Console.Write("What is your guess? ");
			guessThree = Convert.ToChar(Console.ReadLine());
			Console.WriteLine();
			Console.Write("What is your guess? ");
			guessFour = Convert.ToChar(Console.ReadLine());
			Console.WriteLine();
			Console.Write("What is your guess? ");
			guessFive = Convert.ToChar(Console.ReadLine());
			Console.WriteLine();

			//keep window open
			Console.ReadLine();
		}
	}
}
