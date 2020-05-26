using MyFiscal.Domain;
using MyFiscal.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MyFiscal.Data.DataModels
{
    public class ProjectDataModel
    {
        public ProjectDataModel()
        {
            ProjectTodos = new List<TodoDataModel>();
            ProjectResearch = new List<ResearchDataModel>();
        }
        [Key]
        public int ProjectId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? DateCompleted { get; set; }
        public LifeCategory LifeCategory { get; set; }
        [Column(TypeName="Decimal(0,2)")]
        public decimal PotentialRevenue { get; set; }
        public bool Completed { get; set; }
        public PaymentCycle RevenueCycle { get; set; }
        public bool IsPrivate { get; set; }


        //List of ProjectTodos
        public ICollection<TodoDataModel> ProjectTodos { get; set; }
        public ICollection<ResearchDataModel> ProjectResearch { get; set; }


    }
}
