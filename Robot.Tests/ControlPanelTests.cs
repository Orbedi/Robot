using NUnit.Framework;
using Robot.ControlPanel;
using Robot.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Robot.Robot.FacingDirection;

namespace Robot.Tests
{
    internal class ControlPanelTests
    {
        private IBoard _board;
        private IRobot _robot;
        private IControlPanel _controlPanel;

        [SetUp]
        public void SetUp()
        {
            _board = new Board(5, 5);
            _robot = new MyRobot(1, 1, _board, FacingDirections.North);
            _controlPanel = new ControlPanelMock();
        }

        [TestCase("FF", "1,3,North")]
        [TestCase("RFF", "3,1,East")]
        [TestCase("LFF", "1,1,West")]
        [TestCase("RRLRRR", "1,1,North")]
        [TestCase("FFRFLFLF", "1,4,West")]
        [TestCase("FFFFRFFFFLLL", "5,5,South")]
        [TestCase("FFFFFFFFFFFFFFFFFF", "1,5,North")]
        public void ControlPanel_NewCommand_Success(string command, string robotPosition)
        {
            _controlPanel.ReadCommand(command);
            _controlPanel.ExecuteCommand();
            string result = _controlPanel.GetRobotPosition();
            Assert.AreEqual(robotPosition, result);
        }


    }
}
