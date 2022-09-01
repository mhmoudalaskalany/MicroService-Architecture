using System;
using System.Net;

namespace BackendCore.Common.Core
{
    public class FinalResult : IFinalResult
    {
        public object Data { get; set; }
        public HttpStatusCode Status { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
