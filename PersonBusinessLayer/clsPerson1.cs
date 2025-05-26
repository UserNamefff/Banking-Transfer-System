using DataAccessLayerr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace UsersBussncessLayerLib
{
    public class clsPerson1
    {
        public enum enMode { eAdd = 1, eUpdate, eDelete,  eEmpty }

        private int _ID ;
        private string _FName;
        private string _LName;
        private string _MName;
        private string _Email;
        private string _PhoneNumber;
        private string _Gender;
        private int _Address;
        private int _CountryID;
        private DateTime _DateOfBirth;
        private string _ImagePath     ;

        enMode eMode;
        private clsPerson1(int ID, string FName, string LName, string MName, string PhoneNumber, string Email, 
            string Gender, int Address,int CountryID,DateTime DateOfBirth, string ImagePath)
        {
            this._ID = ID;
            this._FName = FName;
            this._LName = LName;
            this._MName = MName;
            this._Email = Email;
            this._PhoneNumber = PhoneNumber;
            this._Gender = Gender;
            this._Address = Address;
            this._ImagePath = ImagePath;
            this._DateOfBirth = DateOfBirth;
            this._CountryID = CountryID;
            eMode = enMode.eUpdate;
        }

        public clsPerson1()
        {
            this._ID = -1;
            this._FName = "";
            this._LName = "";
            this._MName = "";
            this._PhoneNumber = "";
            this._Email="";
            this._Gender = "";
            this._Address = 0;
            this._ImagePath = "";
            this._DateOfBirth = DateTime.Now;
            this._CountryID = 0;
            eMode = enMode.eAdd;
        }

        
        public int ID
        {
            get{return _ID;   }
            set { _ID = value;}
        }
        
        public string FName
        {
            set{ _FName = value; } get{return _FName; }
        }
        
        public string LName
        {
            set { _LName = value; }
            get { return _LName; }

        }
        
        public string MName
        {
            set { _MName = value; }
            get { return _MName; }
        }
        

        //the value of _Email will be null ;Email is null 
        //public string Email
        //{
        //    set{_Email = Email; }
        //    get { return _Email; }
        //} 
        
        public string Email
        {
            set{_Email = value; }
            get { return _Email; }
        }
        

        public string PhoneNumber
        {

            set { _PhoneNumber = value; }
            get { return _PhoneNumber; }

        }
        
        public string Gender
        {
            get { return this._Gender; }
            set { _Gender = value; }
        }

        public int Adrress 
        { 
            set { _Address = value; } 
            get { return _Address; }
        }
        public int  CountryID { set { _CountryID = value; } get { return _CountryID; } }
        public DateTime DateOfBirth { get{ return _DateOfBirth; } set { _DateOfBirth = value; } }
        public string ImagePath { 
            get{ return _ImagePath; } 
            set{ _ImagePath = value;  }
        }

        public bool Save()
        {

            switch (eMode)
            {
                case enMode.eAdd:
                {
                    if(_Add())
                    {
                         eMode = enMode.eUpdate;
                        return true;
                    }
                }
                      break;
                
                case enMode.eEmpty:
                {
                    return false;
                      break;
                }
                    
                case enMode.eUpdate:
                {
                    if(Update())
                    {
                       return true;

                    }
                        break;
                }

            }

            return false;
        }
        private bool _Add()
        {
            this._ID = clsDAPersons.AddNewPerson(this._FName, this._LName, this._Email, this._PhoneNumber, this._Address, this._DateOfBirth, this._CountryID, this._ImagePath,this._Gender);

            return this._ID != 0;
        }
        public bool Update()
        {
            //Updating data into database will be here ...
            return clsDAPersons.UpdatePerson(this._ID,this._FName,this._LName,this._Email,this._PhoneNumber,this._Address,this._DateOfBirth,this._CountryID,this._ImagePath,this.Gender);
        }
        public bool Delete()
        {
            //Deleting data from database will be here ...
            return clsDAPersons.DeletePerson(this._ID);
        }
        public DataTable GetAllPeople()
        {
            //Get All People data from db will be here
            return clsDAPersons.GetAllPersons();
        }
        public clsPerson1 Find(int PersonID)
        {
            int ID;
            string FName = "";
            string LName = "";
            
            string PhoneNumber = "";
            string Email = "";
            string Gender = "";
            int Address = 0; int CountryID= 0;
            DateTime DateOfBirth= DateTime.Now;
            string ImagePath = "";

            bool isFound = clsDAPersons.GetPersonInfoByID(PersonID, ref FName, ref LName, ref Email, ref PhoneNumber, ref Address, ref DateOfBirth, ref CountryID, ref ImagePath,ref Gender);

            if (isFound)
            {
                return new clsPerson1(PersonID,  FName,  LName,"",  Email, Gender,  PhoneNumber,  Address, CountryID,  DateOfBirth,  ImagePath);
            }
            return null;
        }
        public static clsPerson1 FindByID(int PersonID)
        {
            //Search person into database will be here ...
            string FirstName = "";
            string FName = "";
            string LName = "";

            string PhoneNumber = "";
            string Email = "";
            string Gender = "";
            int Address = 0; int CountryID = 0;
            DateTime DateOfBirth = DateTime.Now;
            string ImagePath = "";

            bool isFound = clsDAPersons.GetPersonInfoByID(PersonID , ref FirstName , ref LName, ref Email, ref PhoneNumber, ref Address, ref DateOfBirth, ref CountryID, ref ImagePath, ref Gender);

            if (isFound)
            {
                return new clsPerson1(PersonID, FirstName, LName, "", PhoneNumber, Email, Gender, Address, CountryID, DateOfBirth, ImagePath);
            }

            return null;
        } 
        public static clsPerson1 FindByFName(string  FisrtName)
        {
            //Search person into database will be here ...

            int PersonID = 0;
            string FName = "";
            string LName = "";

            string PhoneNumber = "";
            string Email = "";
            string Gender = "";
            int Address = 0 ; int CountryID = 0;
            DateTime DateOfBirth = DateTime.Now;
            string ImagePath = "";

            bool isFound = clsDAPersons.GetPersonInfoByID(FisrtName, ref PersonID , ref LName, ref Email, ref PhoneNumber, ref Address, ref DateOfBirth, ref CountryID, ref ImagePath,ref Gender);

            if (isFound)
            {
                return new clsPerson1(PersonID, FName, LName, "", Email, Gender, PhoneNumber, Address, CountryID, DateOfBirth, ImagePath);
            }

            return null;
        }

    }
}
