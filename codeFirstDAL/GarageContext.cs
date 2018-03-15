using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using codeFirstDTO;
using MySql.Data.Entity;
using System.Data.Entity;

namespace codeFirstDAL
{
    public class GarageContext : DbContext
{
    
        public DbSet<EntityHarley> Harleys { get; set; }
} 

}
