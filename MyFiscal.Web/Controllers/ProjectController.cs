using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFiscal.Service.ProjectService;

namespace MyFiscal.Web.Controllers
{
    [Route("api/project")]
    public class ProjectController : Controller
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Json(new { data = await projectService.GetAllProjectsAsync().ConfigureAwait(false) });
        }
    }
}
