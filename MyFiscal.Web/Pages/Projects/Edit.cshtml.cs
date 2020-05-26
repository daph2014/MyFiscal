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
    public class EditModel : PageModel
    {
        private readonly IProjectService projectService;

        
        public EditModel(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        [BindProperty]
        public Domain.Project Project { get; set; }

        public async Task OnGetAsync(int id)
        {
            Project = await projectService.FindByIdAsync(id).ConfigureAwait(false);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                //var project = await projectService.FindByIdAsync(Project.Id).ConfigureAwait(false);
                //project.Name = Project.Name;
                //project.PotentialRevenue = Project.PotentialRevenue;
                //project.StartDate = Project.StartDate;

                await projectService.UpdateProjectAsync(Project).ConfigureAwait(false);
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage("Index");
            }
        } 
    }
}