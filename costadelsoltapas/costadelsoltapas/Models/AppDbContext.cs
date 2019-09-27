using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace costadelsoltapas.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tapas> Tapas { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Classic", Description = "From the good ol' grandma's recipes book. This tapas continue to stand the test of time, just as granny does." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Fusion", Description = "From the chef's imagination to your table. The best combinations are sometimes the weidest. Dare to try?" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Gourmet", Description = "Carefully curated selection of Tapas for the more educated palate." });

            //seed pies

            modelBuilder.Entity<Tapas>().HasData(new Tapas
            {
                TapasId = 1,
                Name = "Tortilla de Patatas",
                Price = 5.95M,
                ShortDescription = "Simple yet delicious.",
                LongDescription = " The absolute classic. Found everywhere in Spain, it is not hard to see why this is an staple tapa in a culture where the quality of food is of upmost importance.",
                CategoryId = 1,
                ImageUrl = "https://lacocinadefrabisa.lavozdegalicia.es/wp-content/uploads/2019/05/tortilla-española.jpg",
                InStock = true,
                IsTapasOfTheWeek = false,
                ImageThumbnailUrl = "https://lacocinadefrabisa.lavozdegalicia.es/wp-content/uploads/2019/05/tortilla-española.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Tapas>().HasData(new Tapas
            {
                TapasId = 2,
                Name = "Croquetas del Dia",
                Price = 8.95M,
                ShortDescription = "Delicate confection, strong flavor!",
                LongDescription = "Bite sized croquettes filled with the best Jamon and gently fried in olive oil.",
                CategoryId = 1,
                ImageUrl = "http://www.importdelicia.com/contenido/noticias/600_img_36.jpg",
                InStock = true,
                IsTapasOfTheWeek = true,
                ImageThumbnailUrl = "http://www.importdelicia.com/contenido/noticias/600_img_36.jpg"

            });

            modelBuilder.Entity<Tapas>().HasData(new Tapas
            {
                TapasId = 3,
                Name = "Polbo a Feira",
                Price = 12.95M,
                ShortDescription = "Lets see what Paul the octopus has to say.",
                LongDescription = "Despite being originally from the northern regions of Spain, this traditional Galician octopus dish is a star of the spanish cuisine.",
                CategoryId = 1,
                ImageUrl = "http://porsolea.com/wp-content/uploads/2017/04/pulpo-a-la-gallega-2.jpg",
                InStock = true,
                IsTapasOfTheWeek = false,
                ImageThumbnailUrl = "http://porsolea.com/wp-content/uploads/2017/04/pulpo-a-la-gallega-2.jpg"

            });

            modelBuilder.Entity<Tapas>().HasData(new Tapas
            {
                TapasId = 4,
                Name = "Tostas Costa del Sol",
                Price = 20.95M,
                ShortDescription = "The most versatile tapas made with the best ingredients, all year long.",
                LongDescription = "Handmade bread, toasted and crowned with the best toppings choosed by the chef according with the current season.",
                CategoryId = 2,
                ImageUrl = "https://jamonesjuanpedrodomecq.com/wp-content/uploads/2019/05/Tapas-españolas.jpg",
                InStock = true,
                IsTapasOfTheWeek = true,
                ImageThumbnailUrl = "https://jamonesjuanpedrodomecq.com/wp-content/uploads/2019/05/Tapas-españolas.jpg"

            });

            modelBuilder.Entity<Tapas>().HasData(new Tapas
            {
                TapasId = 5,
                Name = "Jamon Iberico",
                Price = 20.95M,
                ShortDescription = "A tapa you will not forget.",
                LongDescription = "The best Jamon Iberico 100% Bellota carefully sliced and presented by an expert of the craft. The best of the best. The Ballon d'Or of the Tapas. ",
                CategoryId = 3,
                ImageUrl = "https://www.ibericosguillen.com/tienda/wp-content/uploads/2018/10/Jamon-iberico-bellota-50-Guillen-1-1.jpg",
                InStock = true,
                IsTapasOfTheWeek = true,
                ImageThumbnailUrl = "https://www.ibericosguillen.com/tienda/wp-content/uploads/2018/10/Jamon-iberico-bellota-50-Guillen-1-1.jpg"

            });
        }
    }
}
