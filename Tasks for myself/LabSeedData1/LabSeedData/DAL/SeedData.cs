using LabSeedData.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabSeedData.DAL
{
    public class SeedData
    {
        static public void Initial(IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<SeedDataContext>();

                InitialAppdetail(db);
            }

        }

        private static void InitialAppdetail(SeedDataContext db)
        {
            if (!db.AppDetails.Any())
            {
                db.AppDetails.Add(new AppDetail {
                    Address = "210 Quadra Street Victoria, Canada",
                    Email = "example@mail.com",
                    Phone = "(+994) 873 43 54"
                });

                db.SaveChanges();
            }
        }
    }
}
