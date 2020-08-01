using EF_DB_First.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EF_DB_First.DAL
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class DatabaseContext : DbContext
    {


        public DatabaseContext()
            : base("name=MySQL")
        {
        }

        public virtual DbSet<nics_regulator> nics_regulator { get; set; }
        public virtual DbSet<nics_regulator_output> nics_regulator_output { get; set; }
        public virtual DbSet<nics_regulator_history> nics_regulator_history { get; set; }
        public virtual DbSet<nics_client> nics_client { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
