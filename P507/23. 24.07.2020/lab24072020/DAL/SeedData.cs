using lab24072020.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab24072020.DAL
{
    public class SeedData
    {
        static public void Initial(IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<SeedDbContext>();

                InitialAppDetail(db);
            }
        }

        private static void InitialAppDetail(SeedDbContext db)
        {
            if (!db.AppDetails.Any())
            {
                db.AppDetails.Add(new AppDetail
                {
                    Address = "210 Quadra Street Victoria, Canada",
                    Email = "example@mail.com",
                    PhoneNumber = "(+994) - 873 - 43 - 54"
                });

                db.SaveChanges();

            }
        }
    }
}
