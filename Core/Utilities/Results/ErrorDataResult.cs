using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //parametreler data ve mesaj ise datayı ve mesajı döndürür. işlemin başarısız olduğunu false degeriyle belirtir.
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //parametre sadece data ise datayı döndürür. işlemin başarısız olduğunu false degeriyle belirtir.
        public ErrorDataResult(T data) : base(data, false)
        {

        }

    }
}
