using DataAccessLayerr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace UsersBussncessLayerLib
{
    public class clsCurrency
    {
        
        public enum enMode { eAdd = 1 , eUpdate = 2 ,eDelete = 3 ,eEmpty = 4  }

        private enMode _eMode;
        public int CurrencyID { get; set; }
        private int _CountryID { get; set; }
        public string _CurrencyCode { get; set; }
        private string _CurrencyName { get; set; }
        private string _CountryName { get; set; }
        public double _Rate { get; set; }


        private clsCurrency(int CurrencyID, string CurrencyName, string currencyCode, double  rate, int countryID)
        {
            this.CurrencyID = CurrencyID;
            this._CurrencyCode = currencyCode;
            this._CurrencyName= CurrencyName;
            this._CountryID = countryID;
            this._Rate = rate;
            _eMode = enMode.eUpdate;


        }

        public clsCurrency()
        {
            this.CurrencyID = 0;
            this._CurrencyCode = "";
            this._CountryID = 0;
            this._Rate = 0.0;
            _eMode = enMode.eAdd;

        }
        
        public void Save()
        {
            //Saving data of currency into database will be here ...

            switch (_eMode)
            {
                    case enMode.eUpdate:
                        {
                            break;
                        }

                    case enMode.eAdd:
                    {
                        break;
                    }

                    case enMode.eDelete:
                    {
                        break;
                    }

                    case enMode.eEmpty:
                    {
                        break;
                    }

            }
        }

        private bool _Update()
        {
            //Updating data of currency into database will be here ...


            return clsDACurrencies.UpdateCurrency(this.CurrencyID, this._CurrencyCode, this._Rate,this._CurrencyName,this._CountryID);
        }

        public void Delete(int CurrencyID)
        {
            //Deleting data of currency from database will be here ...
        }

        public bool AddCurrency(clsCurrency currency)
        {
            return false;
        }

        public static clsCurrency FindCurrencyInfoByID(int CurrencyID)
        {
            // int    CurrencyID = 0;
             int    CountryID = 0;
             string CurrencyCode = "";
             string CurrencyName = "";
            double Rate = 0.0;
             

            if(clsDACurrencies.GetCurrencyInfoByID(CurrencyID,ref CurrencyName, ref CurrencyCode,ref Rate,ref CountryID))
            {
                return new clsCurrency(CurrencyID, CurrencyName, CurrencyCode,  Rate,  CountryID);
            }
            return null;
            
        }

        public static clsCurrency FindCurrencyInfoByName(string CurrencyName)
        {
             int    CurrencyID = 0;
            int CountryID = 0;
            string CurrencyCode = "";
            //string CurrencyName = "";
            double Rate = 0.0;


            if (clsDACurrencies.GetCurrencyInfoByName(CurrencyName, ref CurrencyCode, ref CurrencyID,  ref Rate, ref CountryID))
            {
                return new clsCurrency(CurrencyID, CurrencyName, CurrencyCode, Rate, CountryID);
            }
            return null;

        }


        public static clsCurrency FindByCurrencyCode (string Code)
        {
            int    CurrencyID = 0;
            int CountryID = 0;
            string CurrencyName = "";
            string CurrencyCode = "";
            double Rate = 0.0;


            if (clsDACurrencies.GetCurrencyInfoByCode(Code, ref CurrencyName, ref CurrencyID, ref Rate, ref CountryID))
            {
                return new clsCurrency(CurrencyID, CurrencyName, CurrencyCode, Rate, CountryID);
            }
            
            return null;
        }
        
        public static DataTable GetAllCurrencies()
        {
            return clsDACurrencies.GetAllCurrencies();
        }

    }
}
