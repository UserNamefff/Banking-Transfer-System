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
    public class clsJobs
    {

        enum enMode
        {
           AddMode = 1,
              UpdateMode = 2,
              DeleteMode = 3,
                EmptyMode = 4
        }

        enMode eMode;

        public int JobID { set; get; }

        public string JobName { set; get; }
        
        public string JobDescription { set; get; }

        public clsJobs()
        {
            eMode = enMode.AddMode;
            JobID = 0;
            JobName = string.Empty;
            JobDescription = string.Empty;
        }

        private clsJobs(int jobID, string jobName, string jobDescription)
        {
            eMode = enMode.UpdateMode; // Assuming this is a mode for an existing job
            JobID = jobID;
            JobName = jobName;
            JobDescription = jobDescription;
        }

        public static clsJobs Find(int jobID)
        {
            // Simulate fetching a job from a database or other data source
            // In a real application, this would involve database access code

            string jobName = string.Empty;
            if (clsDAJobs.GetJobInfoByID(jobID, ref jobName))
            {
                string jobDescription = string.Empty;
                return new clsJobs(jobID, jobName, jobDescription);
            }
            else
            {
                return null; // Job not found

            }
        }

        public static clsJobs Find(string jobName)
        {
            // Simulate fetching a job by name from a database or other data source
            // In a real application, this would involve database access code
            int jobID = 0;
            string jobDescription = string.Empty;
            if (clsDAJobs.GetJobInfoByName(jobName, ref jobID, ref jobDescription))
            {
                return new clsJobs(jobID, jobName, jobDescription);
            }
            else
            {
                return null; // Job not found
            }
        }

        public bool _AddJob()
        {
            // Simulate adding a new job to a database or other data source
            // In a real application, this would involve database access code
            if (eMode == enMode.AddMode)
            {

                return clsDAJobs.AddNewJob(JobName, JobDescription); // Assume add is successful
            }
            return false; // If not in AddMode, return false
        }

        public bool _UpdateJob()
        {
            // Simulate updating an existing job in a database or other data source
            // In a real application, this would involve database access code
            if (eMode == enMode.UpdateMode)
            {
                return clsDAJobs.UpdateJob(JobID, JobName); // Assume update is successful
            }
            return false; // If not in UpdateMode, return false
        }
        public bool _Delete()
        {
           return  clsDAJobs.DeleteJob(JobID); // Assume delete is successful
        }

        public bool Save()
        {
            // Simulate saving the job to a database or other data source
            // In a real application, this would involve database access code
            if (eMode == enMode.AddMode)
            {
                
                return _AddJob(); // Assume save is successful
            }
            else if (eMode == enMode.UpdateMode)
            {
               
            }
            else if (eMode == enMode.DeleteMode)
            {
               
                return _Delete(); // Assume delete is successful
            }
            return false; // If none of the modes match, return false
        }

        public static DataTable GetAllJobs()
        {
            return clsDAJobs.GetAllJobs(); // Fetch all jobs from the data access layer
        }


    }
}
