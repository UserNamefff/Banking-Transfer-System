
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerr;

namespace UsersBussncessLayerLib
{
    public class clsTransactions
    {
        public enum enMode { eSendTransfer = 1 , Update , Delete , RemittanceTransfer , Empty}

        private int      _TransactionID;  
        private int      _TransactionNumber;
        private int      _SenderID;
        private int      _RecierverID;
        private int      _SourceBranchID;
        private int      _TargeteBranchID;
        private int   _Transaction_Status_ID;
        private double   _FeeAmount;
        private int      _CurrencyID;
        private double   _TransferAmount;
        private DateTime _Date_Transaction;
        private string   _Description;
        private bool _isClientRecierver;
        private bool _isClientSender;
        private int _ClientRecierverID;
        private int _ClientSenderID;
        public  int Transacion_type{ set; get; }

        public enMode _eMode;
        public clsCurrency currency;
        public clsBranches SourceBranch;
        public clsBranches TargetBranch;
        public clsTransactions() 
        {
            this._TransactionID        = 0;
            this._TransactionNumber    = 0;
            this._SenderID             = 0;
            this._RecierverID          = 0;
            this._SourceBranchID       = 0;
            this._TargeteBranchID      = 0;
            this._Transaction_Status_ID= 0;
            this._FeeAmount            = 0.0;
            this._CurrencyID           = 0;
            this._TransferAmount       = 0.0 ;
            this._Date_Transaction     = DateTime.Now;
            this._Description          = "";
             _isClientRecierver = false;
             _isClientSender = false;

            _eMode = enMode.eSendTransfer;

        }
        Random random = new Random();
        
        private int _GetUniqueTransactionNumber()
        {
            clsDATransactions.IsTransactionExist(this._TransactionNumber);
            do
            {
                this.TransactionNumber = random.Next(1000, 20000);

            } while (clsDATransactions.IsTransactionExist(this._TransactionNumber));

            return this._TransactionNumber;
        }
        private clsTransactions(int TransactionID,int TransactionNumber,int SenderID,int RecierverID,int SourceBranchID,int TargeteBranchID,int Transaction_Status_ID, double TransferAmount,
                                double FeeAmount, int CurrencyID, bool isClientRecierver, bool isClientSender, int ClientSenderID ,int ClientRecierverID , string Description)
        {
            this._isClientRecierver = isClientRecierver;
            this._isClientSender    = isClientSender;
            this._ClientSenderID = ClientSenderID;
            this._ClientRecierverID = ClientRecierverID;

            this._TransactionID         = TransactionID;
            this._TransactionNumber     = TransactionNumber;
            this._SenderID              = SenderID;
            this._RecierverID           = RecierverID;
            this._SourceBranchID        = SourceBranchID;
            this._TargeteBranchID       = TargeteBranchID;
            this._Transaction_Status_ID = Transaction_Status_ID;
            this._FeeAmount             = FeeAmount;
            this._CurrencyID            = CurrencyID;
            this._TransferAmount        = TransferAmount;
            this._Date_Transaction      = DateTime.Now;
            this._Description           = Description;
            this.SourceBranch           = clsBranches.Find(this.SourceBranchID);
            this.TargetBranch           = clsBranches.Find(this.TargeteBranchID);
            this.currency               = clsCurrency.FindCurrencyInfoByID(this.CurrencyID);
            _eMode                      = enMode.eSendTransfer;

        }

