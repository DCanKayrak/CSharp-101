using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class RecordNotFoundException:Exception
    {
        public RecordNotFoundException(string message):base(message)
        {

        }
        //public override string Message => "Kayıt Bulunamadı!"; // override ettim.
    }
}
