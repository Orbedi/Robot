using NUnit.Framework;
using Robot.Robot.RobotState;
using Robot.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Robot.Tests.RobotStateTests
{
    internal class WestStateTests
    {
        private IRobot _robot;

        [SetUp]
        public void SetUp()
        {
            IBoard board = new Board(5, 5);
            _robot = new MyRobot(new WestState(), 1, 1, board);
        }

        [Test]
        [Category("StateTest")]
        public void WestState_Move_X1Y1()
        {
            _robot.State.Move();

            Assert.AreEqual(1, _robot.X);
            Assert.AreEqual(1, _robot.Y);
        }

        [Test]
        [Category("StateTest")]
        public void WestState_TurnLeft_StateEqualsSouthWestState()
        {
            _robot.State.TurnLeft();

            Assert.IsTrue(_robot.State is SouthWestState);
        }

        [Test]
        [Category("StateTest")]
        public void WestState_TurnRight_StateEqualsNorthWestState()
        {
            _robot.State.TurnRight();
            Assert.IsTrue(_robot.State is NorthWestState);
        }
    }
}
