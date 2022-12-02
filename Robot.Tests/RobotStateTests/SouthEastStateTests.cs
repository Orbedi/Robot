using NUnit.Framework;
using Robot.Robot.RobotState;
using Robot.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Tests.RobotStateTests
{
    internal class SouthEastStateTests
    {
        private IRobot _robot;

        [SetUp]
        public void SetUp()
        {
            IBoard board = new Board(5, 5);
            _robot = new MyRobot(new SouthEastState(), 1, 1, board);
        }

        [Test]
        [Category("StateTest")]
        public void SouthEastState_Move_X1Y1()
        {
            _robot.State.Move();

            Assert.AreEqual(1, _robot.X);
            Assert.AreEqual(1, _robot.Y);
        }

        [Test]
        [Category("StateTest")]
        public void SouthEastState_TurnLeft_StateEqualsEastState()
        {
            _robot.State.TurnLeft();

            Assert.IsTrue(_robot.State is EastState);
        }

        [Test]
        [Category("StateTest")]
        public void SouthEastState_TurnRight_StateEqualsSouthState()
        {
            _robot.State.TurnRight();

            Assert.IsTrue(_robot.State is SouthState);
        }
    }
}
