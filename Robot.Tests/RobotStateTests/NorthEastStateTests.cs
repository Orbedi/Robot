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
    internal class NorthEastStateTests
    {
        private IRobot _robot;

        [SetUp]
        public void SetUp()
        {
            IBoard board = new Board(5, 5);
            _robot = new MyRobot(new NorthEastState(), 1, 1, board);
        }

        [Test]
        [Category("StateTest")]
        public void NorthEastState_Move_Y2X2()
        {
            _robot.State.Move();

            Assert.AreEqual(2, _robot.Y);
            Assert.AreEqual(2, _robot.X);
        }

        [Test]
        [Category("StateTest")]
        public void NorthEastState_TurnLeft_StateEqualsNorthState()
        {
            _robot.State.TurnLeft();

            Assert.IsTrue(_robot.State is NorthState);
        }

        [Test]
        [Category("StateTest")]
        public void NorthEastState_TurnRight_StateEqualsEastState()
        {
            _robot.State.TurnRight();

            Assert.IsTrue(_robot.State is EastState);
        }
    }
}
