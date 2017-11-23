using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTier.Models.Base
{
    [Table("epics")]
    public abstract class EpicBase
    {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        [Column("project_id")]
        public ProjectBase Project { get; set; }
    }
}