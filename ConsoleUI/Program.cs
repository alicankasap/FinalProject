using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            //productManager.Add(new Product { CategoryId = 1, ProductName = "T", UnitPrice = 1000, UnitsInStock = 1 });

            //foreach (var product in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //foreach (var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}

            //foreach (var product in productManager.GetProductDetails())
            //{
            //    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            //}

            //Console.WriteLine(categoryManager.GetById(1).CategoryName);

            var result = productManager.GetAll();

            if (result.Success)
            {
                foreach (var product in productManager.GetAll().Data)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine(result.Message);
        }
    }
}
