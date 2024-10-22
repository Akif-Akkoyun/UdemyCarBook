using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Persistence.Context
{
    public class CarBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;initial Catalog=UdemyCarBookDb;integrated Security=true;Trusted_Connection=True;TrustServerCertificate=true");
        }
        public DbSet<AboutEntity> AboutEntities { get; set; }
        public DbSet<BannerEntity> Banners{ get; set; }
        public DbSet<BrandEntity> Brands{ get; set; }
        public DbSet<CarEntity> Cars{ get; set; }
        public DbSet<CarDescription> CarDescriptions{ get; set; }
        public DbSet<CarFeatureEntity> CarFeatures{ get; set; }
        public DbSet<CarPricingEntity> CarPricings{ get; set; }
        public DbSet<CategoryEntity> Categories{ get; set; }
        public DbSet<ContactEntity> Contacts{ get; set; }
        public DbSet<FeatureEntity> FeatureEntities { get; set; }
        public DbSet<FooterAdressEntity> FooterAdresses { get; set; }
        public DbSet<LocationEntity> LocationEntities { get; set; }
        public DbSet<PricingEntity> Pricings { get; set; }
        public DbSet<ServicesEntity> Services { get; set; }
        public DbSet<SocialMediaEntity> SocialMedias { get; set; }
        public DbSet<TestimonialEntity> Testimonials { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<BlogEntity> Blogs { get; set; }
        public DbSet<TagCloudEntity> TagClouds { get; set; }
    }
}
