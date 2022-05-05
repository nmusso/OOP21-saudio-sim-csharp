using System;
using System.Collections.Generic;
using System.Text;

namespace Buffer
{
    class ALFormatException : Exception
    {
        public ALFormatException(string message, Exception e)
        {
            Console.WriteLine(message + "\n" + e.StackTrace);
        }

        public ALFormatException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
