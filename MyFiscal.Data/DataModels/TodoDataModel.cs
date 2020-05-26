using MyFiscal.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFiscal.Data.DataModels
{
    public class TodoDataModel
    {
        [Key]
        public int TodoId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public DateTime DueDate { get; set; }
        public LifeCategory LifeCategory { get; set; }

        //Foreign Keys
        public int? ProjectId { get; set; }
        public ProjectDataModel Project { get; set; }

        public int? IssueId { get; set; }
        public IssueDataModel Issue { get; set; }
    }
}
