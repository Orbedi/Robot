using Robot.ControlPanel;
using Robot.Robot;
using Robot.Robot.RobotCommand;
using Robot.Robot.RobotState;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Robot
{
    public class MyControlPanel : IControlPanel
    {
        private char[] _Directions;
        private static IRobot _Robot; 
        private Dictionary<char, Command> Commands;

        public void ReadCommand(string command = "")
        {
            string boardCommand = Console.ReadLine();
            IBoard board = CreateBoard(boardCommand);

            _Robot = new MyRobot(new NorthState(), 1, 1, board);

            command = Console.ReadLine();
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
            Console.WriteLine(str.ToString());
            Console.ReadLine();
            return str.ToString();
        }

        private IBoard CreateBoard(string boardCommand)
        {
            string[] boardSize = boardCommand.Split('x');
            int maxX = int.Parse(boardSize[0]);
            int maxY = int.Parse(boardSize[1]);
            return new Board(maxX, maxY);
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
