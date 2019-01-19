using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqPlayground
{
    class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberInStock { get; set; } = 0;
        public override string ToString()
        => $"Name={Name}, Description={Description}, Number in Stock={NumberInStock}";

        public static List<ProductInfo> GetDemoData()
        {
            List<ProductInfo> products = new List<ProductInfo>()
            { 
                new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24},
                new ProductInfo{ Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},
                new ProductInfo{ Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},
                new ProductInfo{ Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},
                new ProductInfo{ Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100},
                new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!", NumberInStock = 73}
            };

            return products;
        }

        public static void RenderList(List<ProductInfo> products)
        {
            foreach(ProductInfo product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }

    }
}
