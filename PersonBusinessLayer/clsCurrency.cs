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
        private int _CurrencyID; 
        private int _CountryID; 
        private string _CurrencyCode;
        private string _CountryName; 
        private double _Rate;

        
        private clsCurrency(int CurrencyID, string currencyCode, float rate, int countryID)
        {
            this._CurrencyID = CurrencyID;
            this._CurrencyCode = currencyCode;
            this._CountryID = countryID;
            this._Rate = rate;
            _eMode = enMode.eUpdate;


        }

        public clsCurrency()
        {
            this._CurrencyID = 0;
            this._CurrencyCode = "";
            this._CountryID = 0;
            this._Rate = 0.0;
            _eMode = enMode.eAdd;

        }
        public clsCurrency(string currencyCode, float rate, int countryID)
        {
            _eMode = enMode.eAdd;
            this._CurrencyCode = currencyCode;
            this._CountryID = countryID;
            this._Rate = rate;
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

            return false;
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

            return null;
        }



        public static clsCurrency FindByCurrencyCode (string Code)
        {
            return null;
        }
        
        public static DataTable GetAllCurrencies()
        {
            return clsDACurrencies.GetAllCurrencies();
        }

    }
}
