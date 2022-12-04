using RobotConsoleApp.Helpers;
using RobotConsoleApp.Models;
using RobotConsoleApp.Services.Interfaces;

namespace RobotConsoleApp.Services
{
    public class NavigationService: INavigationService
    {
        public Position GetDestinationByCommands(string commands, Robot robot, Map map)
        {
            foreach (char command in commands)
            {
                switch (command)
                {
                    case Constants.Command.Forward:
                        if (checkIsValidMove(robot.Position, map))
                            robot.MoveForward();
                        break;
                    case Constants.Command.Left:
                        robot.TurnLeft();
                        break;
                    case Constants.Command.Right:
                        robot.TurnRight();
                        break;

                }
            }
            return robot.Position;
        }

        private bool checkIsValidMove(Position position, Map map)
        {
            if ((position.Direction == Direction.North && position.Y < map.Height) ||
                (position.Direction == Direction.East && position.X < map.Width) ||
                (position.Direction == Direction.South && position.Y > map.Y) ||
                (position.Direction == Direction.West && position.X > map.X))
                return true;

            return false;
        }
    }
}
