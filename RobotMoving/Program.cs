using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotMoving
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = false;
            Console.WriteLine("Welcome to the Robot Moving App! ");
            Console.WriteLine("Type the valid Command:PLACE X,Y,NORTH /Move/Left/Right/Avoid/Report ");
            Robot robotA = new Robot();
            while (exit == false)
            {
                string cmdargs;
                robotA.RunConsoleCommand(CommandHelper.CommParse(Console.ReadLine(), out cmdargs), cmdargs);
            }

        }
       

    }
    
}
