using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var existingProduct = _db.Products.FirstOrDefault(x => x.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Title = product.Title;
                existingProduct.Description = product.Description;
                existingProduct.CategoryId = product.CategoryId;
                existingProduct.ISBN = product.ISBN;
                existingProduct.Price = product.Price;
                existingProduct.Price50 = product.Price50;
                existingProduct.Price100 = product.Price100;
                existingProduct.ListPrice = product.ListPrice;
                existingProduct.Author = product.Author;
                existingProduct.CoverTypeId = product.CoverTypeId;
                if (product.ImageUrl != null)
                {
                    existingProduct.ImageUrl = product.ImageUrl;
                }
                //if (product.ImageUrl == null)
                //{
                //    product.ImageUrl = existingProduct.ImageUrl; // Retain existing ImageUrl value
                //}
                //_db.Entry(existingProduct).CurrentValues.SetValues(product);
            }
        }
    }
}
