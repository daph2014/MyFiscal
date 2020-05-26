using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFiscal.Service.ResearchService;

namespace MyFiscal.Web.Pages.Research
{
    public class IndexModel : PageModel
    {
     //   IEnumerable<Research> Researches;

        public IndexModel(IResearchService researchService)
        {
            ResearchService = researchService;
        }

        public IResearchService ResearchService { get; }

        public void OnGet()
        {

        }
    }
}