namespace NTierRepository.Models
{
    using System;
    using MySql.Data;
    using MySql.Data.Entity;
    using System.Data.Entity;
    
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

       
    }
}
