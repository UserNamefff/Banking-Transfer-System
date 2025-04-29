using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersBussncessLayerLib
{
    public class clsRemittanceTransactions
    {

        public string   PersonalCardImage { get; set; }
        public int      RemittanceID      { get; set; }
        public int      TransactionID     { get; set; }
        public DateTime RemittanceDate    { get; set; }


        private clsRemittanceTransactions(string PersonalCardImage, int RemittanceID, int TransactionID, DateTime RemittanceDate)
        {
            this.PersonalCardImage= PersonalCardImage;
            this.RemittanceID     = RemittanceID     ;
            this.TransactionID    = TransactionID    ;
            this.RemittanceDate = RemittanceDate;
        }

        public clsRemittanceTransactions()
        {
            this.PersonalCardImage= "";
            this.RemittanceID     = 0 ;
            this.TransactionID    = 0 ;
            this.RemittanceDate = DateTime.Now;
        }

        
        private bool _Update()
        {
            return false;
        }
        private bool _Delete()
        {
            return false;
        }
        private bool _Add()
        {
            return false;
        }

        

        bool Save()
        {
            return false;
        }



    }
}
