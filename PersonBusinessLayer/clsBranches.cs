using DataAccessLayerr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace UsersBussncessLayerLib
{
    public class clsBranches
    {
        public enum enMode { eAdd = 1,eUpdate ,eDelete ,eEmpty }

        string _BranchName;
        int _BranchID;
        int _CityID;
        enMode _eMode;
        DateTime _date;
        double _BranchBalence;

        clsBranches ()
        {
            _BranchID = 0;
            _CityID = 0;
            _BranchName = string.Empty;
            _BranchBalence = 0.0;
            _date = DateTime.Now;

            _eMode = enMode.eAdd;

        }

        private clsBranches (enMode Mode, int branchID,int CityID,string BranchName,double BranchBalence,DateTime date)
        {
            this._BranchID = branchID;
            this._CityID = CityID;
            this._BranchName = _BranchName;
            this._BranchBalence = BranchBalence;
            this._date =date;
            this._eMode = Mode;
        }

        public int BranchID
        {
            get { return _BranchID; }
            set { _BranchID = value; }
        }
        
        public int CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }
        
        public string BranchName
        {
            get { return _BranchName; }
            set { _BranchName = value; }
        }
        
        public double BranchBalence
        {
            get { return _BranchBalence; }
            set { _BranchBalence = value; }
        }
        
        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }
        
        public static clsBranches Find(int branchID)
        {
            int BranchID = 0;
            int CityID = 0;
            string BranchName = string.Empty;
            double BranchBalence = 0.0;
            DateTime date = DateTime.Now;

            if(clsDABranches.GetBranchInfoByBranchID(branchID, ref CityID, ref BranchName, ref BranchBalence,ref date))
            {
                return new clsBranches(enMode.eUpdate,branchID, CityID, BranchName, BranchBalence, date);
            }

            return null;
        }

        private bool _Add()
        {
            this._BranchID = clsDABranches.AddNewBranch(this._CityID, this._BranchName, this.BranchBalence,this._date); 
            return (this._BranchID !=-1);
        }

        private bool _Update()
        {
            return clsDABranches.UpdateBranch(this._BranchID, this._CityID, this._BranchName, this.BranchBalence);
        }

        private bool _Delete ()
        {
            return clsDABranches.DeleteBranch(this._BranchID);

        }

        public bool Save ()
        {
            bool isSaved = false;
            
            switch(_eMode)
            {
                case enMode.eEmpty :
                    {
                        isSaved = false;
                        break;
                    }

                    case enMode.eDelete :
                    {
                        if (_Delete())
                        {
                            isSaved = true;
                        }
                        break;
                    }
                    case enMode.eUpdate :
                    {
                        if(_Update())
                        {
                            isSaved = true;
                        }
                        break;
                    }

                    case enMode.eAdd :
                    {
                        if (_Add())
                        {
                            _eMode = enMode.eUpdate;
                            isSaved = true;
                        }
                        break;
                    }

            }

            return isSaved;
        }

        public static bool IsExistBranch(int branchID)
        {
            return clsDABranches.IsBranchExist(branchID);
        }

        public static DataTable GetAllBranches()
        {
            return clsDABranches.GetAllBranches();
        }

    }
}
