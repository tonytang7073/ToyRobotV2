using RobotMoving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotMoving
{
    public class Robot
    {
        
        public int? PositionX { get; private set; }
        public int? PositionY { get; private set; }

        public RobotFace Face { get; private set; }

        public List<Tuple<int, int>> AvoidedPositions { get; private set; }

        public Robot()
        {
            this.PositionX = null;
            this.PositionY = null;
            this.AvoidedPositions = new List<Tuple<int, int>>();

        }

        public void Avoid(int x, int y)
        {
            if ((this.AvoidedPositions != null) && !IsCurrentPosition(x, y))
            { AvoidedPositions.Add(new Tuple<int, int>(x, y)); }
        }

        private bool IsCurrentPosition(int x, int y)
        {
            return x == PositionX && y == PositionY;
        }

        private bool IsObstructed(int x, int y)
        {
            return AvoidedPositions.Contains(new Tuple<int, int>(x, y));
        }

        public void Place(int x, int y, RobotFace face)
        {
            if (!IsOnTableTop()) { Face = face; } //only set Face for the first Place.
            Place(x, y);
        }

        public void Place(int x, int y)
        {
            if (IsInsideRange(x) && !IsObstructed(x,y)) { PositionX = x; }
            if (IsInsideRange(y) && !IsObstructed(x,y)) { PositionY = y; }

        }

        public void Move()
        {
            if (!IsOnTableTop()) { return; }

            int oldX = (int)PositionX;
            int oldY = (int)PositionY;

            switch (Face)
            {
                case RobotFace.NORTH: oldY++; break;
                case RobotFace.SOUTH: oldY--; break;
                case RobotFace.EAST: oldX++; break;
                case RobotFace.WEST: oldX--; break;
                case RobotFace.NORTH_EAST: oldY++; oldX++; break;
                case RobotFace.SOUTH_WEST: oldY--; oldX--; break;
                case RobotFace.NORTH_WEST: oldY++; oldX--; break;
                case RobotFace.SOUTH_EAST: oldY++; oldX++; break;

            }

            if (IsInsideRange(oldY) && !IsObstructed(oldX, oldY)) { PositionY = oldY; }
            if (IsInsideRange(oldX) && !IsObstructed(oldX, oldY)) { PositionX = oldX; }



        }

        public void Left()
        {
            if (!IsOnTableTop()) { return; }
            switch (Face)
            {
                case RobotFace.NORTH: Face = RobotFace.NORTH_WEST; break;
                case RobotFace.NORTH_WEST: Face = RobotFace.WEST; break;
                case RobotFace.WEST: Face = RobotFace.SOUTH_WEST; break;
                case RobotFace.SOUTH_WEST: Face = RobotFace.SOUTH; break;
                case RobotFace.SOUTH: Face = RobotFace.SOUTH_EAST; break;
                case RobotFace.SOUTH_EAST: Face = RobotFace.EAST; break;
                case RobotFace.EAST: Face = RobotFace.NORTH_EAST; break;
                case RobotFace.NORTH_EAST: Face = RobotFace.NORTH; break;
               
            }
        }

        public void Right()
        {
            if (!IsOnTableTop()) { return; }
            switch (Face)
            {
                case RobotFace.NORTH: Face = RobotFace.NORTH_EAST; break;
                case RobotFace.NORTH_EAST: Face = RobotFace.EAST; break;
                case RobotFace.EAST: Face = RobotFace.SOUTH_EAST; break;
                case RobotFace.SOUTH_EAST: Face = RobotFace.SOUTH; break;
                case RobotFace.SOUTH: Face = RobotFace.SOUTH_WEST; break;
                case RobotFace.SOUTH_WEST: Face = RobotFace.WEST; break;
                case RobotFace.WEST: Face = RobotFace.NORTH_WEST; break;
                case RobotFace.NORTH_WEST: Face = RobotFace.NORTH; break;
            }
        }


        

        public bool IsOnTableTop()
        {

            return PositionX != null && PositionY != null;

        }

        private bool IsInsideRange(int position)
        {
            return position <= GlobalConfig.MaxBoard && position >= 0;

        }

        public string Report()
        {
            if (!IsOnTableTop()) { return null; }
            return String.Format("{0},{1},{2}", PositionX, PositionY, Face.GetEnumDisplayName());
        }

        
        

        



    }
}
