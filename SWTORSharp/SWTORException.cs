using System;
using System.Net;
using System.Runtime.Serialization;

namespace SWTORSharp.Core
{
    internal class SWTORException : Exception
    {
        public HttpStatusCode HttpStatusCode;
        public SWTORException(string message, HttpStatusCode code) : base(message)
        {
            HttpStatusCode = code;
        }

    }
}