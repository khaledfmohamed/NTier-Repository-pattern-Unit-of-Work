using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTier.Models.Base
{
    [Table("projects")]
    public abstract class ProjectBase
    {
        [Key()]
        public int Id{get;set;}

        public string Name{ get;set;}

        public DateTime Start { get; set; }

        public int ReleaseCount { get; set; }

        public List<ReleaseBase> Releases { get; set; }

        public List<EpicBase> Epics { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    }
}