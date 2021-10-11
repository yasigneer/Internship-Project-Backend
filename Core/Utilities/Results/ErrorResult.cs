using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        //SuccessResult class'ının tam tersi işlevindedir.
        public ErrorResult(string message) : base(false)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
