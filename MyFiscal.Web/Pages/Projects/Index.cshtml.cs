using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFiscal.Service.ProjectService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFiscal.Web.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly IProjectService projectService;

        public IndexModel(IProjectService projectService)
        {
            this.projectService = projectService;
        }
        public IReadOnlyList<Domain.Project> Projects { get; set; }
        public async Task OnGetAsync()
        {
            Projects = await projectService.GetAllProjectsAsync().ConfigureAwait(false);
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {

            await projectService.RemoveProjectAsync(id).ConfigureAwait(false);
            return RedirectToPage("Index");
        }
    }
}