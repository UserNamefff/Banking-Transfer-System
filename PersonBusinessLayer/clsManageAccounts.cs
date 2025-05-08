using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerr;
using UsersBussncessLayerLib;

namespace PersonBusinessLayer
{
    public class clsManageAccounts
    {



        public enum _enMode { EmptyMode = 0, UpdateMode = 1, AddedMode = 2,eDeleteMode };
        private int _ClientID;
        private int _PersonID;
        private string _AccountNumber;
        private string _Type_Account;
        private int _Account_TypeID;
        private string _PineCode;
        private clsCurrency _Currnecy;
        private int _CurrnecyID;
        private DateTime _Date;
        private int CreatedByUser;
        private double _Balence;
        private int _AccountID;

        _enMode _Mode;

        private clsManageAccounts(int ClientID, int AccountID, string AccountNumber, int Account_type, int CurrenryID, string PinCode, double Balence, int CreatedByUser, DateTime Created_Date)
        {
            this._Mode = _enMode.UpdateMode;
            this._ClientID = ClientID;
            this._Balence = Balence;
            this._PineCode = PineCode;
            this._Account_TypeID = Account_type;
            this._AccountID = AccountID;
            //this._PersonID = PersonID;

        }
        public clsManageAccounts()
        {
            this._Mode = _enMode.AddedMode;
            this._Balence = 0.0;
            this._PineCode = "";
            this._Type_Account = "";
            this._PersonID = 0;
            this._AccountID = 0;
            this._Date = DateTime.Now;

        }
         
        public clsManageAccounts(int AccountID)
        {
            this._Mode = _enMode.eDeleteMode;
            this._AccountID = AccountID;
        }

        // Property Read only   
        public string AccountNumber
        {
            get { return _AccountNumber; }

        }

        public double Balence
        {
            set { _Balence = Balence; }
            get { return _Balence; }
        }

        public string PineCode
        {
            get { return _PineCode; }
            set { _PineCode = PineCode; }
        }

        _enMode Mode
        {
            get { return _Mode; }
        }

        public bool IsEmpty()
        {
            return (_Mode == _enMode.EmptyMode);
        }


        //Fill Data Cliant from File and Call Function Print Data Of Client
    

        enum enSaveResulte { svFailedsaveResulte = 0, svSuccessfulSaveResult = 1, svAddedSuccussFully = 2 };

        private bool _AddNew()
        {

            this._ClientID = clsAccountsDataAccess.AddNewAccount(this._ClientID, this._AccountNumber, this._Account_TypeID, this._CurrnecyID,this.PineCode,this.Balence,this.CreatedByUser,this._Date);
            return (this._ClientID != -1);

        }
        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.EmptyMode:

                    { return false; }

                    break;

                case _enMode.UpdateMode:

                    if(Update())
                    {
                        return true;
                    }

                    break;

                case _enMode.AddedMode:
                  
                    if (_AddNew())
                    {
                            return true;
                    }
                       
                    
                    break;
            }
            return false;
        }

        public static bool IsExistCleint(string AccountNumber)
        {
            
            return (clsAccountsDataAccess.IsAccountExist(AccountNumber));
        }

        public static bool IsClientExist(int ID)
        {
            return clsAccountsDataAccess.IsAccountExist(ID);
        }

        private bool  Update()
        {
            //Updating data into database will be here ...
            return clsAccountsDataAccess.UpdateAccount(this._AccountID,this._ClientID, this._AccountNumber, this._Account_TypeID, this._CurrnecyID,this.PineCode, this._Balence, this.CreatedByUser, this._Date);
        }
        private bool Delete()
        {
            //Deleting data from database will be here ...
            return clsAccountsDataAccess.DeleteAccount(this._AccountID);
        }

        public static clsManageAccounts Find(string AccountNumber)
        {
           //string AccountNumber,
            int AccountID = 0;
            int ClientID = 0;
            int Account_type = 0;
            int CurrenryID = 0;
            double Balence = 0.0;
            int CreatedByUser = 0;
            string PinCode = "";
            DateTime Created_Date = DateTime.Now;

            //clsAccountsDataAccess.GetAccountInfoByAccountNumber(AccountNumber, ref AccountID,ref ClientID,ref Account_type,ref CurrenryID,ref Balence,ref CreatedByUser,ref Created_Date);  
            
            if (clsAccountsDataAccess.GetAccountInfoByAccountNumber(AccountNumber, ref AccountID, ref ClientID, ref Account_type, ref CurrenryID,ref PinCode, ref Balence, ref CreatedByUser, ref Created_Date))
            {
                return new clsManageAccounts(ClientID,   AccountID, AccountNumber, Account_type,  CurrenryID,PinCode,  Balence,  CreatedByUser,  Created_Date);
            }

            return null;
        }

        public static DataTable GetAllClients()
        {
            return clsAccountsDataAccess.GetAllAccounts();
        }

        public void AddNewClient(clsManageAccounts Client)
        {

        }

        public void Deposit(double Amount)
        {
            this._Balence += Amount;
            Save();
        }

        public bool WithDraw(double Amount)
        {
            if (Amount > this._Balence)
            {
                return false;
            }
            else
            {
                this._Balence -= Amount;
                this.Save();
                return true;
            }

        }



    }
}
