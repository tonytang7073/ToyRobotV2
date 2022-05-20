using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RobotMoving
{
   public static class CommandHelper
    {
        public static RobotCommand CommParse(string commandString, out string cmdargs)
        {
            if (commandString == null) { cmdargs = String.Empty; return RobotCommand.INVALID; }
            string commtrim = commandString.Trim();
            var commandParts = commtrim.Split(' ').ToList();
            var commandName = commandParts[0];
            cmdargs = commtrim.Substring(commtrim.IndexOf(' ') + 1);
            switch (commandName.Trim().ToUpper())
            {
                case "PLACE": return RobotCommand.PLACE;
                case "MOVE": return RobotCommand.MOVE;
                case "LEFT": return RobotCommand.LEFT;
                case "RIGHT": return RobotCommand.RIGHT;
                case "REPORT": return RobotCommand.REPORT;
                case "AVOID": return RobotCommand.AVOID;
                default: return RobotCommand.INVALID;
            }
        }


        public static RobotFace ParseFace(string face)
        {
            if (face == null) { return RobotFace.UNKNOWN; }
            switch (face.Trim().ToUpper())
            {
                case "NORTH": return RobotFace.NORTH;
                case "WEST": return RobotFace.WEST;
                case "EAST": return RobotFace.EAST;
                case "SOUTH": return RobotFace.SOUTH;
                case "NORTH EAST": return RobotFace.NORTH_EAST;
                case "NORTH WEST": return RobotFace.NORTH_WEST;
                case "SOUTH WEST": return RobotFace.SOUTH_WEST;
                case "SOUTH EAST": return RobotFace.SOUTH_EAST;
                default: return RobotFace.UNKNOWN;
            }
        }

        public static string GetEnumDisplayName(this Enum enumType)
        {
            return enumType.GetType().GetMember(enumType.ToString())
                           .First()
                           .GetCustomAttribute<DisplayAttribute>()
                           .Name;
        }

    }
}
