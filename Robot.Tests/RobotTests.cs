using NUnit.Framework;
using static Robot.Robot.FacingDirection;
using static Robot.Robot.TurnDirection;

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
            _robot = new MyRobot(1, 1, _board, FacingDirections.North);
        }

        [Test]
        public void Robot_InitialValues()
        {
            Assert.AreEqual(1, _robot.X);
            Assert.AreEqual(1, _robot.Y);
            Assert.AreEqual(FacingDirections.North, _robot.FacingDirection);
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
            _robot.ChangeDirection(Turn.Right);
            Assert.AreEqual(FacingDirections.East, _robot.FacingDirection);
        }

        [Test]
        public void ChangeDirectionAndMove_MoveToEast_Xequals2()
        {
            _robot.ChangeDirection(Turn.Right);
            _robot.Move();
            Assert.AreEqual(2, _robot.X);
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

        
    }
}