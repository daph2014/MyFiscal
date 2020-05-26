using MyFiscal.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFiscal.Service.ProjectService
{
    public interface IProjectService
    {
        public Task<IReadOnlyList<Project>> GetAllProjectsAsync();
        public Task<bool> CreateProjectAsync(Project p);
        public Task<Project> FindByIdAsync(int Id);
        public Task<bool> UpdateProjectAsync(Project p);
        public Task<bool> RemoveProjectAsync(int id);
    }
}