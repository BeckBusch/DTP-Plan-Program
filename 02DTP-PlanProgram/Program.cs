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
				//pizzaCount
		public static int PizzaCount;
		public static int Phone;
		public static Int64 Big = 9999999999;
		public static string PhoneStr;
		public static int Selection;
		public static double Total;
		public static bool Deliver = false;
		public static string name;
		public static string address;

		static void Main(string[] args)
		{
			//while loop to repeat the entire program if the user wants to order again
			while (true)
			{
				//uses method to ask user questons with only two options
				if (Choice("Pickup", "Delivery") == true)
				{
					//if customer is picking up, only ask for name
					Console.Write("Please input customer Name  :");
					name = Console.ReadLine();
				}
				else
				{
					//start the total cost out as 3, which is the delivery cost
					Total = 3;
					Deliver = true;
					//if customer is having pizza delivered, ask for name, address and phone number
					//name and address are both strings, so they can accept any input
					Console.Write("Please input customer Name  :");
					name = Console.ReadLine();
					Console.Write("Please input customer Address  :");
					address = Console.ReadLine();

					while (true)
					{
						Console.Write("Please input customer Phone Number  :");
						//the phone number is a number, so we need to check that it not a string
						try
						{
							PhoneStr = Console.ReadLine();
							Phone = Convert.ToInt32(PhoneStr);
							break;
						}
						//make sure that the phone number entered was not a string
						catch (System.FormatException)
						{
							Console.WriteLine("Must enter a number");
							continue;
						}
						//make sure that the phone number entered was not so large that it causes an overflow
						catch (System.OverflowException)
						{
							Console.WriteLine("Please enter a valid Phone Number.");
						}

						//make sure that the phone number is not larger the longest phone number
						//this is different from the overflow code above as this code could not run if the nuber was so big as to cause an overflow
						if ((Phone < 0) || (Phone > Big))
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
						PizzaCount = Convert.ToInt32(Console.ReadLine());
						if (PizzaCount > 5 || PizzaCount < 1)
						{
							throw new System.FormatException();
						}

						//break leaves the loop
						break;
					}
					catch (System.FormatException)
					{
						Console.WriteLine("Must enter a number between 1 and 5");
						//the lack of a break statment means that the code will keep looping in the case on an invalid input
					}
				}

				//created a counter to manage the prices
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
				Int32[] PizzaSelection = new Int32[PizzaCount];

				for (int i = 0; i < PizzaCount; i++)
				{
					while (true)
					{
						Console.Write("Pizza number " + Convert.ToString(i + 1) + ":   ");
						try
						{
							Selection = Convert.ToInt32(Console.ReadLine());
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

						if ((Selection > 0) && (Selection < 13))
						{
							int id = Selection - 1;
							PizzaSelection[i] = id;
							break;
						}

					}
				}

				//order summary
				Console.WriteLine();
				Console.WriteLine("##### Order Summary #####");
				for (int i = 0; i < PizzaCount; i++)
				{
					Console.Write(Pizzas[PizzaSelection[i]]);
					Console.WriteLine(PizzaSelection[i] < 7 ? "   $8.50" : "   $13.50");
					Total += PizzaSelection[i] < 7 ? 8.50 : 13.50;
				}

				Console.Write("Total Cost:  ");
				Console.WriteLine(Convert.ToString(Total));
				if (Deliver == true)
				{
					Console.WriteLine("Including delivery cost of $3.00");
					Console.WriteLine();
					Console.Write("Name: ");
					Console.WriteLine(name);
					Console.Write("Address: ");
					Console.WriteLine(address);
					Console.Write("Phone Number: ");
					Console.WriteLine(PhoneStr);
				}
				else
				{
					Console.WriteLine();
					Console.WriteLine(name);
				}

				if (Choice("Order Again", "Close Program") == false)
				{
					break;
				}
			}
		}
	}
}