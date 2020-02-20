using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Entities;

namespace DataLayer.Services {

    public class JobsService : IDisposable, IJobsService {

        private  BadgerDataModel context;

        public JobsService(BadgerDataModel Context) {
            
            context = Context;
        }

        public bool Exist(int jobID) {

            bool result = false;
            if (context.Job.Any(c=> c.JobId == jobID))
            { result = true;}

            return result;
        }


        public PurchaseOrder GetJob(int jobNumber) {

            return context.PurchaseOrder.Where(c => c.OrderNum == jobNumber).FirstOrDefault();
        }

   
        public List<PurchaseOrder> GetJobOrders(int jobNumber) {

            return context.PurchaseOrder.Where(c => c.JobId == jobNumber).ToList();
        }

        public List<Job> GetJobs(string jobName) {

            return context.Job.Where(c => c.Jobname.StartsWith(jobName)).ToList();
        }



        public void Save() {

            context.SaveChanges();
        }

        public void Dispose() {

            context.Dispose();
        }

        public Job Find(int jobNumber) {

            return context.Job.Where(c => c.JobId == jobNumber).FirstOrDefault();
        }
    }
}
