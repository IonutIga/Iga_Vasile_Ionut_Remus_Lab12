using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iga_Vasile_Ionut_Remus_Lab12.Models;

namespace Iga_Vasile_Ionut_Remus_Lab12.Data
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext (DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Iga_Vasile_Ionut_Remus_Lab12.Models.ShopList> ShopList { get; set; }
    }
}
