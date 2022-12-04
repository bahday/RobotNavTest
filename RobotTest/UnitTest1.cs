using RobotConsoleApp.Models;
using RobotConsoleApp.Services.Interfaces;
using RobotConsoleApp.Services;
using RobotConsoleApp.Helpers;

namespace RobotTest
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var map = new Map("3x4");
            Assert.AreEqual(3, map.Width);
            Assert.AreEqual(4, map.Height);

        }

        [Test]
        public void Test2()
        {
            var result = new NavigationService().GetDestinationByCommands("FFRFLFLF", new Robot(new Position(1,1, Direction.North)), new Map("5x5"));

            Assert.AreEqual("1,4,West", $"{result.X.ToString()},{result.Y.ToString()},{Enum.GetName(typeof(Direction), result.Direction)}");

        }
    }
}