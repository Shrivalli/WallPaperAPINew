using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallPaperAPI
{
    public class Product
    {
        public string PID { get; set; }
        public string Pname { get; set; }
        public float Price { get; set; }

        public Product()
        {

        }
        public Product(string pid,string pname,float price)
        {
            PID = pid;
            Pname = pname;
            Price = price;
        }
        public static List<Product> getProducts()
        {
            List<Product> prds = new List<Product>();
            prds.Add(new Product("1", "Pen", 90));
            prds.Add(new Product("2", "Erasor", 60));
            prds.Add(new Product("3", "Pencil", 900));
            return prds;
        }
    }
}
