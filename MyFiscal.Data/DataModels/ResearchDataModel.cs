using MyFiscal.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFiscal.Data.DataModels
{
    public class ResearchDataModel
    {
        [Key]
        public int ResearchId { get; set; }
        [Required]
        public string Topic { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public LifeCategory LifeCategory { get; set; }


        //Foreign Keys
        public int? ProjectId { get; set; }
        public ProjectDataModel Project { get; set; }
        public int? IssueId { get; set; }
        public IssueDataModel Issue { get; set; }


        //Collections
        public ICollection<KnowledgeEntryDataModel> KnowledgeEntries { get; set; }

    }
}
