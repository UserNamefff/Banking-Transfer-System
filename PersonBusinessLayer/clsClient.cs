using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerr;
using PersonBusinessLayer;
namespace UsersBussncessLayerLib
{
    public class clsClient 
    {
        enum enMode { eAdd=1,eUpdate,eDelete ,eEmpty}
        clsPerson1 ClientIfo ;
        private clsClient(int personID, int clientID, string clientType)
        {
            eMode = enMode.eUpdate;
            this.PersonID   = personID;
            this.ClientID   = clientID;
            this.ClientType = clientType;
        }
        public clsClient()
        {
            eMode = enMode.eAdd;
            this.PersonID = 0;
            this.ClientID = 0;
            this.ClientType = "";
            ClientIfo = new clsPerson1();
        }
        public int PersonID { get; set; }
        public int ClientID { get; set; }
        public string ClientType { get; set; }
        static enMode eMode { get; set; }
        public static clsClient Find(int ClientID)
        {
            int PersonID =0;
            //int ClientID = 0;
            string ClientType = "";

            bool isFound = clsDAClients.GetClientInfoByClientID(ClientID,ref PersonID,ref ClientType);

            if (isFound)
            {
                return new clsClient(PersonID, ClientID, ClientType);
            }
            eMode = enMode.eEmpty;
            return null;    
        }

        public static clsClient FindByPerosnID(int ClientID)
        {
            int PersonID = 0;
            //int ClientID = 0;
            string ClientType = "";

            bool isFound = clsDAClients.GetClientInfoByPersonID(PersonID , ref ClientID, ref ClientType);

            if (isFound)
            {
                return new clsClient(PersonID, ClientID, ClientType);
            }
            eMode = enMode.eEmpty;
            return null;
        }

        public static bool IsExistCleint(int ClientID)
        {
            return clsDAClients.IsClientExist(ClientID);
        }
        private bool _Update()
        {
            //Updating data into database will be here ...
            return clsDAClients.UpdateClient(this.ClientID,this.PersonID,this.ClientType);
        }
        public bool _Delete()
        {
            //Deleting data from database will be here ...

            return clsDAClients.DeleteClient(this.ClientID);
        }

        public bool DeleteByPersonID()
        {
            //Deleting data from database will be here ...

            return clsDAClients.DeleteClientByPersonID(this.ClientID);
        } 
        public static DataTable GetAllClients()
        {
            return clsDAClients.GetAllClients();
        }
        private bool _AddNew()
        {
            this.ClientID = clsDAClients.AddNewClient(this.PersonID,this.ClientType);
            return (this.ClientID != -1);
        }
        
        public string GetClientName()
        {
            ClientIfo = clsPerson1.FindByID(this.ClientID);
            if(ClientIfo !=null )
            {
                return ClientIfo.FName + " "+ClientIfo.LName;
            }
            return string.Empty;
        }
        public bool Save ()
        {
            switch (eMode)
            {
                case enMode.eUpdate:
                    {
                        if (_Update())
                        {
                            return true;
                        }
                        break;
                    }

                case enMode.eDelete:
                    {
                        if (_Delete())
                        {
                            return true;
                        }

                        break;
                    }

                case enMode.eAdd:
                    {
                        if (_AddNew())
                        {
                            eMode = enMode.eUpdate;
                            return true;
                        }

                        break;
                    }

                case enMode.eEmpty:
                    {
                        break;
                    }



            }
            return false;
        }

        


    }
}


