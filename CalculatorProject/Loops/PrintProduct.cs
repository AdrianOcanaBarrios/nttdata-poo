using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops
{
    public class PrintProduct
    {
        public static List <Product> products = new List<Product>();
        

        public static void CreateListProduct() 
        {
            var potatoes = new Product
            {
                Id = 1,
                Name = "Patatas",
                Price = 24.56f
            };
            products.Add(potatoes);

            var oil = new Product();
            oil.Id = 2;
            oil.Name = "Aceite";
            oil.Price = 35.27f;
            products.Add(oil);

            var game = new Product();
            game.Id = 3;
            game.Name = "Juego";
            game.Price = 39.99f;
            products.Add(game);

            var shoes = new Product(4, "Zapatos", 20.99f);
           
            products.Add(shoes);

            System.Console.WriteLine(shoes.ToString());

        }
        public static List <Product> GetProductsGreaterThan30WithFor() 
        {
            List<Product> products2 = new List<Product>();
            for (int i=0;i<products.Count;i++) 
            {
                if (products[i].Price > 30) 
                {
                    products2.Add(products[i]);
                }
              
            }
            return products2;

        }

        public static List<Product> GetProductsGreaterThan30WithForEach() 
        {
            var products2 = new List<Product>();
            foreach (var product in products)
            {
                if (product.Price > 30)
                {
                    products2.Add(product);
                }
            }
            return products2;
        }
       /* public static List<Product> GetProductsGreaterThan30WithWhile() 
        {
            var products2 = new List<Product>();
            int n=1;
            while (n >=0) {

                if(products[n].Price > 30)
                {
                    products2.Add((Product)products[n]);
                }

                n--;
            

            }
            return products2;



        }*/
        /* public static List<Product> GetProductsGreaterThan30WithLinq()
         {
             IEnumerable<Product> filteringQuery =
             from producto in products
             where producto.Price > 30.00f
             select producto;

             return filteringQuery.ToList();
             
    }*/



    }
}
