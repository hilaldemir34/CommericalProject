using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()//bellekte referans aldığında çalışacak
        {
            _products = new List<Product>
                {
                    new Product{ProductId=1,CategoryId=1,ProductName="bardak",UnitPrice=10,UnitsInStock=10},
                    new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=100,UnitsInStock=10},
                    new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1000,UnitsInStock=10},
                    new Product{ProductId=4,CategoryId=2,ProductName="PC",UnitPrice=10000,UnitsInStock=10}
                };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete=_products.SingleOrDefault(p=>p.ProductId==product.ProductId);
    
       
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

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitsInStock= product.UnitsInStock; 
            productToUpdate.UnitPrice = product.UnitPrice;  
            productToUpdate.CategoryId = product.CategoryId;    
        }
    }
}
