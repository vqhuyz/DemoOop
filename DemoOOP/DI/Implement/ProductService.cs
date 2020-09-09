using Dapper;
using DemoOOP.DI.Interface;
using DemoOOP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DemoOOP.DI.Implement
{
    public class ProductService : IProductService
    {

        DemoOopEntities db;
        public void Create(string Name, string Manufacture, string CreatedBy, bool Active, string Description)
        {
            using (db = new DemoOopEntities())
            {
                var product = new ProductModel();
                product.SetName(Name);
                product.SetDescription(Description);
                product.SetManufacture(Manufacture);
                product.SetCreatedBy(CreatedBy);
                product.SetActive(Active);

                db.Products.Add(new Product()
                {
                    CreatedAt = DateTime.Now,
                    Active = product.GetActive(),
                    Name = product.GetName(),
                    CreatedBy = product.GetCreatedBy(),
                    Description = product.GetDescription(),
                    Manufacture = product.GetManufacture(),
                });
                db.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (db = new DemoOopEntities())
            {
                var list = db.Products.ToList();
                return list;
            }
        }
    }
}