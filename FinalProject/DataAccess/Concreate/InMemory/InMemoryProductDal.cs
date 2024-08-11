using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.InMemory
{
   
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
           _products = new List<Product>(){
           new Product { CategoryId = 1, ProductId = 1, ProductName = "Bardak", UnitPrice = 500, UnitsInStock = 25 },
           new Product { CategoryId = 2, ProductId = 2, ProductName = "Kalem", UnitPrice = 1500, UnitsInStock = 125 },
           new Product { CategoryId = 2, ProductId = 3, ProductName = "Silgi", UnitPrice = 2500, UnitsInStock = 225 },
           new Product { CategoryId = 3, ProductId = 4, ProductName = "Telefon", UnitPrice = 3500, UnitsInStock = 325 },
           new Product { CategoryId = 3, ProductId = 5, ProductName = "Tv", UnitPrice = 4500, UnitsInStock = 425 },
          };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
           Product productToDelete=_products.SingleOrDefault(p=>p.ProductId== product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
          return _products.Where(p=>p.CategoryId==categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetatils()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate=_products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
