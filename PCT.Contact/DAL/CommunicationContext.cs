using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PCT.Contact.DAL
{
    public class CommunicationContext:DbContext
    {
        public CommunicationContext() : base("CommunicationContext") { }

        public DbSet<PCT.Contact.Models.Contact> Contacts { get; set; }
        public DbSet<PCT.Contact.Models.Enrollment> Enrollments { get; set; }
        public DbSet<PCT.Contact.Models.Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //由于类Contact和项目名称Contact重复，不得不写全称啊，以后注意。
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}