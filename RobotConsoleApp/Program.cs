// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using RobotConsoleApp.Helpers;
using RobotConsoleApp.Models;
using RobotConsoleApp.Services;
using RobotConsoleApp.Services.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        //setup our DI
        var serviceProvider = new ServiceCollection()
            .AddSingleton<INavigationService, NavigationService>()
            .BuildServiceProvider();

        Console.WriteLine("Welcome, to robots navigation! \n Please, provide Mars plateau size(examples 4x3,5x5...)");

        var navigationService = serviceProvider.GetService<INavigationService>();
        Map map = new Map(Console.ReadLine());
        Robot robot = new Robot(new Position(map.X, map.Y, Direction.North));

        Console.WriteLine($"Please input command(axample: LFLRFLFF) and follow next rules \r\nL: Turn the robot left\r\nR: Turn the robot right\r\nF: Move forward on it's facing direction\r\n");

        robot.Position = navigationService.GetDestinationByCommands(Console.ReadLine(), robot, map);

        Console.WriteLine($"Thanks, your destination Position is:");
        Console.WriteLine($"{robot.Position.X.ToString()},{robot.Position.Y.ToString()},{Enum.GetName(typeof(Direction), robot.Position.Direction)}");
    }
}

