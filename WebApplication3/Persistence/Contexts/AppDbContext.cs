using Microsoft.EntityFrameworkCore;
using WebApplication3.Domain.Models;
namespace WebApplication3.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            builder.Entity<Category>().HasData
            (
                new Category { Id = 100, Name = "KADIN" }, // Id set manually due to in-memory provider
                new Category { Id = 101, Name = "KADIN BOT" },
                new Category { Id = 102, Name = "KADIN AYAKKABI" },
                new Category { Id = 103, Name = "KADIN LOAFER" },
                new Category { Id = 104, Name = "KADIN ÇİZME" },
                new Category { Id = 106, Name = "KADIN SNEAKERS" },
                new Category { Id = 107, Name = "KADIN SPOR" },
                new Category { Id = 108, Name = "KADIN BABET" },
                new Category { Id = 109, Name = "KADIN COMFORT" },
                new Category { Id = 110, Name = "ÇANTA" },
                new Category { Id = 111, Name = "ERKEK" },
                new Category { Id = 151, Name = "ERKEK BOT" },
                new Category { Id = 112, Name = "Üye OL" },
                new Category { Id = 113, Name = "Üye Girişi" },
                new Category { Id = 114, Name = "Sepetim " },
                new Category { Id = 115, Name = "Hakkımızda " },
                new Category { Id = 116, Name = "Gizlilik Güvenlik" },
                new Category { Id = 117, Name = "Hakkımızda " },
                new Category { Id = 118, Name = "Kullanım Şartları " },
                new Category { Id = 119, Name = "İletişim " },
                new Category { Id = 120, Name = "İptal Ve İADE Koşulları " },
                new Category { Id = 121, Name = "İşlem Rehberi " },
                new Category { Id = 122, Name = "Siparişlerim " },
                new Category { Id = 123, Name = "Alışveriş Sepetim " },
                new Category { Id = 124, Name = "Güvenli Alışveriş " }

            );

            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.QuantityInPackage).IsRequired();
            builder.Entity<Product>().Property(p => p.UnitOfMeasurement).IsRequired();
            builder.Entity<Product>().HasData
        (
         new Product
        {
            Id = 100,
             Name = "SIYAH KADIN AÇIK AYAKKABI L0501802165",
             QuantityInPackage = 1,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             Url = " C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/onizleme/siyah - kadin - acik - ayakkabi - l0501802165 - d30e.jpg",
             Fiyat = "163,90",
             Sepetfiyati = "112,12",
             Renk = "siyah",
             Onizlemeurl = "C:/ Users / Hüseyin / Desktop / bambistoree / WpfApp4 / images / onizleme / siyah - kadin - acik - ayakkabi - l0501802165 - 2dfa.jpg",
             CategoryId = 102

         },
         new Product
        {
            Id = 101,
             Name = "Pudra Kadin Ayakkabi l0503721009",
             QuantityInPackage = 2,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             Url = " C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/PudraKadinAyakkabil0503721009.jpg",
             Fiyat = "104,90 TL",
             Sepetfiyati = "83,92 TL",
             Renk = "pudra",
             Onizlemeurl = "C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/pudra-kadin-ayakkabi-l0503721009-2.jpg",
             CategoryId = 102
        },
         new Product
         {
             Id = 102,
             Name = "BLACK BAYAN BOT K0777009603",
             QuantityInPackage = 3,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             Url = " C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/BEYAZKADINSNEAKERSL0806100009.jpgg",
             Fiyat = "169 TL",
             Sepetfiyati = "140 TL",
             Renk = "beyaz",
             Onizlemeurl = "C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/beyaz-kadin-sneakers-l0806100009-7d25.jpg",
             CategoryId = 101
         },
         new Product
         {
             Id = 103,
             Name = "BLACK BAYAN BOT K0777009603",
             QuantityInPackage = 4,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             Url = " C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/black-bayan-bot-1.jpgg",
             Fiyat = "240 TL",
             Sepetfiyati = "200 TL",
             Renk = "siyah",
             Onizlemeurl = "C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/images/harley-davidson-black-bot-k0777009603-1694.jpg",
             CategoryId = 101
         },
         new Product
         {
             Id = 104,
             Name = "SUNDANCE BAYAN BOT K0111000101",
             QuantityInPackage = 5,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             Url = " C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/SUNDANCEBAYANBOTK0111000101",
             Fiyat = "577 TL",
             Sepetfiyati = "500 TL",
             Renk = "sundance",
             Onizlemeurl = "C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/caterpillar-sundance-bot-k0111000101-93ec.jpg",
             CategoryId = 101
         },
         new Product
         {
             Id = 105,
             Name = "CHOCOLATE BAYAN BOT K0111000101",
             QuantityInPackage = 6,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             Url = " C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/CHOCOLATEBAYANBOTK0111000101.jpgg",
             Fiyat = "447 TL",
             Sepetfiyati = "440 TL",
             Renk = "chocolate",
             Onizlemeurl = "C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/caterpillar-chocolate-bot-k0111000101-c329.jpg",
             CategoryId = 101
         },
         new Product
         {
             Id = 106,
             Name = "Örnek KADIN SNEAKERS",
             QuantityInPackage = 6,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             CategoryId = 106
         },
         
         new Product
         {
             Id = 109,
             Name = "BLACK BAYAN BOT K0777042303",
             QuantityInPackage = 7,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             Url = " C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/BLACKBAYANBOTK0777042303.jpgg",
             Fiyat = "180 TL",
             Sepetfiyati = "145 TL",
             Renk = "siyah",
             Onizlemeurl = "C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/black-kadin-bot-k0777042303-08d9.jpg",
             CategoryId = 101
         },
         new Product
         {
             Id = 110,
             Name = "SIYAH KADIN BOT K0528051003",
             QuantityInPackage = 8,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             Url = " C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/SIYAHKADINBOTK0528051003.jpg",
             Fiyat = "200 TL",
             Sepetfiyati = "100 TL",
             Renk = "siyah",
             Onizlemeurl = "C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/siyah-bot-k0528051003-6033.jpg",
             CategoryId = 101
         },
         new Product
          {
             Id = 111,
             Name = "BEYAZ KADIN BOT K0536410009",
             QuantityInPackage = 9,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             Url = " C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/BEYAZKADINBOTK0536410009.jpg",
             Fiyat = "75 TL",
             Sepetfiyati = "61 TL",
             Renk = "beyaz",
             Onizlemeurl = "C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/beyaz-bot-k0536410009-b0fd.jpg",
             CategoryId = 101
          },
         new Product
         {
             Id = 112,
             Name = "SIYAH KADIN ÇİZME K0721050509",
             QuantityInPackage = 10,
             UnitOfMeasurement = EUnitOfMeasurement.Unity,
             Url = " C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/siyah-cizme-k0721050509-4912.jpg",
             Fiyat = "133,90 TL",
             Sepetfiyati = "92,26 TL",
             Renk = "siyah",
             Onizlemeurl = "C:/Users/Hüseyin/Desktop/bambistoree/WpfApp4/images/siyah-cizme-k0721050509-f6f0.jpg",
             CategoryId = 104,
         } 
         );
        }
    }
}

