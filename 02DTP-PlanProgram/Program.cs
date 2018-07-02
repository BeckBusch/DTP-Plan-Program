using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DTP_PlanProgram
{
	class Program
	{
		//blank method setup to color the console output
		static void PizzaColor(string name)
		{
		}

		//method to handle user inputs where there are two options
		static Boolean Choice(string choice1, string choice2)
		{
			//constant loop means that questions will keep being asked untill user enters valid answers
			while (true)
			{
				//use options given via arguments to prestne user with question and choices, as well as insturctions on how to enter their answer
				Console.WriteLine(choice1 + " or " + choice2 + "?");
				Console.Write("1 for " + choice1 + ", 2 for " + choice2 + "     Input:");
				string answerTemp = Console.ReadLine();
				//if statment checks user answer, and gives user conformation of answer, before returning outcome to main program
				if (answerTemp == "1")
				{
					Console.WriteLine("You have chosen " + choice1);
					return true;
				}
				else if (answerTemp == "2")
				{
					Console.WriteLine("You have chosen " + choice2);
					return false;
				}
			}
		}

		//pizzas stored in array
		static readonly string[] Pizzas =
		{
			"Meatlovers", "Ham & Cheese", "Hawaiian", "Garlic", "Pepperoni", "Cheese", "Double Cheese", "Chicken",
			"Mexican", "Sea Food", "Margarita", "Thai Curry"
		};

		//initialise varables, allowing them to be changed within local scopes 
		private static int pizzaCount;
		private static int phone;
		public static Int64 big = 9999999999;
		public static string phoneStr;
		public static int selection;
		public static double Total;

		static void Main(string[] args)
		{
			//uses method to ask user questons with only two options
			if (Choice("Pickup", "Delivery") == true)
			{
				//if customer is picking up, only ask for name
				Console.Write("Please input customer Name  :");
				String name = Console.ReadLine();
			}
			else
			{
				Total = 3;
				//if customer is having pizza delivered, ask for name, address and phone number
				//name and address are both strings, so they can accept any input
				Console.Write("Please input customer Name  :");
				String name = Console.ReadLine();
				Console.Write("Please input customer Address  :");
				String address = Console.ReadLine();

				while (true)
				{
					Console.Write("Please input customer Phone Number  :");
					//the phone number is a number, so we need to check that it not a string
					try
					{
						phoneStr = Console.ReadLine();
						phone = Convert.ToInt32(phoneStr);
						break;
					}
					catch (System.FormatException)
					{
						Console.WriteLine("Must enter a number");
						continue;
					}
					catch (System.OverflowException)
					{
						Console.WriteLine("Please enter a valid Phone Number.");
					}

					if ((phone < 0) || (phone > big))
					{
						Console.WriteLine("Please enter a valid Phone Number.");
					}
				}
			}

			//loop allows the try;catch statment to repeat untill everything is correct
			while (true)
			{
				try
				{
					Console.Write("How many pizzas to be ordered? Maximum of five!  :");
					//by converting the input to an integer straight away, 
					//we can use the catch statment to remove the need for any further error checking
					pizzaCount = Convert.ToInt32(Console.ReadLine());
					if (pizzaCount > 5 || pizzaCount < 1)
					{
						throw new System.FormatException();
					}

					break;
				}
				catch (System.FormatException)
				{
					Console.WriteLine("Must enter a number between 1 and 5");
				}
			}

			Int32 count = 1;
			foreach (var t in Pizzas)
			{
				PizzaColor(t);
				Console.Write(Convert.ToString(count));
				Console.Write(":  ");
				Console.Write(t);
				Console.WriteLine(count < 8 ? "   $8.50" : "   $13.50");
				count++;
			}

			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine("Which Pizzas do you want? Use the numbers next to them.");
			Int32[] PizzaSelection = new Int32[pizzaCount];

			for (int i = 0; i < pizzaCount; i++)
			{
				while (true)
				{
					Console.Write("Pizza number " + Convert.ToString(i + 1) + ":   ");
					try
					{
						selection = Convert.ToInt32(Console.ReadLine());
					}
					catch (System.FormatException)
					{
						Console.WriteLine("Please enter a Pizza	number");
						continue;
					}
					catch (System.OverflowException)
					{
						Console.WriteLine("Please enter a Pizza	number");
						continue;
					}

					if ((selection > 0) && (selection < 13))
					{
						int id = selection - 1;
						PizzaSelection[i] = id;
						break;
					}

				}
			}

			//order summary
			Console.WriteLine();
			Console.WriteLine("##### Order Summary #####");
			for (int i = 0; i < pizzaCount; i++)
			{
				Console.Write(Pizzas[PizzaSelection[i]]);
				Console.WriteLine(PizzaSelection[i] < 7 ? "   $8.50" : "   $13.50");
				Total += PizzaSelection[i] < 7 ? 8.50 : 13.50;
			}
		}
	}
}