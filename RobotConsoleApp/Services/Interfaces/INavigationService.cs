using RobotConsoleApp.Models;

namespace RobotConsoleApp.Services.Interfaces
{
    public interface INavigationService
        {
            Position GetDestinationByCommands(string commands,Robot robot, Map map);
        }
}
