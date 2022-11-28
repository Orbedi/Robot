using NUnit.Framework;
using Robot.ControlPanel;
using Robot.Robot;
using Robot.Robot.RobotState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _robot = new MyRobot(new NorthState(), 1, 1, _board);
            _controlPanel = new ControlPanelMock();
        }

        [TestCase("FF", "1,3,North")]
        [TestCase("RFF", "3,3,NorthEast")]
        [TestCase("LFF", "1,1,NorthWest")]
        [TestCase("RRLRRR", "1,1,South")]
        [TestCase("FFRFLFLF", "2,5,NorthWest")]
        [TestCase("FFFFRFFFFLLL", "1,5,West")]
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
