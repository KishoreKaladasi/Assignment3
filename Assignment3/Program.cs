using Assignment3Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Console.WriteLine("enter your product id:");
            p.ProductID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your product name:");
            p.ProductName = (Console.ReadLine());

            Console.WriteLine("enter your product quantity:");
            p.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your product price:");
            p.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************");

            Customer c = new Customer();
            Console.WriteLine("enter your customer id:");
            c.custId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your customer name:");
            c.custname = (Console.ReadLine());


            Orders o = new Orders();
            Console.WriteLine("enter your first order id:");
            o.OrderID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your first order date:");
            o.OrderDate = Convert.ToDateTime(Console.ReadLine());

            //Console.WriteLine("enter your second order id:");
            //o.OrderID = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter your second order date:");
            //o.OrderDate = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine("--------------------------------------------------");

            o.Addtocart(c.custId, c.custname, o.OrderDate, p.Quantity, p.Price);



            Console.WriteLine($"CustomerDetails: {c.custId},{c.custname}");
            Console.WriteLine($"ProductDetails:  {p.ProductID},{p.ProductName},{p.Quantity},{p.Price}");
            Console.WriteLine($"OrderDetails:    {o.OrderID},{o.OrderDate}");

            Console.ReadLine();
        }
    }
}
