using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace DataLayer.Specifications
{
    public class IsResourceValid : ISpecification<ResourceDto>
    {
        public bool IsSatisfiedBy(ResourceDto entity)
        {
            return (entity.ResourceDescription.Length> 0 && entity.Data !=null && entity.Src.Length > 4);
        }
    }
}
