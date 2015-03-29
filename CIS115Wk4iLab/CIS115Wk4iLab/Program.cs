using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS115Week4iLab
{
	class Program
	{
		static void Main(string[] args)
		{
			//variables

			string firstName;
			string lastName;
			double pointsReceived;

			//Greeting

			Console.WriteLine("Welcome to the Student Grade Calculator ");

			//get inputs - student name

			Console.Write("What is the student's first name? ");
			firstName = Console.ReadLine();
			Console.Write("What is the student's last name? ");
			lastName = Console.ReadLine();

			//input - points rcvd
			Console.Write("How many points did the student receive (out of 1000)? ");
			pointsReceived = Convert.ToDouble(Console.ReadLine());

			//Do calc for Overtime

			if (pointsReceived < 0 || pointsReceived > 1000)
			{
				Console.Write("Invalid Range, ending program");

				//terminate app
			}
			else
			{
				Console.WriteLine("Good Score value.");

				Console.WriteLine("Student Name: " + firstName + " " + lastName);

				Console.WriteLine("Points received: " + pointsReceived);

				//calcualte percentage

				double gradePercentage;

				gradePercentage = pointsReceived / 1000;
				gradePercentage = gradePercentage * 100;

				Console.WriteLine("Grade Percentage: " + gradePercentage + "%");

				if (gradePercentage >= 90)
					Console.WriteLine("Final Grade is an A");

				else if (gradePercentage >= 80 && gradePercentage < 90)
					Console.WriteLine("Final Grade is an B");

				else if (gradePercentage >= 70 && gradePercentage < 80)
					Console.WriteLine("Final Grade is an C");

				else if (gradePercentage >= 60 && gradePercentage < 70)
					Console.WriteLine("Final Grade is an D");

				else if (gradePercentage < 60)
					Console.WriteLine("Final Grade is an F");

			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Thanks for using the Student Grade Calculator!");

			//keep window open
			Console.ReadLine();


		}
	}
}



