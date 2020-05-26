using MyFiscal.Domain.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFiscal.Data.DataModels
{
    public class IssueDataModel
    {
        [Key]
        public int IssueId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public LifeCategory LifeCategory { get; set; }

        //List of IssueTodos
        public ICollection<TodoDataModel> IssueTodos { get; set; }
        public ICollection<ResearchDataModel> IssueResearch { get; set; }

    }

}
