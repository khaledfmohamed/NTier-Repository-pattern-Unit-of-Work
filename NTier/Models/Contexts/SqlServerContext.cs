namespace NTier.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using NTier.Models.Base;

    public partial class SqlServerContext : ContextBase
    {
        public SqlServerContext()
            : base("name=SqlServerModel")
        {
           
        }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SqlServerContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<NTier.Models.Base.UserStoryBase> StoryBases { get; set; }
    }
}
