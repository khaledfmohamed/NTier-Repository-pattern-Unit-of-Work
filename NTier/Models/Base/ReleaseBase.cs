using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTier.Models.Base
{
    [Table("releases")]
    public abstract class ReleaseBase
    {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Start { get; set; }
        public int IterationCount { get; set; }
        public List<IterationBase> Iterations { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        [Column("release_id")]
        public ProjectBase Project { get; set; }
    }
}