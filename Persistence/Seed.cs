using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.WebShops.Any()) return;
            
            var webshops = new List<WebShop>
            {
                new WebShop
                {
                    Name = "Webshop 1 google",
                    Description = "Webshop 1 google description",
                    UrlStore = "https://www.google.com",
                    headerImagePreview = "https://images.app.goo.gl/Fd7hYkRwgh31cJia7",
                    logoImagePreview = "https://images.app.goo.gl/8UYkzpH7KhpC7uQH7",
                    CreatedDate = DateTime.Now.ToUniversalTime(),
                    UpdatedDate = DateTime.Now.ToUniversalTime(),
                    CreatedBy = "Bob",
                    UpdatedBy =  "Bob"
                },
                new WebShop
                {
                    Name = "Webshop 2 microsoft",
                    Description = "Webshop 2 microsoft description",
                    UrlStore = "https://www.microsoft.com",
                    headerImagePreview = "https://images.app.goo.gl/MjK4sh2zpArE5x2t7",
                    logoImagePreview = "https://images.app.goo.gl/Jo3H3k333D64Rp9d7",
                    CreatedDate = DateTime.Now.ToUniversalTime(),
                    UpdatedDate = DateTime.Now.ToUniversalTime(),
                    CreatedBy = "Tom",
                    UpdatedBy =  "Tom"
                },
                new WebShop
                {
                    Name = "Webshop 3 github",
                    Description = "Webshop 2 github description",
                    UrlStore = "https://www.github.com",
                    headerImagePreview = "https://images.app.goo.gl/Zn6uNQqB2FiwshGt9",
                    logoImagePreview = "https://images.app.goo.gl/YBTgrwjNY4XdmgvKA",
                    CreatedDate = DateTime.Now.ToUniversalTime(),
                    UpdatedDate = DateTime.Now.ToUniversalTime(),
                    CreatedBy = "Bob",
                    UpdatedBy =  "Bob"
                },
                new WebShop
                {
                    Name = "Webshop 4 panaverse",
                    Description = "Webshop 4 panaverse description",
                    UrlStore = "https://www.panaverse.co",
                    headerImagePreview = "https://images.app.goo.gl/HweEzxTz6ExHnaC98",
                    logoImagePreview = "https://images.app.goo.gl/jYTeXCkAj5GZJ3ko7",
                    CreatedDate = DateTime.Now.ToUniversalTime(),
                    UpdatedDate = DateTime.Now.ToUniversalTime(),
                    CreatedBy = "Tom",
                    UpdatedBy =  "Tom"
                }                
        };

            await context.WebShops.AddRangeAsync(webshops);
            await context.SaveChangesAsync();
        }
    }
}