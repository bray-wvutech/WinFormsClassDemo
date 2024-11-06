using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClassDemo.Interfaces;
internal class TraceLogger : ILogger
{
    public void Log(string message)
    {
        Trace.WriteLine(message);
    }
}
