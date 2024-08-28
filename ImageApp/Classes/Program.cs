using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using SERVER;
using System.Windows.Forms;

namespace ImageApp
{
    /// <summary>
    /// Authors: Jack Hughes & Matthew Whitehouse
    /// Date: 29/03/2022
    /// STARTS application
    /// </summary>
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // CREATE _factory, _commandInvoker, _baseView and controller
            IFactory _factory = new Factory();

            ICommandInvoker _commandInvoker = new CommandInvoker();

            IBaseView _baseView = new BaseView();

            IController _controller = new Controller(_factory, _commandInvoker.ExecuteCommand, _baseView);

            // RUN the app
            Application.Run((_baseView as BaseView));
        }
    }
}
