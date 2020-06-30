using DataLayer.Entities;
using DataLayer.Interfaces;
using DataLayer.Models;
using DataLayer.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace DataLayerTest
{
    [TestClass]
    public class ResourceRepositoryTest
    {
        [TestMethod]
        public void FindDocument_Document_ShouldReturnDocument()
        {
            IDocumentRepository repo = new DocumentRepository(new BadgerDataModel());
            var result = repo.Find(21);

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void AddDocument_Document()
        {


            DocumentRepository docRepo = new DocumentRepository(new BadgerDataModel());

            // Create a new Document
            Document doc = new Document
            {
                Description = "New Resource",
                DateCreated = System.DateTime.Now,
                Creator = "Richard",
                PartID = 1,
                DocumentPath = ".png",
                DocumentView = "Front"

            };

            docRepo.Add(doc);
            int key = doc.DocId;
            var test = docRepo.Find(key);

            Assert.IsTrue(doc.DocId == key);
        }

        [TestMethod]
        public void DeleteDocument_Document_ShouldRemoveDocument()
        {

            IDocumentRepository repo = new DocumentRepository(new BadgerDataModel());

            // Create a new Document
            Document doc = new Document
            {
                Description = "New Resource",
                DateCreated = System.DateTime.Now,
                Creator = "Richard",
                PartID = 1,
                DocumentPath = ".png",
                DocumentView = "Front"

            };


            repo.Add(doc);
            var returnedDoc = repo.Find(doc.DocId);
            int key = returnedDoc.DocId;
            repo.Delete(returnedDoc);
            var test = repo.Find(key);
            Assert.IsTrue(test == null);
        }

        [TestMethod]
        public void GetAllDocuments_Document_ShouldReturnALlDocuments()
        {
            IDocumentRepository repo = new DocumentRepository(new BadgerDataModel());
            var test = repo.GetAll();
            Assert.IsTrue(test != null);
            Assert.IsTrue(test.Count > 0);
        }


        [TestMethod]
        public void SearchDocuments_Document_ShouldReturnSerachResults()
        {
            IDocumentRepository repo = new DocumentRepository(new BadgerDataModel());
            string searchTerm = "hinge";
            var test = repo.Search(searchTerm);
            Assert.IsTrue(test.Count == 230);
        }


    }

    [TestClass]
    public class PartRepositoryTest
    {
        [TestMethod]
        public void Add_Resource_To_Part()
        {
            IPartsService repo = new PartsService(new BadgerDataModel());
            PartDetailDTO part = new PartDetailDTO();

            part.UnitCost = 1.25m;
            part.ItemDescription = "Master Widjet 1023";
            part.ItemName = "MW-1023";
            part.PartNum = "MW-10034";
                   
            part.MarkUp = 1.25m;
            part.Waste = 2.0m;
            part.Weight = 12.25m;
            part.UID = 1;
            part.ManuId = 245;
            part.Location = "AC23";
            part.Obsolete = false;
            part.Sku = "1023847A990";
            
            ResourceDto resource = new ResourceDto
            {
                ResourceDescription = "Chipman Home Network",
                CurrentVersion = 1,
                Data = File.ReadAllBytes(@"C:\Users\Rich.DESIGNSYNTHESIS\Documents\chipmanHomeNetwork.sdr")
            };
            
            part.Resources.Add(resource);
            repo.InsertOrUpdate(part, "Richard Young");

            Assert.IsTrue(1 == 1);
        }

        [TestMethod]
        public void Add_Resource_Version()
        {
            ResourceService service = new ResourceService(new BadgerDataModel());

            Resource resource = service.Find(12);
            int ver = resource.CurrentVersion.GetValueOrDefault();

            byte[] Data = File.ReadAllBytes(@"C:\Users\Rich.DESIGNSYNTHESIS\Documents\DBDesign.docx");
            service.PushVersion(resource, Data, "Changed the corner radius", "Richard Young");
            var result = service.Find(12);

            Assert.IsTrue(result.CurrentVersion == ver + 1);
        }

        [TestMethod]
        public void Return_Deep_Part()
        {
            IPartsService repo = new PartsService(new BadgerDataModel());
            var part = repo.Find(1);

            Assert.IsTrue(part != null);
        }


    }

    [TestClass]
    public class InventoryRepositoryTest
    {
        [TestMethod]
        public void GetPartInventory_Part_ShouldReturnInventoryByPart()
        {
            IInventoryService repo = new InventoryService(new BadgerDataModel());
            var trans = repo.GetInventoryByPartID(4598);

            Assert.IsTrue(trans.Count == 14);
        }

        [TestMethod]
        public void PullPart_Part_ShouldReduceInventoryForPartByDecimalValue()
        {
            IInventoryService repo = new InventoryService(new BadgerDataModel());
            decimal start = repo.StockLevel(6975);
            repo.PullStock(6975, 1.0m, 8);
            decimal result = repo.StockLevel(6975);
            decimal test = result;
            Assert.IsTrue(start == (result + 1.00m));
        }

        [TestMethod]
        public void StockLevel_Inventory_ShouldReturnStockLevelOfPart()
        {
            IInventoryService repo = new InventoryService(new BadgerDataModel());

            var result = repo.StockLevel(6975);

            Assert.IsTrue(result == 21.0500m);
        }

        [TestMethod]
        public void SetStock_Inventory_ShouldSetInventoryLevelToTarget()
        {
            decimal ExpectedValue = 21.05m;
            IInventoryService repo = new InventoryService(new BadgerDataModel());
            repo.SetStock(6975, ExpectedValue, 8);
            var result = repo.StockLevel(6975);

            Assert.IsTrue(result == ExpectedValue);
        }

        [TestMethod]
        public void Push_Inventory_ShouldIncreaseInventoryLevel_AN_Amount()
        {
            decimal PushedValue = 1.0675m;

            IInventoryService repo = new InventoryService(new BadgerDataModel());

            var startingValue = repo.StockLevel(6975);
            repo.PushStock(6975, PushedValue, 8);
            var result = repo.StockLevel(6975);

            Assert.IsTrue(result == (startingValue + PushedValue));
        }

        [TestMethod]
        public void GetJobInventory_ReturnInventoryItemRelatedToJob()
        {
            IInventoryService repo = new InventoryService(new BadgerDataModel());
            JobsService jobRepo = new JobsService(new BadgerDataModel());
            // Retrieve the original Job object
            int JobNumber = 106;
            Job jobToTest = jobRepo.Find(JobNumber);
            var result = repo.GetJobInventory(jobToTest);



            Assert.IsTrue(result.Count == 1913);
        }
        /// <summary>
        /// Re
        /// </summary>
        [TestMethod]
        public void GetSupplierInventory_ReturnInventoryForSupplier()
        {
            IInventoryService repo = new InventoryService(new BadgerDataModel());
            var result = repo.GetSupplierInventory(new Supplier { SupplierId = 2244 });
            Assert.IsTrue(result.Count == 926);
        }



    }

    [TestClass]
    public class ProductionRepoTest
    {
        [TestMethod]
        public void Production_Assembly_ShouldReturnAllAssemblies()
        {
            IProductionRepository repo = new ProductionRepository(new BadgerDataModel());
            var result = repo.GetAssemblies();
            //---------------------------------     
            Assert.IsTrue(result.Count > 10);
        }

        [TestMethod]
        public void Production_Assembly_ShouldReturnJobAssemblies()
        {
            IProductionRepository repo = new ProductionRepository(new BadgerDataModel());
            var result = repo.GetJobAssemblies(1172);
            Assert.IsTrue(result.Count == 69);
        }

        [TestMethod]
        public void Production_SubAssembly_ShouldReturnSubAssembly()
        {
            IProductionRepository repo = new ProductionRepository(new BadgerDataModel());
            var result = repo.GetSubAssemblies(20);
            Assert.IsTrue(result.Count == 2);
        }

    }
    [TestClass]
    public class StockBillItemsTest
    {
        [TestMethod]
        public void StockBillItems_StockItem_ShouldReturnAssemblyStock()
        {
            IProductionRepository repo = new ProductionRepository(new BadgerDataModel());
            var result = repo.GetStockBillItems(64);
            Assert.IsTrue(result.Count == 1);
        }

    }

    [TestClass]
    public class OrdersRepoTesting
    {
        [TestMethod]
        public void Orders_OrderDTO_ShouldReturnOrderDTO()
        {
            IOrdersService repo = new OrdersService(new BadgerDataModel());
            var result = repo.GetOrderDTO(5000);

            Assert.IsTrue(result.PurchaseOrderID == 5000);
            Assert.IsTrue(result.SupplierName == "Alpine Glass & Door");
            Assert.IsTrue(result.SupplierID == 1905);
            Assert.IsTrue(result.Purchaser == "Richard Young");
            Assert.IsTrue(System.DateTime.Equals(result.OrderDate, System.DateTime.Parse("3/16/2005")));
            Assert.IsTrue(result.JobName == "Shores Elevator");
            Assert.IsTrue(result.JobID == 334);
            Assert.IsTrue(result.LineItems.Count == 12);

        }

        [TestMethod]
        public void Orders_OrderDTO_ShouldReturnBindingList()
        {
            IOrdersService repo = new OrdersService(new BadgerDataModel());
            var result = repo.GetOrderDTO(5000);

            Assert.IsTrue(result.PurchaseOrderID == 5000);
            Assert.IsTrue(result.SupplierName == "Alpine Glass & Door");
            Assert.IsTrue(result.SupplierID == 1905);
            Assert.IsTrue(result.Purchaser == "Richard Young");
            Assert.IsTrue(System.DateTime.Equals(result.OrderDate, System.DateTime.Parse("3/16/2005")));
            Assert.IsTrue(result.JobName == "Shores Elevator");
            Assert.IsTrue(result.JobID == 334);
            Assert.IsTrue(result.LineItems.Count == 12);

        }

        [TestMethod]
        public void Orders_OrdersFee_ShouldSaveNewOrderFee()
        {
            var ctx = new BadgerDataModel();
            OrderFee orderFee = new OrderFee();
            //orderFee.PurchaseOrderID = 23415;
            orderFee.FeeName = "Big Fat Fee";
            orderFee.Cost = 1.25m;
            orderFee.Qnty = 5.0m;
            orderFee.Extension = decimal.Add(orderFee.Cost.Value, orderFee.Qnty.Value);
            ctx.OrderFee.Add(orderFee);

            ctx.SaveChanges();
            Assert.IsTrue(orderFee.OrderfeeID != default);

        }


        [TestMethod]
        public void Resource_CreateNew_ReturnNewVersion()
        {
            //var ctx = new BadgerDataModel();
            //ResourceService _service = new ResourceService(ctx);
            //ResourceDto resourceDto = new ResourceDto();
            //resourceDto.Createdby = "richard";
            //resourceDto.ResourceDescription = "Can not be a meaningless garble";

            //ResourceVersionDto child = new ResourceVersionDto();

            //child.ModifiedBy = "richard";
            //child.ModDate = DateTime.Today;
            //child.RVersion = 1;


            

            //_service.CreateOrUpdateOrder(resourceDto);
            ////ctx.SaveChanges();
            //Assert.IsTrue(child.ResourceVersionID != default);

        }

        [TestMethod]
        public void Resource_Add_ResourceVersion()
        {
            var ctx = new BadgerDataModel();


            ResourceVersion _version = new ResourceVersion();

            _version.ResourceID = 5;
            _version.RVersion = 1;
            _version.VersionComment = "Revised for some reason";
            _version.ModifiedBy = "dick";
            _version.ModDate = DateTime.Today;

            ctx.ResourceVersion.Add(_version);

           
            ctx.SaveChanges();
            Assert.IsTrue(_version.ResourceVersionID != default);

        }
        [TestClass]
        public class JobRepo
        {


            [TestMethod]
            public void Get_All_Job_list()
            {
                var ctx = new BadgerDataModel();


                JobsService service = new JobsService(ctx);

                var jobs = service.All();
                Assert.IsTrue(jobs.Count > 100);

            }

        }

    }

}
