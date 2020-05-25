using MyFiscal.Domain.Enum;
using System;

namespace MyFiscal.Domain
{
    public class Todo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public LifeCategory LifeCategory { get; set; }
    }
}
