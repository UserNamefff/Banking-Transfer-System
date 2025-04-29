using DataAccessLayerr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UsersBussncessLayerLib
{
    class clsUser  : clsPerson1
    {
       public enum enMode { EmptyMode = 0, UpdateMode = 1, AddMode = 3 };
        enMode _Mode;
        private int _UserID;
        private int _PersonID;
        string _UserName;
        string _Password;
        string _EncryptedPassword;
        int _Permissions;
		int _JobID;
		int _BranchID;
		bool _IsActive;
        bool _MarkDelete = false;

        public clsPerson1 Person;

        public  clsUser(string UserName , string Password,string FName,string LName, string MName, string PhonNumber , string Email,string Gender) : base(FName, LName, MName, PhonNumber, Email, Gender) 
        {
             
            // (int ID, string FName,  LName,  MName,  PhoneNumber ,  Email,  Gender)
            //this._ID +=1;
            this._UserName = UserName;
            this._Password = Password;
			this.Person = clsPerson1.FindByID(this._PersonID);
        }

        clsUser(enMode Mode, string FirstName, string LastName,string Email, string Phone, string Gender , string UserName, string Password,int Permissions) :
          base(FirstName, LastName, Email, Phone,Gender)

        {

            _Mode = Mode;
            _UserName = UserName;
            _Password = Password;
            _Permissions = Permissions;

        }

        public enum enMainMenuePermissions
        {
            eAll = -1, pListClients = 1, pAddNewClient = 2, pDeleteClient = 4,
            pUpdateClients = 8, pFindClient = 16, pTranactions = 32, pManageUsers = 64, pShowLogInRegister = 128
        };


        static stLoginRegisterRecord _ConvertLoginRegisterLineToRecord(stLoginRegisterRecord LoginRegisterRecord)
        {
            
            //vector<string> LoginRegisterDataLine = clsString.Split(Line, Seperator);
            //LoginRegisterRecord.DateTime = LoginRegisterDataLine[0];
            //LoginRegisterRecord.UserName = LoginRegisterDataLine[1];
            //LoginRegisterRecord.Password = clsUtil.DecryptText(LoginRegisterDataLine[2]);
            //LoginRegisterRecord.Permissions = stoi(LoginRegisterDataLine[3]);

            return LoginRegisterRecord;

        }

        static string EnctyptedPassword(string Password)
        {
			return "";//clsUtil.EncryptText(Password);
        }


	    public struct stLoginRegisterRecord
        {
            public string DateTime;
			public int UserID;		

        };

        public enMode Mode
        {
            get { return _Mode; }
			set { _Mode = value; }
        }
		public int UserID
        {
            get { return _UserID; }
			
        }
        public string UserName
        {
			set { _UserName = UserName; }
			get { return _UserName; }
        }

        public string Password
        {
			set { _Password = Password; }
			get { return _Password; }
        }

        public int Permissions
        {
			set { _Permissions = Permissions; }
			get { return _Permissions; }
        }

        public Boolean IsEmpty()
		{
			return (enMode.EmptyMode == _Mode);
		}

        private void _Add()
        {
			this._UserID = clsUsersAccessData.AddNewUser(this._UserID, this._PersonID,this.UserName, this._Password, this._Permissions, this._JobID, this._BranchID, this._IsActive);
        }

       
        public static clsUser GetAddNewUserObject(string UserName)
        {
            return new clsUser(enMode.AddMode, "", "", "", "","", UserName, "", 0);
        }


        public static bool IsUserExist(int UserId)
		{
			clsUser User = clsUser.FindByUserID(UserId);
			return (User.IsEmpty());
		}

        public enum enSaveResults { svFaildEmptyObject = 0, svSucceeded = 1, svFaildUserExists = 2 };
        public enSaveResults Save()
        {

            switch (_Mode)
            {
                case enMode.AddMode:
                    if (clsUser.IsUserExist(_UserID))
                    {
                        return enSaveResults.svFaildUserExists;
                    }
                    else
                    {
                        _Add();
                        _Mode = enMode.UpdateMode;
                        return enSaveResults.svSucceeded;

                    }
                    break;
                case enMode.EmptyMode:
                    if (IsEmpty())
                    {
                        return enSaveResults.svFaildEmptyObject;
                    }
					break;
                case enMode.UpdateMode:
                    Update();
                    return enSaveResults.svSucceeded;
					break;
            }

            return enSaveResults.svSucceeded;
        }

        void RegisterLogin()
        {
            //insert data of Loggedin user into RegisterLogin table in db 

        }

        private void _Update()
        {
            //Updating data into database will be here ...
        }

        private void _Delete()
        {
            //Deleting data from database will be here ...
        }


        public static clsUser FindByUserID(int UserId)
        {
			
            return null;
        }
		
		public static clsUser Find(string UserName,string Password)
        {
            return null;
        }

        public static List<clsUser> GetAllUsers()
        {
			// get all user from database will be here ..
            return new List<clsUser>();
        }

        public Boolean AddNewUsers(clsUser user)
        {

            return false;
        }

        public Boolean LogIn()
        {
            //  Log in will be here ..
            return false;
        }

        public Boolean Logout()
        {
          //  Log out will be here ..
            return false; 
        }

        public bool  CheckAccessPermission(enMainMenuePermissions Permission)
        {

            if (this.Permissions == (int)enMainMenuePermissions.eAll)
                return true;
            if (((int)Permission & this.Permissions) == (int)Permission)
                return true;
            else
                return false;
        }

       public static List<stLoginRegisterRecord> GetLoginRegisterList()
        {
            List<stLoginRegisterRecord> lLoginRegisterRecord = new List<stLoginRegisterRecord>();

            lLoginRegisterRecord.Add(new stLoginRegisterRecord());

            return lLoginRegisterRecord;
        }

    }
}

