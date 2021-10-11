using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        //bu class, business katmanında gerçekleşen işlemlerin geri dönüşleri için success parametresi verilmedigi zaman
        //succes parametresi için default olarak "true" degerini döndürmeyi amaçlar.
        public SuccessResult(string message) : base(true,message)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
