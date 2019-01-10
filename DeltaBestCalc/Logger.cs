using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeltaBestCalc
{
    class Logger
    {
        public static void Print(string message)
        {
            File.AppendAllText("log.txt", message + " ");
        }
    }
}
