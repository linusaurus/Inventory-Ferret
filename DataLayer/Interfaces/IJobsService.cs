using System.Collections.Generic;
//using BadgerData;
using DataLayer.Entities;

namespace DataLayer.Interfaces
{
    public interface IJobsService {
        void Dispose();
        bool Exist(int jobID);
        Job Find(int jobNumber);
        PurchaseOrder GetJob(int jobNumber);
        List<PurchaseOrder> GetJobOrders(int jobNumber);
        List<Job> GetJobs(string jobName);
        void Save();
    }
}