using MyFiscal.Domain.Base;
using MyFiscal.Domain.Enum;
using System;

namespace MyFiscal.Domain
{
    public class Todo: Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public DateTime DueDate { get; set; }
        public LifeCategory LifeCategory { get; set; }
        
    }
}
