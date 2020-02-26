using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using DataLayer.Entities;
using DataLayer.Services;
using DataLayer.Interfaces;



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
                PartId = 1,
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
                PartId = 1,
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
        public void DeletePart_Part_ShouldRemovedPart()
        {
            //IPartsService repo = new PartsService(new BadgerDataModel());
            //var part = repo.New();
            //var test = repo.Add(part);
            //if(test.PartId != 0)
            //{
            //    repo.Delete(test);
            //}
            //var result = repo.Find(test.PartId);
           


            //Assert.IsTrue(test == null);
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
            decimal result= repo.StockLevel(6975);
            decimal test =  result;
            Assert.IsTrue(start == (result +  1.00m));
        }

        [TestMethod]
        public void StockLevel_Inventory_ShouldReturnStockLevelOfPart()
        {
            IInventoryService repo = new InventoryService(new BadgerDataModel());
            
            var result = repo.StockLevel(6975);

            Assert.IsTrue(result == 12.0m);
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

            

            Assert.IsTrue(result.Count == 1910);
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

}
