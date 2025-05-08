using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerr;

namespace UsersBussncessLayerLib
{
    public class clsTransaction_type
    {

        public int ID { set; get; }
        public string Transaction_typeName { set; get; }

        public clsTransaction_type(int iD, string transaction_typeName)
        {
            this.ID = iD;
            this.Transaction_typeName = transaction_typeName;
        }


        public static clsTransaction_type Find(string Transaction_type)
        {
            int ID = -1;

            if (clsDATrasactionTypes.GetTransactionTypeByTransaction_type(Transaction_type,ref ID))
            {
                return new clsTransaction_type(ID, Transaction_type);
            }
            return null;
        }
        public static DataTable GetAllTransaction_types(bool FromORToAccount = true)
        {
            return clsDATrasactionTypes.GetAllTransaction_types(FromORToAccount);
        }


    }
}
