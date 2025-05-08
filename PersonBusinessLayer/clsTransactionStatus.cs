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

        public int ID { set; get; }
        public string Status { set; get; }

        public clsTransactionStatus(int iD, string status)
        {
            this.ID = iD;
            this.Status = status;
        }

        public static clsTransactionStatus Find(string Status)
        {
            int ID = -1;

            if (clsDATransactionStatus.GetTransactionStatusByStatusName(Status, ref ID))
            {
                return new clsTransactionStatus(ID, Status);
            }
            return null;
        }

        public static DataTable GetAllTransactionStatus()
        {
            return clsDATransactionStatus.GetAllTransactionStatus();
        }


    }
}
