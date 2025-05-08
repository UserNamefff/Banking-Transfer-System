using DataAccessLayerr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersBussncessLayerLib;

namespace PersonBusinessLayer
{
    public class clsRegions
    {

        public enum enMode { eAddNew = 1, eUpdate, eSave, eEmpty }

        public clsCities City { get; set; }
        private string _NameRegion;
        private int _CityID;
        private int _RegionID;
        private enMode _Mode;



        public clsRegions()
        {
            this._NameRegion = "";
            this._CityID = -1;
            this._RegionID = -1;

            this._Mode = enMode.eAddNew;

        }

        private clsRegions(int RegionID, int _CityID, string NameRegion)
        {
            this._CityID = _CityID;
            this._NameRegion = NameRegion;
            this.RegionID = RegionID;

            Mode = enMode.eUpdate;
        }



        public string NameRegion
        {
            get { return _NameRegion; }
            set { _NameRegion = value; }
        }
        public int CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }
        public int RegionID
        {
            get { return _RegionID; }
            set { _RegionID = value; }
        }

        public enMode Mode
        {
            get { return _Mode; }
            set { _Mode = value; }


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
                    {    // This condation is to necessry valaidition exist _CityID 


                        if (_AddNewRegion())
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
            return clsDARegions.UpdateRegion(this._RegionID, this._CityID, this._NameRegion);

        }

        public bool _Delete()
        {
            //Deleting data from database will be here ...
            return clsDARegions.DeleteRegion(RegionID);
        }

        public bool _AddNewRegion()
        {
            //Add New Region and add its to database will be here ...
            this._RegionID = clsDARegions.AddNewRegion(this._CityID, this._NameRegion);
            return this._RegionID != -1;
        }

        public static DataTable GetAllRegions()
        {
            //Get All Regions will be here ..
            return clsDARegions.GetAllRegions();
        }

        public static clsRegions Find(int RegionID)
        {
            //int RegionId = RegionID;
            string RegionName = "";
            int CityID = 0;

            clsDARegions.GetRegionInfoByRegionID(RegionID, ref CityID, ref RegionName);
            return new clsRegions(RegionID, CityID, RegionName);
        }
        
        public static clsRegions Find(string RegionName)
        {
            int RegionID = -1;
            //string RegionName = "";
            int CityID = 0;

            clsDARegions.GetRegionInfoByRegionID(RegionID, ref CityID, ref RegionName);
            return new clsRegions(RegionID, CityID, RegionName);
        }

        public static bool IsExist(int RegionID)
        {
            return clsDARegions.IsRegionExist(RegionID);
        }


    }
}
