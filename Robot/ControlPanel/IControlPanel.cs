using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Robot.ControlPanel
{
    public interface IControlPanel
    {
        void ReadCommand(string command = "");
        void ExecuteCommand();
        string GetRobotPosition();
    }
}
