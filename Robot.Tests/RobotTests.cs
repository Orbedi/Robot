using NUnit.Framework;
using Robot.Robot.RobotState;

namespace Robot.Tests
{
    public class RobotTests
    {
        private Board _board;
        private MyRobot _robot;

        [SetUp]
        public void Setup()
        {
            _board = new Board(5, 5);
            _robot = new MyRobot(new NorthState(), 1, 1, _board);
        }

        [Test]
        public void Robot_InitialValues()
        {
            Assert.AreEqual(1, _robot.X);
            Assert.AreEqual(1, _robot.Y);
            Assert.IsTrue(_robot.State is NorthState);
            Assert.AreEqual(_board, _robot.Board);
        }

        [Test]
        public void Move_MoveToNorth_Yequals2()
        {
            _robot.Move();
            Assert.AreEqual(2, _robot.Y);
        }

        [Test]
        public void ChangeDirection_East_FacingDirectionEqualsEast()
        {
            _robot.TurnRight();
            Assert.IsTrue(_robot.State is NorthEastState);
        }

        [Test]
        public void ChangeDirectionAndMove_MoveToEast_Xequals2()
        {
            _robot.TurnRight();
            _robot.Move();
            Assert.AreEqual(2, _robot.X);
            Assert.AreEqual(2, _robot.Y);
        }

        [Test]
        public void Move_MoveToBorder_Yequals5()
        {
            for (int i = 0; i < 10; i++)
            {
                _robot.Move();
            }
            Assert.AreEqual(5, _robot.Y);
        }

        [Test]
        public void ChangeDirection_TurnRightTwice_FacingDirectionEqualsSouth()
        {
            _robot.TurnRight();
            _robot.TurnRight();
            Assert.IsTrue(_robot.State is EastState);
        }

        
    }
}