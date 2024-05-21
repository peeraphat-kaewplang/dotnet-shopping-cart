using Microsoft.EntityFrameworkCore;
using test_shopping_cart.Models;

namespace test_shopping_cart.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Product { get; set; }
        public DbSet<StockInven> StockInven { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var seedPrd =new List<Product> {
                new Product { ProductId = Guid.Parse("3C9AF691-60EB-4F38-B2C5-D627FC1EABA0"), SkuCode = "S-00001" , SkuName ="ดินสอ" , CostPrice = 4.5},
                new Product { ProductId = Guid.Parse("EBD02B56-51BF-4B5B-9021-5365B15BD137"), SkuCode = "S-00002" , SkuName ="ปากกา" , CostPrice = 7},
                new Product { ProductId = Guid.Parse("A40A3223-40B1-47EB-A762-FCA7A0EC7566"), SkuCode = "S-00003" , SkuName ="ยางลบ" , CostPrice = 3},
                new Product { ProductId = Guid.Parse("F4C3FD26-F750-43F5-86B0-25F38408A9A3"), SkuCode = "S-00004" , SkuName ="ไม้บรรทัด" , CostPrice = 6},
                new Product { ProductId = Guid.Parse("62351332-8DB4-4930-B219-A6AF900EFB7E"), SkuCode = "S-00005" , SkuName ="น้ํายาลบคําผิด" , CostPrice = 12.5},
                new Product { ProductId = Guid.Parse("7AACF121-55CD-45EA-AFA7-B368B42DBDDC"), SkuCode = "S-00006" , SkuName ="กระดาษ a4 80 แกรม(500แผ่น)" , CostPrice = 70},
                new Product { ProductId = Guid.Parse("48CD0B38-108F-405F-835A-D0DEBA24A2C6"), SkuCode = "S-00007" , SkuName ="แม็กเย็บกระดาษ เบอร์ 35" , CostPrice = 40},
            };
            modelBuilder.Entity<Product>().HasData(seedPrd);

            var seedStock = new List<StockInven> {
                new StockInven() { Id = Guid.Parse("11CB271E-69BF-4653-AB83-42C42BBC84BC"), ProductId = Guid.Parse("3C9AF691-60EB-4F38-B2C5-D627FC1EABA0"), Amount = 10, UnitPrice = 10 ,IsAction = true,  CreatedDate = DateTime.Now },
                new StockInven() { Id = Guid.Parse("2945BE21-F977-4A4D-AFB1-8854547BADD3"), ProductId = Guid.Parse("EBD02B56-51BF-4B5B-9021-5365B15BD137"), Amount = 5, UnitPrice = 15 ,IsAction = true,  CreatedDate = DateTime.Now },
                new StockInven() { Id = Guid.Parse("98DF7A4F-7C1E-41CE-B82C-5AF4C6B7B39A"), ProductId = Guid.Parse("A40A3223-40B1-47EB-A762-FCA7A0EC7566"), Amount = 6, UnitPrice = 8 ,IsAction = true,  CreatedDate = DateTime.Now },
                new StockInven() { Id = Guid.Parse("AEC23AAF-6A1B-4254-B81E-4F826B1F2BAA"), ProductId = Guid.Parse("F4C3FD26-F750-43F5-86B0-25F38408A9A3"), Amount = 10, UnitPrice = 12 ,IsAction = true,  CreatedDate = DateTime.Now },
                new StockInven() { Id = Guid.Parse("9AB44D23-6E99-4751-8393-C945F59D1F66"), ProductId = Guid.Parse("62351332-8DB4-4930-B219-A6AF900EFB7E"), Amount = 20, UnitPrice = 25 ,IsAction = true,  CreatedDate = DateTime.Now },
                new StockInven() { Id = Guid.Parse("1DD8677A-8D3F-42B6-926C-91B256CDD81B"), ProductId = Guid.Parse("7AACF121-55CD-45EA-AFA7-B368B42DBDDC"), Amount = 11, UnitPrice = 125 ,IsAction = true,  CreatedDate = DateTime.Now },
                new StockInven() { Id = Guid.Parse("36F73EA1-019C-4CA1-862C-1A924D1C7000"), ProductId = Guid.Parse("48CD0B38-108F-405F-835A-D0DEBA24A2C6"), Amount = 9, UnitPrice = 89 ,IsAction = true,  CreatedDate = DateTime.Now },
            };

            modelBuilder.Entity<StockInven>().HasData(seedStock);
        }
    }
}