using MyFiscal.Domain.Base;
using MyFiscal.Domain.Enum;


namespace MyFiscal.Domain
{
    public class Issue : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public LifeCategory LifeCategory { get; set; }
        public Project Project { get; set; }
    }
}
