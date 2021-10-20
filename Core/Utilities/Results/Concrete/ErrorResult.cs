using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message) //base Result'a göndermek istenilen şey demek. Ve oradaki şeyi tetikleyip çalıştırır bu yöntem ile.
        {

        }

        public ErrorResult() : base(false)
        {

        }
    }
}
