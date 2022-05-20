using System;
using System.Collections.Generic;
using System.Text;

namespace RobotMoving
{
    internal static class GlobalConfig
    {
        private static int _maxBoard = 7;

        public static int MaxBoard { get { return _maxBoard; } }
    }
}
