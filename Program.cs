
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Pomelo.EntityFrameworkCore.MySql;

namespace Hillel_Lesson16_HW;

class Programm
{
    static void Main(string[] args)
    {

        using (var ctx = new ApplicationContext())
        {
            //var shop = new Shop()
            //{
            //    Name = "Furniture",
            //};

            //ctx.Shops.Add(shop);

            //ctx.SaveChanges();

            //var Shops = ctx.Shops.ToList();

            //var shops = from s in ctx.Shops
            //            where s.Name == "Bakery"
            //            select s.Name
            //            ;
            //var lst = shops.ToList();
            //for (int i = 0; i < lst.Count; i++)
            //{
            //    Console.WriteLine(lst[i]);
            //}
            //Console.WriteLine(lst.ToString());


        };


        using (var ctx = new ApplicationContext())
        {
            //var shop = new Shop()
            //{
            //    Name = "Sport",
            //};

            //ctx.Shops.Add(shop);

            //ctx.SaveChanges();

            //var Shops = ctx.Shops.ToList();

            //var shops = from s in ctx.Shops
            //            where s.Name == "Bakery"
            //            select s.Name
            //            ;
            //var lst = shops.ToList();
            //for (int i = 0; i < lst.Count; i++)
            //{
            //    Console.WriteLine(lst[i]);
            //}
            //Console.WriteLine(lst.ToString());

            var product = new Product()
            {
                Name = "Tennis Rocket",
            };

            ctx.Products.Add(product);

            ctx.SaveChanges();

        };

        using (var ctx = new ApplicationContext())
        {

            var product = ctx.Products.FirstOrDefault(p => p.Name == "Tennis Rocket");
            if (product != null)
            {
                product.Name = "Football";
            }

            ctx.SaveChanges();
        }


        using (var ctx = new ApplicationContext())
        {

            var network = new Network()
            {
                Name = "Dnipro"
            };

            ctx.Networks.Add(network);

            ctx.SaveChanges();
        }




        Console.ReadKey();
    }
}