using MyFiscal.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFiscal.Domain
{
    public class Issue
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public LifeCategory LifeCategory { get; set; }
    }
}
