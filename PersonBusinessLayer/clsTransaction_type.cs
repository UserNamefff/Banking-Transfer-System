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

        public static DataTable GetAllTransaction_types(bool FromORToAccount = true)
        {
            return clsDATrasactionTypes.GetAllTransaction_types(FromORToAccount);
        }

    }
}
