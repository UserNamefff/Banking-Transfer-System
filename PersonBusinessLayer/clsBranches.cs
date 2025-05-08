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
        public int _BranchID { get; set; }
        int _RegionID;
        enMode _eMode;
        DateTime _date;
        double _BranchBalence;

        clsBranches ()
        {
            _BranchID = 0;
            _RegionID = 0;
            _BranchName = string.Empty;
            _BranchBalence = 0.0;
            _date = DateTime.Now;

            _eMode = enMode.eAdd;

        }

        private clsBranches (enMode Mode, int branchID,int RegionID,string BranchName,double BranchBalence,DateTime date)
        {
            this._BranchID = branchID;
            this._RegionID = RegionID;
            this._BranchName = BranchName;
            this._BranchBalence = BranchBalence;
            this._date =date;
            this._eMode = Mode;
        }

        public int BranchID
        {
            get { return _BranchID; }
           // set { _BranchID = value; }
        }
        
        public int RegionID
        {
            get { return _RegionID; }
            set { _RegionID = value; }
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
            int RegionID = 0;
            string BranchName = string.Empty;
            double BranchBalence = 0.0;
            DateTime date = DateTime.Now;

            if(clsDABranches.GetBranchInfoByBranchID(branchID, ref RegionID, ref BranchName, ref BranchBalence,ref date))
            {
                return new clsBranches(enMode.eUpdate,branchID, RegionID, BranchName, BranchBalence, date);
            }

            return null;
        }

        public static clsBranches Find(string branchName)
        {
            int BranchID = -1;
            int RegionID = 0;
            
            double BranchBalence = 0.0;
            DateTime date = DateTime.Now;

            if (clsDABranches.GetBranchInfoByBranchName(branchName, ref RegionID,ref BranchID  , ref BranchBalence, ref date))
            {
                return new clsBranches(enMode.eUpdate, BranchID, RegionID, branchName, BranchBalence, date);
            }

            return null;
        }



        private bool _Add()
        {
            this._BranchID = clsDABranches.AddNewBranch(this._RegionID, this._BranchName, this.BranchBalence,this._date); 
            return (this._BranchID !=-1);
        }

        private bool _Update()
        {
            return clsDABranches.UpdateBranch(this._BranchID, this._RegionID, this._BranchName, this.BranchBalence);
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
