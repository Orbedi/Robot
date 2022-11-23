using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Robot.Robot.FacingDirection;

namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            MyControlPanel controlPanel = new MyControlPanel();

            controlPanel.ReadCommand();
            controlPanel.ExecuteCommand();
            controlPanel.GetRobotPosition();      
        }
    }
}
