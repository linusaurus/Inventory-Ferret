﻿using System;
using System.Collections.Generic;
using DataLayer.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IPartsService
    {
        void Delete(Part part);
        void Dispose();
        bool Exist(int PartID);
        Part New();
        Part Add(Part part);
        Part Find(int PartID);
        Part FindBySKU(string sku);
        //List<Category> PartCategory();
        List<Part> GetAllParts();
        List<Part> GetSupplierParts(int supplierID);
        List<Part> GetManufacturerParts(int ManuID);
        List<UnitOfMeasure> Units();
        List<Manu> Manufacturers();
        string PartTypeName(int typeid);
        bool AssociateSKU(Part part,string sku);
        void InsertOrUpdate(PartDetailDTO partdto, string user);
        void AddResource(Document document, Part part);
        List<Part> SearchParts(string searchTerm, SearchOptions option);       
        void Save();

        List<PartListDto> PartsCategorieList(int Categoryid);

        List<PartListDto> PartsPartTypeList(int partypeid);

        List<PartCategory>  GetPartCategories();
    }
}


