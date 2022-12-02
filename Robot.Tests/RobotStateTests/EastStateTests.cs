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
    internal class EastStateTests
    {
        private IRobot _robot;

        [SetUp]
        public void SetUp()
        {
            IBoard board = new Board(5, 5);
            _robot = new MyRobot(new EastState(), 1, 1, board);
        }

        [Test]
        [Category("StateTest")]
        public void EastState_Move_Xequals2()
        {
            _robot.State.Move();

            Assert.AreEqual(2, _robot.X);
        }

        [Test]
        [Category("StateTest")]
        public void EastState_TurnLeft_StateEqualsNorthEastState()
        {
            _robot.State.TurnLeft();

            Assert.IsTrue(_robot.State is NorthEastState);
        }

        [Test]
        [Category("StateTest")]
        public void EastState_TurnRight_StateEqualsSouthEastState()
        {
            _robot.State.TurnRight();

            Assert.IsTrue(_robot.State is SouthEastState);
        }
    }
}
