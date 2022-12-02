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
    internal class NorthStateTests
    {
        private IRobot _robot;

        [SetUp]
        public void SetUp()
        {
            IBoard board = new Board(5, 5);
            _robot = new MyRobot(new NorthState(), 1, 1, board);
        }

        [Test]
        [Category("StateTest")]
        public void NorthState_Move_Yequals2()
        {
            _robot.State.Move();

            Assert.AreEqual(2, _robot.Y);
        }

        [Test]
        [Category("StateTest")]
        public void NorthState_TurnLeft_StateEqualsNorthWestState()
        {
            _robot.State.TurnLeft();

            Assert.IsTrue(_robot.State is NorthWestState);
        }

        [Test]
        [Category("StateTest")]
        public void NorthState_TurnRight_StateEqualsNorthEastState()
        {
            _robot.State.TurnRight();

            Assert.IsTrue(_robot.State is NorthEastState);
        }
    }
}
