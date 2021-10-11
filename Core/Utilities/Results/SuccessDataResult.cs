using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //parametreler data ve mesaj ise datayı ve mesajı döndürür. işlemin başarılı olduğunu true degeriyle belirtir.
        public SuccessDataResult(T data,string message):base(data,true,message)
        {
            
        }
        //parametre sadece data ise datayı döndürür. işlemin başarılı olduğunu true degeriyle belirtir.
        public SuccessDataResult(T data) : base(data, true)
        {

        }


    }
}
