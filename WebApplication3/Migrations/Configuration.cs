namespace WebApplication3.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication3.Data.WebApplication3Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication3.Data.WebApplication3Context";
        }

        protected override void Seed(WebApplication3.Data.WebApplication3Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var categories = new List<Category>()
            {
                new Category {Name = "China"},
                new Category {Name = "New Zealand"},
                new Category {Name = "Others"},
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var cities = new List<Cities>()
            {
                new Cities {Name = "Beijing",Description = "A good place", Price=2000,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Heilongjiang",Description = "A good place", Price=1000,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Jilin",Description = "A good place", Price=1100,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Liaoning",Description = "A good place", Price=1200,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Hebei",Description = "A good place", Price=1300,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Gansu",Description = "A good place", Price=1400,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Qinghai",Description = "A good place", Price=1500,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Shanxi1",Description = "A good place", Price=1600,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Henan",Description = "A good place", Price=1700,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Shandong",Description = "A good place", Price=1800,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Shanxi",Description = "A good place", Price=1900,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Anhui",Description = "A good place", Price=2100,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Hubei",Description = "A good place", Price=2200,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Hunan",Description = "A good place", Price=2300,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Jiangsu",Description = "A good place", Price=2400,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Sichuan",Description = "A good place", Price=2500,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Guizhou",Description = "A good place", Price=2600,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Yunnan",Description = "A good place", Price=2700,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Zhejiang",Description = "A good place", Price=2800,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Jiangxi",Description = "A good place", Price=2900,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Guangdong",Description = "A good place", Price=3000,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Fujian",Description = "A good place", Price=3100,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Taiwan",Description = "A good place", Price=3200,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Hainan",Description = "A good place", Price=3300,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Xinjiang",Description = "A good place", Price=3400,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Neimenggu",Description = "A good place", Price=3500,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Ningxia",Description = "A good place", Price=3600,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Guangxi",Description = "A good place", Price=3700,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Xizang",Description = "A good place", Price=3890,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Shanghai",Description = "A good place", Price=3900,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Tianjin",Description = "A good place", Price=4000,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Chongqing",Description = "A good place", Price=4100,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Xianggang",Description = "A good place", Price=4200,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "Aomen",Description = "A good place", Price=4300,CategoryID=categories.Single(c=>c.Name =="China").ID},
                new Cities {Name = "New Zealand",Description = "A good place", Price=4400,CategoryID=categories.Single(c=>c.Name =="New Zealand").ID},
            };
            cities.ForEach(c => context.Cities.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
