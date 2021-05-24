using System;

namespace ClassMetotDemo
{
    class Program
    {
        
        
            static void Main(string[] args)
            {
                Product product1 = new Product();
                product1.ProductName = "Kalem";
                product1.ProductColor = "Beyaz";
                product1.ProductPrice = 1.5;

                Product product2 = new Product();
                product2.ProductName = "Silgi";
                product2.ProductColor = "Mor";
                product2.ProductPrice = 1;

                Product product3 = new Product();
                product3.ProductName = "Kurşun kalem";
                product3.ProductColor = "Turuncu";
                product3.ProductPrice = 2.5;

                Product[] malzemeler = new Product[] { product1, product2, product3 };


                foreach (var product in malzemeler)
                {
                    Console.WriteLine(product.ProductName + ":" + product.ProductColor + product.ProductPrice);
                }





            }
            class Product
            {
                public string ProductName { get; set; }
                public double ProductPrice { get; set; }
                public string ProductColor { get; set; }
            }
        }
    }


