using MyFiscal.Domain.Base;
using MyFiscal.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFiscal.Domain
{
    public class Research : Entity
    {
        public string Topic { get; set; }
        public LifeCategory LifeCategory { get; set; }
        public IReadOnlyList<Knowledge> KnowledgeEntries { get; set; }
    }
}
