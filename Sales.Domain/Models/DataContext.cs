namespace Sales.Domain.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        } 

        public DbSet<Sales.Common.Models.Product> Products { get; set; }
    }
}
