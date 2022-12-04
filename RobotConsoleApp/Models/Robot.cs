using RobotConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotConsoleApp.Models
{
    public class Robot
    {
        public Position Position { get; set; }

        public Robot(Position position)
        {
            Position = position;
        }

        public void TurnLeft()
        {
            Position.Direction -= 1;
            if (Position.Direction < 0) Position.Direction = Direction.West;
        }

        public void TurnRight()
        {
            Position.Direction += 1;
            if (Position.Direction > Direction.West) Position.Direction = Direction.North;

        }

        public void MoveForward()
        {
            switch (Position.Direction)
            {
                case Direction.North:
                    Position.Y += 1;
                    break;
                case Direction.East:
                    Position.X += 1;
                    break;
                case Direction.South:
                    Position.Y -= 1;
                    break;
                case Direction.West:
                    Position.X -= 1;
                    break;
            }
        }

    }
}
