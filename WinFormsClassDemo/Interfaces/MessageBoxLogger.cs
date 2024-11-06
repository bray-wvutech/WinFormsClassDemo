using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassDemo.Interfaces;
internal class MessageBoxLogger : ILogger
{
    public void Log(string message)
    {
        MessageBox.Show(message);
    }
}
