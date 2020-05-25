using MyFiscal.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFiscal.Domain
{
    public class Knowledge
    {
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool Reviewed { get; set; }
        public LifeCategory LifeCategory { get; set; }

    }
}
