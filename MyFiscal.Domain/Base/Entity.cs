using System;
using System.Collections.Generic;
using System.Text;

namespace MyFiscal.Domain.Base
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
