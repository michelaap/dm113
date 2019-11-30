namespace ProductsEntityModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductsEntityModel.ProductsModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductsEntityModel.ProductsModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(
                    p => p.Id,
                    new Product { Name = "Produto 01", Code = "0001", Price = 100 },
                    new Product { Name = "Produto 02", Code = "0002", Price = 150 },
                    new Product { Name = "Produto 03", Code = "0003", Price = 200 },
                    new Product { Name = "Produto 04", Code = "0004", Price = 250 }
                );

            context.SaveChanges();
            context.Stocks.AddOrUpdate(
                s => s.Id,
                new Stock
                {
                    Quantity = 1000,
                    LastUpdate = DateTime.Now,
                    Product = context.Products.FirstOrDefault(x => x.Code == "0001")
                },
                new Stock
                {
                    Quantity = 2000,
                    LastUpdate = DateTime.Now,
                    Product = context.Products.FirstOrDefault(x => x.Code == "0002")
                },
                new Stock
                {
                    Quantity = 3000,
                    LastUpdate = DateTime.Now,
                    Product = context.Products.FirstOrDefault(x => x.Code == "0003")
                },
                new Stock
                {
                    Quantity = 4000,
                    LastUpdate = DateTime.Now,
                    Product = context.Products.FirstOrDefault(x => x.Code == "0004")
                }
            );
        }
    }
}
