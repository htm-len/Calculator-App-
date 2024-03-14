using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject;
using Calculator;

namespace CalculatorApp.Events
{
    class MenuOptions
{
    public static void Greeting()
    {
        Console.Write("Welcome to len the devs calculator");
    }


    public static void Addition()
    {
        Console.Write("Chosen Operation: Addition");
    }

      public static void Subtraction()
    {
        Console.Write("Chosen Operation: Subtraction");
    }

      public static void Division()
    {
        Console.Write("Chosen Operation: Division");
    }

      public static void Square()
    {
        Console.Write("Chosen Operation: Square");
    }

      public static void SquareRoot()
    {
        Console.Write("Chosen Operation: Square Root");
    }
}