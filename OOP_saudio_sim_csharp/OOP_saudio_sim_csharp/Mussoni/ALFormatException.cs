using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_saudio_sim_csharp.Mussoni
{
    class ALFormatException : Exception
    {
        private readonly string error;

        public ALFormatException(string message) : base(message)
        {
            error = message;
        }

        public ALFormatException(string message, Exception e) : base(message, e) 
        {
            error = message;
        }

        public override string ToString()
        {
            return error + ", the file is not a 8 or 16 bit mono audio file";
        }
    }
}
