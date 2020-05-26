
using MyFiscal.Data;
using MyFiscal.Domain;
using System.Collections.Generic;
using System.Linq;

namespace MyFiscal.Service.ResearchService
{
    public class ResearchService : IResearchService
    {
        ApplicationDbContext _db;
        public ResearchService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Research CreateResearch { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IReadOnlyList<Research> GetResearchListing()
        {
            var researchList = _db.Research.ToList().Select(x=>new Research() { 
            Id = x.ResearchId,
            Topic = x.Topic,
            DateCreated = x.Created,
            DateUpdated = x.Updated
            });

            return researchList.ToList();
        }
    }
}
