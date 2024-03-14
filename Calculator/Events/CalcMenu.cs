using System;

namespace EventHandling
{
    public class ProgramMenu
    {
        public static void Main()
        {
            var menu = new Menu
            {

                Id = 1,
                CalcMenu = "Choice 1 from Menu is Addition",
                Operation = 1 //Choice 1 from Menu is Addition

            };

            menu.OnMenuChange += CalcOnMenuChange;
            menu.OnMenuChange += ExitMenu;


            menu.Operation = 2; // Choice 2 from Menu Subtraction
        }

        private static void ExitMenu(object sender, int e)
        {
            var menu = (Menu)sender;
            if (menu.Operation <= 0)
            {
                Console.WriteLine();
                Console.WriteLine($"{menu.CalcMenu} is no longer available.");
                Console.WriteLine();
            }
        }

        private static void CalcOnMenuChange(object sender, int operation)
        {
            var menu = (Menu)sender;
            Console.WriteLine();
            Console.Write($" First choice when you enter one is {menu.CalcMenu}!");
            Console.WriteLine();
        }
    }
}
