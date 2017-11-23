using NTier.Models.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NTier.Models
{
    public class ContextBase : DbContext
    {
        public ContextBase(string Name)
            :base(Name)
        {

        }
        public DbSet<ProjectBase> Project { get; set; }
        public DbSet<ReleaseBase> release { get; set; }
        public DbSet<EpicBase> epic { get; set; }
        public DbSet<IterationBase> iteration { get; set; }

        // public DbSet<ScrumProject> Project { get; set; }
        // public DbSet<ScrumRelease> release { get; set; }
        // public DbSet<ScrumEpic> epic { get; set; }
        // public DbSet<ScrumIteration> iteration { get; set; }

    }
}