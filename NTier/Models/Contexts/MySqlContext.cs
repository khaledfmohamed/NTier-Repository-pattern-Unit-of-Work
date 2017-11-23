namespace NTier.Models
{
    using System;
    using MySql.Data;
    using MySql.Data.Entity;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using NTier.Models.Base;
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public partial class MySqlContext : ContextBase
    {
        public MySqlContext()
            : base("name=MySqlModel")
        {
           
        }
       


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<MySqlContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<NTier.Models.Base.UserStoryBase> StoryBases { get; set; }
    }
}
