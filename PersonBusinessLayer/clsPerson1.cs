using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace UsersBussncessLayerLib
{
    public class clsPerson1
    {
        private int _ID;
        private string _FName;
        private string _LName;
        private string _MName;
        private string _Email;
        private string _PhoneNumber;
        private string _Gender;


        public clsPerson1(int ID, string FName, string LName, string MName, string PhoneNumber, string Email, string Gender)
        {
            this._ID = ID;
            this._FName = FName;
            this._LName = LName;
            this._MName = MName;
            this._Email = Email;
            this._PhoneNumber = PhoneNumber;
            this._Gender = Gender;
        }

        public clsPerson1( string FName, string LName, string MName, string PhoneNumber, string Email,string Gender)
        {
            //this._ID = ID;
            this._FName = FName;
            this._LName = LName;
            this._MName = MName;
            this._PhoneNumber = PhoneNumber;
            this._Email=Email;
            this._Gender = Gender;
        }

        public clsPerson1(string FName, string LName, string MName, string PhoneNumber, string Gender)
        {
            // this._ID = ID;
            this._FName = FName;
            this._LName = LName;
            this._MName = MName;

            this._PhoneNumber = PhoneNumber;
            this._Gender = Gender;
        }

        public clsPerson1(string FName, string LName, string PhoneNumber, string Gender)
        {
            // this._ID = ID;
            this._FName = FName;
            this._LName = LName;
            this._PhoneNumber = PhoneNumber;
            this._Gender = Gender;
        }

        public clsPerson1(string FName, string LName, string PhoneNumber)
        {
            //this._ID = ID;
            this._FName = FName;
            this._LName = LName;
            this._PhoneNumber = PhoneNumber;

        }

        public int ID
        {
            get { return this._ID; }
        }
        
        public string FName
        {
            get { return this._FName; }
            set { _FName = FName; }
        }
        
        public string LName
        {
            get { return this._LName; }
            set { _FName = LName; }

        }
        
        public string MName
        {
            get { return this._MName; }
            set { _MName = MName; }
        }
        
        public string Email
        {
            get { return this._Email; }
            set { _Email = Email; }
        }
        
        public string PhoneNumber
        {
            get { return this._PhoneNumber; }
            set { _PhoneNumber = PhoneNumber; }

        }
        
        public string Gender
        {
            get { return this._Gender; }
            set { _Gender = Gender; }
        }

        public void Save ()
        {
            //Saving data into database will be here ...
        }

        public void Update()
        {
            //Updating data into database will be here ...
        }

        public void Delete()
        {
            //Deleting data from database will be here ...
        }
        
        public List<clsPerson1> GetAllPeopleData()
        {
            //Get All People data from db will be here
            return null;
        }

        public clsPerson1 GetPerson()
        {
            return null;
        }

        public static clsPerson1 FindByID(int  id)
        {
            //Search person into database will be here ...
            return null;
        } 
        
        public clsPerson1 FindByFName(string  FisrtName)
        {
            //Search person into database will be here ...
            return null;
        }

        public clsPerson1 FindByFNameAndLastName(string  FisrtName,string LastName)
        {
            //Search person into database will be here ...
            return null;
        }
        
        public clsPerson1 FindByFNameAndEmail(string  FisrtName,string Email)
        {
            //Search person into database will be here ...
            return null;
        }

        

    }
}