/*
 
#pragma once
#include<iostream>
#include "clsPerson.h";
#include"clsString.h"
#include"clsDate.h"
#include"clsUtil.h"
#include<vector>
#include<fstream>
using namespace std;
class clsUser:public clsPerson
{
private:
	enum enMode { EmptyMode = 0, UpdateMode = 1, AddMode = 3};
	enMode _Mode;
	string _UserName;
	string _Password;
	string _EncryptedPassword;
	int _Permissions;
	bool _MarkDelete = false;
	
	
	static  vector <clsUser> _LoadUsersDataFromFile()
	{

		vector <clsUser> vUsers;

		fstream MyFile;
		MyFile.open("Users.txt", ios.in);//read Mode

		if (MyFile.is_open())
		{

			string Line;


			while (getline(MyFile, Line))
			{

				clsUser User = _ConvertLinetoUserObject(Line);

				vUsers.push_back(User);
			}

			MyFile.close();

		}
		
		return vUsers;

	}
	static clsUser _ConvertLinetoUserObject(string Line, string Seperator = "#//#")
	{
		vector<string> vUserData;
		vUserData = clsString.Split(Line, Seperator);
		return clsUser(enMode.UpdateMode, vUserData[0], vUserData[1], vUserData[2],
			vUserData[3], vUserData[4], clsUtil.DecryptText(vUserData[5]), stoi(vUserData[6]));
	}
	static string _ConvertUserObjectToLine(clsUser User, string Seperator = "#//#")
	{

		string stUserRecord = "";
		stUserRecord += User.FirstName + Seperator;
		stUserRecord += User.LastName + Seperator;
		stUserRecord += User.Email + Seperator;
		stUserRecord += User.Phone + Seperator;
		stUserRecord += User.UserName + Seperator;
		stUserRecord += clsUtil.EncryptText(User.Password) + Seperator;
		stUserRecord += to_string(User.Permissions);

		return stUserRecord;

	}
	static void _SaveUsersDataToFile(vector<clsUser>vUsers) {
		fstream MyFile;
		MyFile.open("Users.txt", ios.out);
		string Line;
		while (MyFile.is_open()) {
			for (clsUser U : vUsers) {
				if (U._MarkDelete == false) {
					Line = _ConvertUserObjectToLine(U);
					MyFile << Line << endl;
				}
				
			}
			MyFile.close();
		}
		
	}
	void _AddDataLineToFile(string  stDataLine) {
		fstream MyFile;
		MyFile.open("Users.txt", ios.out | ios.app);
		if (MyFile.is_open()) {
			MyFile << stDataLine << endl;
			MyFile.close();
		}
	}



	static clsUser _GetEmptyUserObject()
	{
		return clsUser(enMode.EmptyMode, "", "", "", "", "", "", 0);
	}
	void _Update() {
		vector<clsUser>vUsers = _LoadUsersDataFromFile();
		for (clsUser& User : vUsers) {
			if (User.getUserName() == getUserName()) {
				User = *this;
				break;
			}
		}
		_SaveUsersDataToFile(vUsers);
	}
	void _Add() {
		_AddDataLineToFile(_ConvertUserObjectToLine(*this));

	}
	void _Delete() {
		fstream MyFile;
		MyFile.open("Users.txt", ios.out);
	}
	string _PrepareLoginRecord(string seperator="#//#") {
		string LoginRecord;
		LoginRecord += (clsDate.GetSystemDateTimeString()) + seperator;
		LoginRecord += (UserName) +seperator;
		LoginRecord += clsUtil.EncryptText(Password) + seperator;
		LoginRecord += to_string(Permissions);
		return LoginRecord;
	}
	
	struct stLoginRegisterRecord;

	static stLoginRegisterRecord _ConvertLoginRegisterLineToRecord(string Line, string Seperator = "#//#")
	{
		stLoginRegisterRecord LoginRegisterRecord;


		vector <string> LoginRegisterDataLine = clsString.Split(Line, Seperator);
		LoginRegisterRecord.DateTime = LoginRegisterDataLine[0];
		LoginRegisterRecord.UserName = LoginRegisterDataLine[1];
		LoginRegisterRecord.Password = clsUtil.DecryptText(LoginRegisterDataLine[2]);
		LoginRegisterRecord.Permissions = stoi(LoginRegisterDataLine[3]);

		return LoginRegisterRecord;

	}
	static string EnctyptedPassword(string Password)
	{
		return clsUtil.EncryptText(Password);
	}

public:
	struct stLoginRegisterRecord
	{
		string DateTime;
		string UserName;
		string Password;
		int Permissions;

	};

	clsUser(enMode Mode, string FirstName, string LastName,
		string Email, string Phone, string UserName, string Password,
		int Permissions) :
		clsPerson(FirstName, LastName, Email, Phone)

	{
		
		_Mode = Mode;
		_UserName = UserName;
		_Password = Password;
		_Permissions = Permissions;
	}
	enum enMainMenuePermissions {
		eAll = -1, pListClients = 1, pAddNewClient = 2, pDeleteClient = 4,
		pUpdateClients = 8, pFindClient = 16, pTranactions = 32, pManageUsers = 64, pShowLogInRegister = 128
	};

	void setMode(enMode Mode) {
		_Mode = Mode;
	}
	enMode getMode() {
		return _Mode;
	}
	void setUserName(string UserName) {
		_UserName = UserName;
	}
	string getUserName() {
		return _UserName;
	}
	__declspec(property(get = getUserName, put = setUserName)) string UserName;
	void setPassword(string Password) {
		_Password = Password;
	}
	string getPassword() {
		return _Password;
	}

	__declspec(property(get = getPassword, put = setPassword)) string Password;
	void setPermissions(int Permissions) {
		_Permissions = Permissions;
	}
	int getPermissions() {
		return _Permissions;
	}
	__declspec(property(get = getPermissions, put = setPermissions)) int Permissions;
	
	bool IsEmpty() {
		return (_Mode == enMode.EmptyMode);
	}
	static clsUser Find(string UserName) {
		fstream MyFile;
		MyFile.open("Users.txt", ios.in);//read Mode
		if (MyFile.is_open()) {
			string Line;
			while (getline(MyFile, Line)) {
				clsUser User = _ConvertLinetoUserObject(Line);
				if (UserName == User.getUserName()) {
					MyFile.close();
					return User;
				}
				

			}
			MyFile.close();
		}
		return _GetEmptyUserObject();
	}
	static clsUser Find(string UserName, string Password) {
		fstream MyFile;
		MyFile.open("Users.txt", ios.in);
		
		if (MyFile.is_open()) {
			string Line;
			while (getline(MyFile, Line)) {
				clsUser User = _ConvertLinetoUserObject(Line);
				
				if (UserName == User.UserName && Password == User.Password) {
					
					MyFile.close();
					return User;
				}
			}
			MyFile.close();
		}
		return _GetEmptyUserObject();
		
	}
	static bool IsUserExist(string UserName) {
		clsUser User1 = Find(UserName);
		return !(User1.IsEmpty());
	}


	bool CheckAccessPermission(enMainMenuePermissions Permission)
	{

		if (this->Permissions == enMainMenuePermissions.eAll)
			return true;
		if ((Permission & this->Permissions) == Permission)
			return true;
		else
			return false;
	}
	bool Delete() {
		vector <clsUser> _vUsers;
		_vUsers = _LoadUsersDataFromFile();

		for (clsUser& U : _vUsers)
		{
			if (U.UserName == _UserName)
			{
				U._MarkDelete = true;
				break;
			}

		}

		_SaveUsersDataToFile(_vUsers);

		*this = _GetEmptyUserObject();

		return true;


	}
	static vector<clsUser> getListUsers() {
		return _LoadUsersDataFromFile();
	}
	static clsUser GetAddNewUserObject(string UserName)
	{
		return clsUser(enMode.AddMode, "", "", "", "", UserName, "", 0);
	}
	



	enum enSaveResults { svFaildEmptyObject = 0, svSucceeded = 1, svFaildUserExists = 2 };
	enSaveResults Save() {
	
		switch (_Mode)
		{
		case enMode.AddMode:
			if (clsUser.IsUserExist(_UserName)) {
				return enSaveResults.svFaildUserExists;
			}
			else {
				_Add();
				_Mode = enMode.UpdateMode;
				return enSaveResults.svSucceeded;
				
			}
			break;
		case enMode.EmptyMode:
			if (IsEmpty()) {
				return enSaveResults.svFaildEmptyObject;
			}
		case enMode.UpdateMode:
			_Update();
			return enSaveResults.svSucceeded;
		}

	}
	void RegisterLogin() {
		fstream MyFile;
		string stDataLine = _PrepareLoginRecord();
		MyFile.open("LoginRegister.txt", ios.out | ios.app);
		if (MyFile.is_open()) {
			
			MyFile << stDataLine << endl;
			MyFile.close();
		}
	}
	
	static  vector <stLoginRegisterRecord> GetLoginRegisterList()
	{
		vector <stLoginRegisterRecord> vLoginRegisterRecord;
		fstream MyFile;
		MyFile.open("LoginRegister.txt", ios.in);//read Mode
		if (MyFile.is_open())
		{
			string Line;
			stLoginRegisterRecord LoginRegisterRecord;
			while (getline(MyFile, Line))
			{
				LoginRegisterRecord = _ConvertLoginRegisterLineToRecord(Line);
				vLoginRegisterRecord.push_back(LoginRegisterRecord);
			}
			MyFile.close();
		}
		return vLoginRegisterRecord;
	}

};


 
 */