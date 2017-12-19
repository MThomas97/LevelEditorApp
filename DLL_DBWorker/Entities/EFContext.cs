using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DBWorker.Entities
{
    public class EFContext : DbContext
    {
        public DbSet<Texture> Textures { get; set; }
        public DbSet<Map> Maps { get; set; }
        
        public EFContext() : base("ConnString")
        {

        }
    }
}
