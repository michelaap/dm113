namespace ProductsEntityModel
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class ProductsModel : DbContext
    {
        // Your context has been configured to use a 'ProductsModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ProductsEntityModel.ProductsModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ProductsModel' 
        // connection string in the application configuration file.
        public ProductsModel()
            : base("name=ProductsModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public List<Stock> Stock { get; set; }
    }

    public class Stock
    {
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public DateTime LastUpdate { get; set; }
        public Product Product { get; set; }
    }

}