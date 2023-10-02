// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var item in productManager.GetProductDetails().Data)
    {
        Console.WriteLine(item.ProductName + "" + item.CategoryName);
    }
}
//CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
//foreach (var item in categoryManager.GetAll())
//{
//    Console.WriteLine(item.CategoryName);
//}