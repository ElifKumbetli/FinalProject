using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


namespace ConsolUI
{

    //SOLID-->O
    //Open Closed Principle
    // Yaptığın koda yeni özellik ekliyorsan mevcut koduna dokunmazsın.
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine( product.ProductName);

            }
        }
    }
}