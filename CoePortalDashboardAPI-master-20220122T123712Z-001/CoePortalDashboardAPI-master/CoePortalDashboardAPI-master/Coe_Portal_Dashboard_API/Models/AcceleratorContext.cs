using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;

namespace Coe_Portal_Dashboard_API.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class AcceleratorContext:DbContext
    {
        public AcceleratorContext():base("server=localhost;userid=root;password=admin@123;database=coeportal;persistsecurityinfo=True")
        {

        }
        public DbSet<Accelerator> accelerators { get; set; }
    }
}
