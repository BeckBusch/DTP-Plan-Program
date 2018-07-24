using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DTP_PlanProgram
{
	class Program
	{
		public static double Total;
		public static bool Deliver = false;
		public static string name;
		public static string address;
		public static int Phone;
		public static Int64 Big = 9999999999;
		public static string PhoneStr;

		static void Main(string[] args)
		{
		
			//uses method to ask user questons with only two options
			if() {
				//if customer is picking up, only ask for name
				Console.Write("Please input customer Name  :");
				name = Console.ReadLine();
			}
			else {
				//start the total cost out as 3, which is the delivery cost
				Total = 3;
				Deliver = true;
				//if customer is having pizza delivered, ask for name, address and phone number
				//name and address are both strings, so they can accept any input
				Console.Write("Please input customer Name  :");
				name = Console.ReadLine();
				Console.Write("Please input customer Address  :");
				address = Console.ReadLine();
				//continous loop that is ended via 'break' rather than the condition being false
				while(true) {
					Console.Write("Please input customer Phone Number  :");
					//the phone number is a number, so we need to check that it not a string
					try {
						PhoneStr = Console.ReadLine();
						Phone = Convert.ToInt32(PhoneStr);
						break;
					}
					//make sure that the phone number entered was not a string
					catch(System.FormatException) {
						Console.WriteLine("Must enter a number");
						continue;
					}
					//make sure that the phone number entered was not so large that it causes an overflow
					catch(System.OverflowException) {
						Console.WriteLine("Please enter a valid Phone Number.");
					}
					//make sure that the phone number is not larger the longest phone number
					//this is different from the overflow code above as this code could not run if the nuber was so big as to cause an overflow
					if((Phone < 0) || (Phone > Big)) {
						Console.WriteLine("Please enter a valid Phone Number.");
					}
				}
			}
		}
	}
}