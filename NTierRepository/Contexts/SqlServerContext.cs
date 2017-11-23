namespace NTierRepository.Models
{
    using System;
    using System.Data.Entity;
    

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

       
    }
}
