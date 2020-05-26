using MyFiscal.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFiscal.Data.DataModels
{
    public class KnowledgeEntryDataModel
    {

        [Key]
        public int KnowledgeEntryId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool Reviewed { get; set; }
        public LifeCategory LifeCategory { get; set; }

        //Foreign Keys
        public int ResearchId { get; set; }
        public ResearchDataModel Research { get; set; }

    }
}
