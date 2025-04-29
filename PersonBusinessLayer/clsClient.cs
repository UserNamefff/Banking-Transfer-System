using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerr;
namespace UsersBussncessLayerLib
{
    class clsClient : clsPerson1
    {
        private enum _enMode { EmptyMode = 0, UpdateMode = 1, AddedMode = 2 };
        private int         _ClientID;
        private string      _AccountNumber;
        private string      _Type_Account;
        private int      _Account_TypeID;
        private string      _PineCode;
        private clsCurrency _Currnecy;
        private int _CurrnecyID;
        private DateTime    _Date;
        private double       _Balence;

        _enMode _Mode;

        private clsClient(_enMode eMode, int ClientID, string PineCode, string Type_Account,double Balence, string FName, string LName, string PhoneNumber, string Gender) : base(FName, LName, PhoneNumber,  Gender)
        {
            this._Mode = eMode;
            this._ClientID = ClientID;
            this._Balence = Balence;
            this._PineCode = PineCode;
            this._Type_Account = Type_Account;
        }
        private clsClient(_enMode eMode, string PineCode, string Type_Account, double Balence, string FName, string LName, string PhoneNumber, string Gender) : base(FName, LName, PhoneNumber, Gender)
        {
            this._Mode = eMode;
            this._Balence = Balence;
            this._PineCode = PineCode;
            this._Type_Account = Type_Account;
        }

        // Property Read only   
        public string AccountNumber
        {
            get { return _AccountNumber; }

        }

        public double Balence
        {
            set{_Balence = Balence; }
            get{ return _Balence; }
        }

        public string PineCode
        {
            get { return _PineCode; }
            set { _PineCode = PineCode; }
        }

        _enMode Mode
        {
           get{ return _Mode; }
        }

        public bool IsEmpty()
        {
            return (_Mode == _enMode.EmptyMode);
        }


        //Fill Data Cliant from File and Call Function Print Data Of Client
        static clsClient _ConvertDataClientToObject(string Line)
        {
            //List<string> vDataClient = clsString::SplitString(Line);

            //return clsClient(_enMode::UpdateMode, vDataClient[0], vDataClient[1], vDataClient[2], vDataClient[3], vDataClient[4], vDataClient[5], stod(vDataClient[6]));
            return null;
        }

        private static clsClient _GetEmptyClientObject()
        {
            
            return new clsClient(_enMode.EmptyMode , "", "", 0.0, "", "", "", "");
            // clsClient(_enMode.EmptyMode, "", "", "", "");
            //return new clsClient(_enMode.EmptyMode, " ", " ", " ", " ", " ", " ", 0.0);
        }

        enum enSaveResulte { svFailedsaveResulte = 0, svSuccessfulSaveResult = 1, svAddedSuccussFully = 2 };

        private bool _AddNew()
        {

          //  clsClientsDataAccess.AddNewClient(this._ClientID, this._AccountNumber, this._Account_TypeID, this._CurrnecyID,this.Balence);
            return false;
            
        }
        enSaveResulte Save()
        {
            switch (_Mode)
            {
                case _enMode.EmptyMode:
                     
                      return enSaveResulte.svFailedsaveResulte;
                    
                    break;

                case _enMode.UpdateMode:

                    Update();

                    return enSaveResulte.svSuccessfulSaveResult;

                case _enMode.AddedMode:
                    // This condation is to necessry valaidition exist AccountNumber 
                    if (clsClient.IsExistCleint(_AccountNumber))
                    {
                        return enSaveResulte.svFailedsaveResulte;
                    }
                    else
                    {
                        _AddNew();
                        return enSaveResulte.svAddedSuccussFully;
                    }
                    break;
            }
             return enSaveResulte.svFailedsaveResulte;
        }

        public static Boolean IsExistCleint(string AccountNumber)
        {
            clsClient Client = Find(AccountNumber);

            return (!Client.IsEmpty());
        }

        public  void Update()
        {
            //Updating data into database will be here ...
        }

        public void Delete()
        {
            //Deleting data from database will be here ...
        }

        public static clsClient Find(string AccountNumber)
        {
            if (AccountNumber =="")
            {
                //return new clsClient(_enMode.EmptyMode, "","","","");
            }

            return null;
        }
        
