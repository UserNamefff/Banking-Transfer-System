using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerr;
using static UsersBussncessLayerLib.clsCountry;
namespace UsersBussncessLayerLib
{
    public class clsCities
    {

       public enum enMode { eAddNew = 1, eUpdate ,eSave,eEmpty}

        public clsCountry Country { get; set; }
        private string _NameCity ;
        private int    _CountryID;
        private int    _CityID   ;
        private enMode _Mode ;



        public clsCities()
        {
            this._NameCity = "";
            this._CountryID = -1;
            this._CityID = -1;
            this._Mode = enMode.eAddNew;
            
        }

        private clsCities(int CityID,int _CountryID,string Namecity)
        {
            this._CountryID = _CountryID;
            this._NameCity = Namecity;
            this.CityID = CityID;
           
            Mode = enMode.eUpdate;
        }



        public string NameCity
        {
            get { return _NameCity; }
            set { _NameCity = value; }
        }
        public int CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }
        public int CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }

        public enMode Mode
        {
            get {  return _Mode;  }
            set {  _Mode = value; }


        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.eEmpty:
                    {
                        break;
                    }

                case enMode.eUpdate:
                    {
                        _Update();
                        return true;
                    }
                    //public enum enMode {  = 1, , eSave,  }
                case enMode.eAddNew:
                    {    // This condation is to necessry valaidition exist _CountryID 


                        if (_AddNewCity())
                        {

                            _Mode = enMode.eUpdate;
                            return true;
                        }
                        break;

                    }
            }
            return false;
        }

        public bool _Update()
        {
            //Updating data into database will be here ...
            return clsDACities.UpdateCity(this._CityID, this._CountryID, this._NameCity);
            
        }

        public bool _Delete()
        {
            //Deleting data from database will be here ...
            return clsDACities.DeleteCity(CityID);
        }

        public bool _AddNewCity()
        {   
            //Add New City and add its to database will be here ...
            this._CityID = clsDACities.AddNewCity(this._CountryID, this._NameCity);
            return this._CityID != -1;
        }
        
        public static DataTable GetAllCities()
        {
            //Get All Cities will be here ..
            return clsDACities.GetAllCities();
        }

        public static clsCities Find(int CityID)
        {
            //int CityId = CityID;
            string CityName = "";
            int CountryID = 0;
            
            clsDACities.GetCityInfoByCityID(CityID,ref CountryID ,ref CityName);
            return new clsCities(CityID,CountryID,CityName);
        }
        
        public static clsCities Find(string CityName )
        {
            int CityID = -1;
            //string CityName = "";
            int CountryID = 0;
            
            clsDACities.GetCityInfoByCityID(CityName, ref CountryID ,ref CityID );
            
            return new clsCities(CityID,CountryID,CityName);
        }

        public static bool IsExist(int CityID)
        {
            return clsDACities.IsCityExist(CityID);
        }



    }
}
