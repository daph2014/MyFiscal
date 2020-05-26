using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis;
using MyFiscal.Service.ProjectService;

namespace MyFiscal.Web.Pages.Projects
{
    public class CreateModel : PageModel
    {
        private readonly IProjectService projectService;
        [BindProperty]
        public Domain.Project Project { get; set; }
        public CreateModel(IProjectService projectService)
        {
            this.projectService = projectService;
        }
        public void OnGet()
        {


        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await projectService.CreateProjectAsync(Project).ConfigureAwait(false);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

        
    }
}