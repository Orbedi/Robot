using NUnit.Framework;
using Robot.Robot;
using Robot.Robot.RobotCommand;
using Robot.Robot.RobotState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Tests
{
    internal class CommandTests
    {
        private IRobot _robot;

        [SetUp]
        public void SetUp()
        {
            IBoard board = new Board(5, 5);
            _robot = new MyRobot(new NorthState(), 1, 1, board);
        }

        [Test]
        public void MoveCommand_Execute_Xequals2()
        {
            Command command = new MoveCommand(_robot);
            command.Execute();

            Assert.AreEqual(2, _robot.Y);
        }

        [Test]
        public void TurnLeftCommand_Execute_FacingDirectionNorthWest()
        {
            Command command = new TurnLeftCommand(_robot);
            command.Execute();

            Assert.IsTrue(_robot.State is NorthWestState);
        }

        [Test]
        public void TurnRightCommand_Execute_FacingDirectionNorthEast()
        {
            Command command = new TurnRightCommand(_robot);
            command.Execute();

            Assert.IsTrue(_robot.State is NorthEastState);
        }
    }
}
