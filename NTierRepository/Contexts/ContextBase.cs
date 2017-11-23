
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Text.RegularExpressions;
using NTierModel;

namespace NTierRepository.Models
{
    public class ContextBase : DbContext
    {
        public ContextBase(string Name)
            : base(Name)
        {

        }
        
        public DbSet<Project> Project { get; set; }
        

        
    }
}