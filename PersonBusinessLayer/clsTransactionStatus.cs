using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerr;
namespace UsersBussncessLayerLib
{
    public class clsTransactionStatus
    {
        
        public static DataTable GetAllTransactionStatus()
        {
            return clsDATransactionStatus.GetAllTransactionStatus();
        }

    }
}
