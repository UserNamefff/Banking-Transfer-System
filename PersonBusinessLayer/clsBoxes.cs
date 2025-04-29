using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerr;

namespace UsersBussncessLayerLib
{
    public class clsBoxes
    {

        public enum enMode { Add=1,Update,Delete }
        private int boxID;
        private int userID;
        private string boxName;
        private double boxBalence;
        private double revenues;
        private string BoxType;
        private DateTime date;

        public enMode eMode {  get; set; }
        public int BoxID         { get => boxID; set => boxID = value; }
        public int UserID        { get => userID; set => userID = value; }
        public string BoxName    { get => boxName; set => boxName = value; }
        public double BoxBalence { get => boxBalence; set => boxBalence = value; }
        public double Revenues   { get => revenues; set => revenues = value; }
        public string BoxType1   { get => BoxType; set => BoxType = value; }
        public DateTime Date     { get => date; }

        public clsBoxes()
        {
            BoxID = 0;
            UserID = 0;
            BoxName = "";
            BoxBalence = 0.0;
            Revenues = 0.0;
            BoxType1 = "";
            date =DateTime.Now;
        }

        public clsBoxes(int boxID, int userID, string boxName, double boxBalence, double revenues,
            string boxType, DateTime date)
        {
            this.BoxID      = boxID;
            this.UserID     = userID;
            this.BoxName    = boxName;
            this.BoxBalence = boxBalence;
            this.Revenues   = revenues;
            this.BoxType1    = boxType;
            this.date       = date;
            this.eMode          = enMode.Update;

        }


        public static int GetBoxId(int userID)
        {
            return (clsDABoxToUsers.GetIdOfUserBox(userID));
        }
        public static clsBoxes FindBox(int UserId)
        {
            int BoxId = GetBoxId(UserId);
            if (BoxId == 0) {

                return null;
            }

            string   BoxName = "";
            double   BoxBalence = 0.0;
            double   Revenues = 0.0;
            string   BoxType1 = "";
            DateTime Date= DateTime.Now;

            if ((clsDABoxToUsers.GetBoxInfoByBoxID(BoxId, UserId, ref BoxName, ref BoxBalence, ref Revenues, ref BoxType1, ref Date))) 
            {
                return new clsBoxes(BoxId, UserId, BoxName, BoxBalence, Revenues, BoxType1, Date);
            }

           return null;
        }
        static bool UpdateFee(int BoxID,double NewFee)
        {

            return clsDABoxToUsers.UpdateRevenuesField(BoxID, NewFee);
        }
        public static bool AddNewFee(int UserID,double FeeOfTransaction)
        {
            clsBoxes box = clsBoxes.FindBox(UserID);
            
            if (box != null)
            {
                box.revenues += FeeOfTransaction;
                
                if(UpdateFee(UserID, box.Revenues))
                {
                    return true;
                }

                
            }
            return false;
        }
        private bool _AddNewBoxToUser()
        {
            this.BoxID = clsDABoxToUsers.AddNewBox(UserID, BoxName, BoxBalence, Revenues, BoxType1, Date);
            return BoxID > -1 ;
        }
        private bool _UpdateBoxInfo()
        {
            return clsDABoxToUsers.UpdateBox(BoxID,UserID,BoxName,BoxBalence,Revenues, BoxType1);
        }
        private bool _DeleteBox()
        {
            return clsDABoxToUsers.DeleteBox(this.BoxID);
        }
        public static bool IsBoxExist(int BoxID)
        {
            return clsDABoxToUsers.IsBoxExist(BoxID);
        }
        public bool Save()
        {
            switch (eMode)
            {
                case enMode.Add:
                    {
                        if(IsBoxExist(this.BoxID))
                        {
                            _AddNewBoxToUser();
                            eMode = enMode.Update;
                            return true;
                        }
                        break;
                    }
                case enMode.Update:
                    {
                        if(_UpdateBoxInfo())
                        {
                            return true;
                        }

                        break;
                    }

                case enMode.Delete:
                    {
                       if(_DeleteBox())
                        {
                            return false;
                        }

                       break;
                    }

            }

            return false;
        }
        public static DataTable GetAllBoxes()
        {
            return clsDABoxToUsers.GetAllBoxesInfo();
        }


    }
}
