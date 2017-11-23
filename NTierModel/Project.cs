using NTierModel.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NTierModel
{
    [Table("projects")]
    public class Project 
    {
        [Key()]
        [Display(Name = "Id", ResourceType = typeof(Resource))]
        public int Id { get; set; }
        [Column("name")]
       
        [Display(Name = "Name", ResourceType = typeof(Resource))]
        [Required()]
        public string Name { get; set; }
        [Column("start")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true )]
        [Display(Name = "Start", ResourceType = typeof(Resource) )]
        public DateTime? Start { get; set; }

        [NotMapped]
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DateTypeFromString( DateFormate ="dd/mm/yyyy" , ErrorMessageResourceType =typeof(Resource),ErrorMessageResourceName = "DateValidateFormateMsg")]
        public string StartString
        {
            get
            {
                return Start.HasValue ? Start.Value.ToString("dd/MM/yyyy") : null;
            }
            set
            {
                try
                {

                    Start = DateTime.ParseExact(value, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    return;
                }

                
            }
            
        }


        [Column("release_count")]
        [Display(Name = "ReleaseCount", ResourceType = typeof(Resource))]
        public int? ReleaseCount { get; set; }
       
        [Column("description")]
        [Display(Name = "description", ResourceType = typeof(Resource))]
        public string Description { get; set; }
        [Column("notes")]
        [Display(Name = "notes", ResourceType = typeof(Resource))]
        public string Notes { get; set; }
        [Column("scrum_team_id")]
        [Display(Name = "ScrumTeam", ResourceType = typeof(Resource))]
        public int? ScrumTeamId { get ; set ; }
        [Column("Iteration_time_box")]
        [Display(Name = "IterationTimeBox", ResourceType = typeof(Resource))]
        public int? IterationTimeBox { get; set; }
        

       
    }
}