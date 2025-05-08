using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerr;

namespace UsersBussncessLayerLib
{
    public class clsNonClients
    {
        enum enMode { Add = 1, Update ,Delete }
        private int     _ID;
        private string _FullName;
        private string _PhoneNumber;
        private string _Gender;
        private enMode _eMode;
        public clsNonClients()
        {
            _eMode = enMode.Add;
            _ID = 0;
            _FullName = "";
            _PhoneNumber="";
            _Gender = "Male";
        }
        public clsNonClients(int iD, string fullName, string phoneNumber, string gender)
        {
            _ID = iD;
            _FullName = fullName;
            _PhoneNumber = phoneNumber;
            _Gender = gender;
        }
        public int ID { get => _ID; set => _ID = value; }
        public string FullName { get => _FullName; set => _FullName = value; }
        public string PhoneNumber { get { return _PhoneNumber; } set  { _PhoneNumber = value; } }
        public string Gender { get {return _Gender; } set { _Gender = value; } }
        private bool _AddNewClient()
        {
             this._ID = clsDANonClients.AddNewNonClient(this.FullName,this.PhoneNumber,this.Gender);
            return this._ID != -1;
        }
        private bool _Update()
        {
            return clsDANonClients.UpdateNonClient(this._ID, this._FullName, this.PhoneNumber, this.Gender);
        }
        private bool _Delete()
        {
            return clsDANonClients.DeleteNonClient(this._ID);
        }
        public static bool IsNonClientExist(int ID )
        {
            return clsDANonClients.IsNonClientExist(ID);
        }
        public bool Save()
        {
            switch(_eMode)
            {
                case enMode.Add:
                {
                    if (_AddNewClient())
                    {
                            _eMode = enMode.Update;
                        return true;
                    }
                        break;
                }     
                
                case enMode.Update:
                {
                    if( _Update())
                    {
                        return true;
                    }

                    break;
                }

                case enMode.Delete:
                {
                    if(_Delete())
                    {
                        return false;
                    }
                    break ;
                }


            }
            return false;
        }


    }
}
