using AIGProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIGProject.Application.Interfaces.IRepository
{
    public interface IProductRepository
    {
        Product Find(int id);
        List<Product> GetAll();
        void Add(Product Product);
        void Update(Product Product);
        void Delete(int id);
    }
}
