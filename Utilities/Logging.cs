using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Midnight.Utilities
{
    public static class Logging
    {
        public static void Log(object message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "<unknown>")
        {
            string filename = System.IO.Path.GetFileName(filePath);
            Console.WriteLine(filename + ":" + lineNumber + ": " + message);
        }
    }
}