        public static List<clsClient> GetAllClients()
        {   
            return new List<clsClient>();
        }

        public void AddNewClient(clsClient Client)
        {

        }

        void Deposit( double Amount)
        {
            this._Balence += Amount;
            Save();
        }

        bool WithDraw(double Amount)
        {
            if (Amount > this._Balence)
            {
                return false;
            }
            else
            {
                this._Balence -= Amount;
                this.Save();
                return true;
            }

        }


    }
}


/*
 
 #pragma once

#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>
#include "C:\Users\AL RAHAL\source\repos\ProjectOfStringLibrary\clsString.h"
#include "clsPerson.h"
#include "clsScreen.h"

//#include "C:\Users\AL RAHAL\source\repos\ProjectOfDateLibaray\clsDate.h"
//#include "C:\Users\AL RAHAL\source\repos\LibrarysOfCourse11_OOP\clsUtile.h"


using namespace std;

class clsBankClient : protected clsScreen , public clsPerson
{

    string _AccountNumber;
    string _PineCode;
    double _Balence;
    bool _MarkForDelete = false;

     string _PineCode;
    enum  _enMode { EmptyMode = 0 , UpdateMode = 1 , AddedMode = 2 };
    
    _enMode _Mode;
 
    //Fill Data Cliant from File and Call Function Print Data Of Client
    static clsBankClient  _ConvertDataClientToObject(string Line)
    {
        vector<string> vDataClient = clsString::SplitString(Line);

       
        return clsBankClient(_enMode::UpdateMode, vDataClient[0], vDataClient[1], vDataClient[2], vDataClient[3], vDataClient[4]
            , vDataClient[5], stod(vDataClient[6]));
    }

    static clsBankClient  _GetEmptyClientObject()
    {

        return clsBankClient(_enMode::EmptyMode, " ", " ", " ", " ", " ", " ", 0.0);
    }

    static vector<clsBankClient> _LoadandOpenFileAndReadTheLines(string FileName)
    {
        ifstream file;

        vector<clsBankClient> vstorageDataCliants;

        file.open(FileName);
        string ReadLine;

        if (file.is_open())
        {
            while (getline(file, ReadLine, '\n'))
            {
                clsBankClient Clients = _ConvertDataClientToObject(ReadLine);
                vstorageDataCliants.push_back(Clients);
            }

            file.close();
        }
        return vstorageDataCliants;

    }
    
    //Write Clients Data To File
    string  _ConvertClientsObjectToLine(clsBankClient  ClientsInfo, string Separet = "//")
        {
            return  ClientsInfo.FirstName +
                Separet + ClientsInfo.LastName +  
                Separet + ClientsInfo._AccountNumber +
                Separet + ClientsInfo._PineCode +               
                Separet + ClientsInfo.Email +
                Separet + ClientsInfo.Phone +
                Separet + to_string(ClientsInfo._Balence);
                
        }

    void _Update()
    {
        vector<clsBankClient> vClients = _LoadandOpenFileAndReadTheLines(CliensFile());

        for (clsBankClient& C : vClients)
        {
           
            if (C.AccountNumber()  == AccountNumber())
            {
                C = *this;
            }
        }
        _SaveDataClientInFile(vClients);
    }

    void _SaveDataClientInFile(vector<clsBankClient> vClients)
    {
        ofstream MyFile;

        MyFile.open(CliensFile());
        
        if (MyFile.is_open())
        {
            for (clsBankClient& C : vClients)
            {
                if (!C._MarkForDelete)
                {
                    MyFile << _ConvertClientsObjectToLine(C) << endl;
                }
               
            }
        }
        

    }

    void _AddNew()
    {
        _AddDataLineToFile(_ConvertClientsObjectToLine(*this));
    }

    void _AddDataLineToFile(string DataLine)
    {
        ofstream MyFile;
        MyFile.open(CliensFile(), ios::app);

        if (MyFile.is_open())
        {
           MyFile << DataLine << endl;
        }
    }
    



public :

    static const string CliensFile()
    {
        return "Clients.txt";
    }
        
   
    clsBankClient(_enMode Mode, string FirstName, string LastName, string AccountNumer , string PineCode
        , string Email, string PhoneNumber, double Balence)
        : clsPerson(FirstName, LastName, Email, PhoneNumber)

    {
        _Mode = Mode;
        _AccountNumber = AccountNumer;
        _PineCode = PineCode;
        _Balence = Balence;

    }

    // Property Read only   
    string AccountNumber() 
    {
        return _AccountNumber;
    }

     bool IsEmpty()
    {
        return (_Mode == _enMode::EmptyMode);
    }

    void SetAccountBalence(double Balence)
    {
        _Balence = Balence;
    }
      
    double GetBalence()
    {
        return _Balence;
    }

    __declspec(property(get = GetBalence, put = SetAccountBalence)) double Balence;

    void SetPineCode(string PineCode)
    {
        _PineCode = PineCode;
    }

     string PineCode()
    {
        return _PineCode;
    }




    _enMode Mode()
    {
        return _Mode;
    }
    
    static  clsBankClient Find(string AccountNumber, string Seperate = "//")
    {
        int PositionOfClient = 0;
        
        ifstream File;
        File .open(CliensFile());
        if (File.is_open()) 
        {
            string Line;
            while (getline(File,Line))
            {
                clsBankClient Client = _ConvertDataClientToObject(Line);

                if (Client.AccountNumber() == AccountNumber)
                {
                    File.close();
                    return Client;
                }
            
            
            }
            
        
        }

        return _GetEmptyClientObject();
    }

    static  clsBankClient Find(string AccountNumber, string PineCode , string Seperate = "//")
    {
        int PositionOfClient = 0;

        ifstream File;
        File.open(CliensFile());
        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                clsBankClient Client = _ConvertDataClientToObject(Line);
                if (Client.AccountNumber() == AccountNumber && Client._PineCode == PineCode)
                {
                    File.close();
                    return Client;
                }


            }


        }

        return _GetEmptyClientObject();
    }

    static bool ExistCleint(string AccountNumber)
    {
        clsBankClient Client = Find(AccountNumber);

        return (!Client.IsEmpty());
    }
    
    enum enSaveResulte { svFailedsaveResulte = 0  , svSuccessfulSaveResult = 1 , svAddedSuccussFully = 2 };
    
    enSaveResulte Save()
    {
        switch (_Mode)
        {
        case _enMode::EmptyMode :
            if (IsEmpty())
            {
                return enSaveResulte::svFailedsaveResulte;
            }
            
            break;

        case _enMode::UpdateMode :

            _Update();

            return enSaveResulte::svSuccessfulSaveResult;
        
        case _enMode::AddedMode:
            // This condation is to necessry valaidition exist AccountNumber 
            if (clsBankClient::ExistCleint(_AccountNumber))
            {
                return  enSaveResulte::svFailedsaveResulte;
            }
            else
            {
                _AddNew();
                return enSaveResulte::svAddedSuccussFully;
            }
            break;
        }

    }

    static clsBankClient GetAddNewClientObject(string AccountNumber)
    {
        return clsBankClient(_enMode::AddedMode, " ", " ", " ", AccountNumber, "", "", 0);
    }
   
    bool MarkForDelete()
    {
        return _MarkForDelete;
    }

    bool Delete()
    {
        vector<clsBankClient> vDataClients = _LoadandOpenFileAndReadTheLines(CliensFile());

        if (ExistCleint(_AccountNumber))
        {
            for (clsBankClient& C : vDataClients)
            {
                if (C.AccountNumber() == _AccountNumber)
                {
                    C._MarkForDelete = true;
                    break;
                }

            }

            _SaveDataClientInFile(vDataClients);
            *this = _GetEmptyClientObject();
            
            return IsEmpty();

        }
    }

    static vector <clsBankClient> GetClientsList()
    {
        return _LoadandOpenFileAndReadTheLines(CliensFile());
    }

    static double GetTotoalBalence() 
    {
        vector <clsBankClient> vClientsData = _LoadandOpenFileAndReadTheLines(CliensFile());
        double Balence = 0.0;
        for (clsBankClient& C : vClientsData)
        {
            Balence += C._Balence;
        }

        return Balence;
    }

    void Deposit(double Amount)
    {
        _Balence += Amount;
        Save();
    }

    bool WithDraw(double Amount)
    {
        if(Amount > _Balence)
        {
            return false;
        }
        else
        {
            _Balence -= Amount;
            Save();
            return true;
        }
       
    }

};

 
 */