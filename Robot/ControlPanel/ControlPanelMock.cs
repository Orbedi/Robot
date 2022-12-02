using Robot.Robot;
using Robot.Robot.RobotCommand;
using Robot.Robot.RobotState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.ControlPanel
{

    public class ControlPanelMock : IControlPanel
    {
        private char[] _Directions;
        private static IRobot _Robot;
        private Dictionary<char, Command> Commands;

        public void ReadCommand(string command = "")
        {
            IBoard board = new Board(5, 5);

            _Robot = new MyRobot(new NorthState(), 1, 1, board);

            _Directions = command.ToCharArray();

            CreateCommands();
        }

        public void ExecuteCommand()
        {
            foreach (char direction in _Directions)
            {
                Commands[direction].Execute();
            }
        }

        public string GetRobotPosition()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0},", _Robot.X);
            str.AppendFormat("{0},", _Robot.Y);
            str.AppendFormat("{0}", _Robot.State.GetState());
            return str.ToString();
        }

        private void CreateCommands()
        {
            Commands = new Dictionary<char, Command>() {
                    { 'F', new MoveCommand(_Robot) },
                    { 'R', new TurnRightCommand(_Robot) },
                    { 'L', new TurnLeftCommand(_Robot) }
                };
        }
    }
}
