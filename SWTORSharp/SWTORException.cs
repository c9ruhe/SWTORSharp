using System;
using System.Net;
using System.Runtime.Serialization;

namespace SWTORSharp.Core
{
    internal class SWTORException : Exception
    {
        public SWTORException(string message) : base(message)
        {
        }

    }
}