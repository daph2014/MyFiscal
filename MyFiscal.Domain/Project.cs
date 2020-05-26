using MyFiscal.Domain.Base;
using MyFiscal.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFiscal.Domain
{
    public class Project: Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? DateCompleted { get; set; }
        public LifeCategory LifeCategory { get; set; }
        public decimal PotentialRevenue { get; set; }
        public bool Completed { get; set; }
        public PaymentCycle RevenueCycle { get; set; }
        public bool IsPrivate { get; set; }
        public IReadOnlyList<Todo> ProjectTodos { get; set; }
        public IReadOnlyList<Research> ProjectResearchTopics { get; set; }

    }
}
