using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTier.Models.Base
{
    [Table("stories")]
    public abstract class UserStoryBase
    {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        [Column("iteration_id")]
        public IterationBase Iteration { get; set; }
        [Column("release_id")]
        public ReleaseBase Release { get; set; }
    }
}
