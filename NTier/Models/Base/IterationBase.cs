using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTier.Models.Base
{
    [Table("iterations")]
    public abstract class IterationBase
    {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Start { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        [Column("release_id")]
        public ReleaseBase Release { get; set; }
        public List<UserStoryBase> Stories { get; set; }
    }
}