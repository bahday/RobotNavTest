using RobotConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotConsoleApp.Models
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
        public Position(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            direction = direction;
        }

    };
}
