using MyFiscal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFiscal.Service.ResearchService
{
    public interface IResearchService
    {
        public IReadOnlyList<Research> GetResearchListing();
         public Research CreateResearch { get; set; }

    }
}
