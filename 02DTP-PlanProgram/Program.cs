﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DTP_PlanProgram {
    class Program {
        //public string[] pizzas = {"Meatlovers", "Ham & Cheese", "Hawaiian", "Chicken", "Mexican", "Sea Food", "Garlic", "Margarita", "Pepperoni", "Thai Curry", "Cheese", "Double Cheese"};
        static void Main(string[] args) {
            string[] pizzas = {"Meatlovers", "Ham & Cheese", "Hawaiian", "Chicken", "Mexican", "Sea Food", "Garlic", "Margarita", "Pepperoni", "Thai Curry", "Cheese", "Double Cheese"};
            Int32 i = 0;
            System.Console.BackgroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("Welcome to *** Pizza");
            System.Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(pizzas[i], ", "); i++;
            System.Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(pizzas[i], ", ");
            i++;
            Console.Write(pizzas[i], ", ");
            i++;
            System.Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(pizzas[i], ", ");
            i++;
            System.Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(pizzas[i], ", ");
            i++;
            System.Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(pizzas[i], ", ");
            i++;
            System.Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pizzas[i], ", ");
            i++;
            System.Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(pizzas[i], ", ");
            i++;
            System.Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(pizzas[i], ", ");
            i++;
            System.Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(pizzas[i], ", ");
            i++;
            Console.Write(pizzas[i], ", ");
            i++;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
