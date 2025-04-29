using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersBussncessLayerLib
{
    class clsCities
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

        private clsCities(int _CountryID,string Namecity,int CountryID)
        {
            this._CountryID = _CountryID;
            this._NameCity = Namecity;
            this._CountryID = CountryID;
           
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

        public void Save()
        {
            //Saving data into database will be here ...
        }

        public void _Update()
        {
            //Updating data into database will be here ...
        }

        public void Delete()
        {
            //Deleting data from database will be here ...
        }

        public Boolean AddNewCity(string Namecity, int CountryID)
        {

            //Add New City and add its to database will be here ...
            return false;
        }
        
        public Boolean AddNewCity(int CityID,string Namecity, int CountryID)
        {
            //Add New City and add its to database will be here ...
            return false;
        }

        public clsCities GetAllCities()
        {
            //Get All Cities will be here ..
            return null;
        }

        public clsCities Find(string NameCity)
        {
            return null;
        }


        


    }
}
