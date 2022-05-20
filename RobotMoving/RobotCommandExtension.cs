using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotMoving
{
    public static class RobotCommandExtension
    {
        public static void RunConsoleCommand(this Robot rb, RobotCommand cmd, string cmdArgs)
        {
            if (rb == null) { Console.WriteLine("Oops, not an Robot object!"); return; }

            switch (cmd)
            {
                case RobotCommand.INVALID:
                    Console.WriteLine("Oops this is not a valid command.!"); break;
                case RobotCommand.LEFT:
                    rb.Left(); break;
                case RobotCommand.MOVE:
                    rb.Move(); break;
                case RobotCommand.PLACE:
                    PlaceCommand(rb, cmdArgs); break;
                case RobotCommand.REPORT:
                    ReportCommand(rb); break;
                case RobotCommand.RIGHT:
                    rb.Right(); break;
                case RobotCommand.AVOID:
                    AvoidCommand(rb, cmdArgs); break;
            }
        }

        public static void AvoidCommand(this Robot rb, string cmdargs)
        {
            if (rb == null) { Console.WriteLine("Oops, not an Robot object!"); return; }
            string argtrim = cmdargs.Trim();
            var argParts = argtrim.Split(',').ToList();
            int x, y;

            if (!int.TryParse(argParts[0], out x) || !int.TryParse(argParts[1], out y))
            {
                Console.WriteLine("Oops this is not a valid Avoid command. It should be like: Avoid 1,2");
                return;
            }
            rb.Avoid(x, y);

        }

        public static void PlaceCommand(this Robot rb, string cmdargs)
        {
            if (rb == null) { Console.WriteLine("Oops, not an Robot object!"); return; }
            string argtrim = cmdargs.Trim();
            var argParts = argtrim.Split(',').ToList();
            int x, y;

            if (rb.IsOnTableTop())
            {
                if (!int.TryParse(argParts[0], out x) || !int.TryParse(argParts[1], out y))
                {
                    Console.WriteLine("Oops this is not a valid place command. It should be like: Place 1,2");
                    return;
                }
                rb.Place(x, y);
            }
            else
            {
                var face = CommandHelper.ParseFace(argParts[2]);

                if (argParts.Count < 3 || !int.TryParse(argParts[0], out x) || !int.TryParse(argParts[1], out y) || face == RobotFace.UNKNOWN)
                {
                    Console.WriteLine("Oops this is not a valid place command. It should be like: Place 1,2,North");
                    return;
                }
                rb.Place(x, y, CommandHelper.ParseFace(argParts[2].Trim().ToUpper()));
            }

        }

        public static void ReportCommand(this Robot rb)
        {
            if (rb != null && rb.Report() != null)
            {
                Console.WriteLine("Output:" + rb.Report());
            }
        }


    }
}