        public int TransactionID
        {
            get { return _TransactionID; }
        }
        public bool isClientRecierver
        {
            set { _isClientRecierver = value; }
            get { return _isClientRecierver; }
        }
        public bool isClientSender
        {
            set { _isClientSender = value; }
            get { return _isClientSender; }

        }
        private int TransactionNumber
        {
            
            get { return _TransactionNumber; }

            set { _TransactionNumber = value; }
        }
        public int SenderID
        {
            get { return _SenderID; }
            set { _SenderID = value; }
        }
        public int RecierverID
        {
            get { return _RecierverID; }
            set { _RecierverID = value; }
        }
        public int SourceBranchID
        {
            get { return _SourceBranchID; }
            set { _SourceBranchID = value; }
        }
        public int TargeteBranchID
        {
            get { return _TargeteBranchID; }
            set { _TargeteBranchID = value; }
        }
        public int Transaction_Status_ID
        {
            get{ return _Transaction_Status_ID; }
            set { _Transaction_Status_ID = value; }
        }
        public double FeeAmount
        {
            get { return _FeeAmount; }
            set { _FeeAmount = value; }
        }
        public int CurrencyID
        {
            get { return _CurrencyID; }
            set { _CurrencyID = value; }
        }
        public double TransferAmount
        {
            get { return _TransferAmount; }
            set { _TransferAmount = value; }
        }
        public DateTime Date_Transaction
        {
            get { return _Date_Transaction; }
            set { _Date_Transaction = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public enMode Mode
        {
            get { return _eMode; }
            set { _eMode = value; }
        }
        private bool _SendTransfer()
        {
            this._TransactionID = clsDATransactions.AddNewTransaction(this._GetUniqueTransactionNumber(), this._SenderID,this._RecierverID,
            this._SourceBranchID,this._TargeteBranchID,this._Transaction_Status_ID,this.Transacion_type,this._FeeAmount,
            this._CurrencyID,this._TransferAmount,this._Date_Transaction,  this._isClientSender ,this._isClientRecierver, this._ClientRecierverID, this._ClientSenderID, this._Description);
            return (this._TransactionID != -1);
        }

        //private int 
        public static clsTransactions Find(int TransactionNumber )
        {
            int TransactionID = 0;
            int SenderID = 0;  int RecierverID = 0;int SourceBranchID = 0; int TargeteBranchID =0;
            int Transaction_Status_ID = 0;double FeeAmount = 0.0; int    CurrencyID = 0;
            double TransferAmount = 0.0; string Description = ""; DateTime Date_Transaction = DateTime.Now;
            bool isClientSender = false, isClientRecierver = false;
            int ClientSenderID = 0, ClientRecierverID = 0;
            int Transaction_type = 0;

            if (clsDATransactions.GetTransactionInfoByTransactionID(TransactionNumber, ref TransactionID, ref SenderID, ref RecierverID, ref SourceBranchID, ref TargeteBranchID,
                ref Transaction_Status_ID, ref Transaction_type, ref FeeAmount, ref CurrencyID, ref TransferAmount,ref Date_Transaction,ref isClientSender,ref isClientRecierver, ref ClientRecierverID,ref ClientSenderID, ref Description))
           {
                
                     
                return new clsTransactions(TransactionID, TransactionNumber,  SenderID,  RecierverID,  SourceBranchID,  TargeteBranchID,  
                                            Transaction_Status_ID,  TransferAmount,FeeAmount, CurrencyID, isClientRecierver, isClientSender, ClientRecierverID, ClientSenderID,  Description);
           }

            return null;
        }
        private bool _UpdateTransfer()
        {
            return clsDATransactions.UpdateTransaction(this.TransactionID,this._TransactionNumber, this._SenderID, this._RecierverID,
            this._SourceBranchID, this._TargeteBranchID, this._Transaction_Status_ID,this.Transacion_type, this._FeeAmount,
            this._CurrencyID, this._TransferAmount, this._Date_Transaction, this._isClientSender, this._isClientRecierver, this._ClientRecierverID, this._ClientSenderID, this._Description);
        }
        private bool _RemittanceTransfer()
        {
            return clsDATransactions.UpdateTransactionStatus(this.TransactionID,this.Transaction_Status_ID);
        }
        private bool _DeleteTransfer()
        {
            return clsDATransactions.DeleteTransaction(this.TransactionID);
        }
        public bool Save()
        {
           bool isSave = false;
            
            switch(_eMode)
            {
                    case enMode.Empty:
                    {
                        
                        break;
                    }

                    case enMode.eSendTransfer:
                    {
                        
                        isSave = _SendTransfer();

                        if (isSave)
                        {
                            AddNewFeeOfTransfer(this.FeeAmount);
                            _eMode = enMode.Update;
                        }

                        break;
                    }

                    case enMode.Update:
                    {
                        isSave = _UpdateTransfer();
                        break;  
                    }

                    case enMode.Delete:
                    {
                        isSave = _DeleteTransfer();
                        if (isSave)
                        {
                            _eMode = enMode.Update;
                        }
                        break;
                    } 
                    
                    case enMode.RemittanceTransfer:
                    {
                        isSave = _RemittanceTransfer();
                        if (isSave)
                        {
                            _eMode = enMode.Update;
                        }
                        break;
                    }


            }

            return isSave;
        }
        public static DataTable GetAllTransferData()
        {
            return clsDATransactions.GetAllTransactiones();
        }
        public static bool IsExistTransfer(int ID)
        {
            return clsDATransactions.IsTransactionExist(ID);
        }
        public static bool AddNewFeeOfTransfer(double FeeOfTransaction)
        {
            return clsBoxes.AddNewFee(clsGlobl.user.UserID,FeeOfTransaction);
        }



    }
}

