using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer
{
    public class OrdersController:ApiController
    {
        Order[] orders = new Order[]
        {
            new Order{Id = 1 , Name = "Order 1" , Catagory ="A" , Price = 1500},
            new Order{Id = 2 ,Name = "Order 2" , Catagory = "B" , Price = 300},
            new Order{Id = 3 ,Name= "Order 3" , Catagory = "C", Price = 250}
        };

        [HttpGet]
        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }
    }

    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
{
            new Product{Id = 1 , Name = "Product 1" },
            new Product{Id = 2 ,Name = "Product 2" },
            new Product{Id = 3 ,Name= "Product 3" },
            new Product{Id = 4 ,Name= "Product 4" }
};

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
    }


    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Catagory { get; set; }
        public decimal Price { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
