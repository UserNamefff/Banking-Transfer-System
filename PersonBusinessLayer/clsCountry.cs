using DataAccessLayerr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersBussncessLayerLib
{
    public class clsCountry
    {
        public enum _enMode { EmptyMode = 0, UpdateMode = 1, AddedMode = 2 };

        private int    _CountryID;
        private string _CountryName;
        private string _CountryCode;

        public _enMode _Mode;
        public clsCountry( )
        {
            this._CountryID = -1;
            this._CountryName = "";
            this._CountryCode = "";

            this._Mode = _enMode.AddedMode;
        }
        private clsCountry(_enMode Mode,int CountryID, string CountryName,string CountryCode)
        {
            
            this._CountryID = CountryID;
            this._CountryName = CountryName;
            this._CountryCode = CountryCode;

            this._Mode = Mode;
        }

        public int  CountryID 
        {
            get{ return _CountryID; }
            set{ _CountryID = value; } 
        }
        public string CountryName
        {
            get{ return _CountryName; }
            set{ _CountryName = value; } 
        }
        public string CountryCode 
        {
            get { return _CountryCode; }
            set { _CountryCode = value; }
        }

        public bool IsEmpty()
        {
            return (_Mode == _enMode.EmptyMode);
        }

        public enum enSaveResulte { svFailedsaveResulte = 0, svSuccessfulSaveResult = 1, svAddedSuccussFully = 2 };

        private bool _AddNew()
        {

            this._CountryID = clsCountryDataAccess.AddNewCountry(this._CountryCode, this._CountryName);
            return (this._CountryID != -1);

        }

        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.EmptyMode:
                    { 
                        break;
                    }

                case _enMode.UpdateMode:
                    {    
                        _Update();
                            return true;
                    }
                    
                case _enMode.AddedMode:
                    {    // This condation is to necessry valaidition exist _CountryID 


                        if (_AddNew())
                        {
                           
                            _Mode = _enMode.UpdateMode;
                            return true;
                        }
                        break;
                       
                }
            }
            return false;
        }

        public static bool IsExistCountry(int CountryID)
        {
            return clsCountryDataAccess.IsExistCountry(CountryID);
        }

        private bool _Update()
        {
            //Updating data into database will be here ...
            return clsCountryDataAccess.UpdateCountry(this._CountryID, this._CountryCode, this._CountryName);
        }

        public void Delete()
        {
            //Deleting data from database will be here ...
        }

        public static clsCountry Find(int CountryID)
        {
            _enMode Mode = _enMode.UpdateMode; 
            string CountryName = "";
            string CountryCode = "";
            bool isFount = clsCountryDataAccess.GetCountryByID(CountryID, ref CountryCode , ref CountryName);

            if (isFount)
            {
                return new clsCountry(_enMode.UpdateMode,CountryID,CountryCode,CountryName );
            }

            return null;
        }

        public static DataTable GetAllCountries()  
        {
            DataTable dt = clsCountryDataAccess.GetAllCountries();
            if(dt != null)
            {
                return dt;
            }

            return null;
        }



    }
}
