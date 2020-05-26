using Microsoft.EntityFrameworkCore;
using MyFiscal.Data;
using MyFiscal.Data.DataModels;
using MyFiscal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFiscal.Service.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly ApplicationDbContext db;

        public ProjectService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async System.Threading.Tasks.Task<IReadOnlyList<Project>> GetAllProjectsAsync()
        {
            var projects = await db.Projects.Include(x => x.ProjectTodos).Include(x => x.ProjectResearch).Select(c => new Project()
            {
                Completed = c.Completed,
                DateCompleted = c.DateCompleted,
                Description = c.Description,
                Id = c.ProjectId,
                IsPrivate = c.IsPrivate,
                LifeCategory = c.LifeCategory,
                Name = c.Name,
                PotentialRevenue = c.PotentialRevenue,
                RevenueCycle = c.RevenueCycle,
                StartDate = c.StartDate,

                ProjectResearchTopics = c.ProjectResearch.Select(d => new Research()
                {
                    Id = d.ResearchId,
                    LifeCategory = d.LifeCategory,
                    Topic = d.Topic,
                    KnowledgeEntries = d.KnowledgeEntries.Select(z => new Knowledge()
                    {
                        Title = z.Title,
                        Description = z.Description,
                        LifeCategory = z.LifeCategory,
                        Reviewed = z.Reviewed,
                        Url = z.Url
                    }).ToList()

                }).ToList()

            }).ToListAsync();

            return projects;
        }

        public async System.Threading.Tasks.Task<bool> CreateProjectAsync(Project p)
        {
            var projectDao = new ProjectDataModel()
            {
                Completed = p.Completed,
                DateCompleted = p.DateCompleted,
                Description = p.Description,
                IsPrivate = p.IsPrivate,
                LifeCategory = p.LifeCategory,
                Name = p.Name,
                PotentialRevenue = p.PotentialRevenue,
                RevenueCycle = p.RevenueCycle,
                StartDate = p.StartDate

            };
            await db.Projects.AddAsync(projectDao);
            await db.SaveChangesAsync();  
            return true; //TODO check on this
            
        }
        public async System.Threading.Tasks.Task<bool> UpdateProjectAsync(Project p)
        {
            var projectDao = new ProjectDataModel()
            {
                ProjectId = p.Id,
                Completed = p.Completed,
                DateCompleted = p.DateCompleted,
                Description = p.Description,
                IsPrivate = p.IsPrivate,
                LifeCategory = p.LifeCategory,
                Name = p.Name,
                PotentialRevenue = p.PotentialRevenue,
                RevenueCycle = p.RevenueCycle,
                StartDate = p.StartDate
            };
            db.Projects.Update(projectDao);
            await db.SaveChangesAsync();
            return true; //TODO check on this

        }
        public async System.Threading.Tasks.Task<bool> RemoveProjectAsync(int id)
        {
            var project = await db.Projects.FindAsync(id);
            if(project == null)
            {
                throw new KeyNotFoundException("Project not found using Id " + id);
            }
            db.Projects.Remove(project);
            await db.SaveChangesAsync();
            return true; //TODO check on this

        }

        public async System.Threading.Tasks.Task<Project> FindByIdAsync(int Id)
        {
            var c = await db.Projects.FindAsync(Id);
            var project = new Project()
            {
                Completed = c.Completed,
                DateCompleted = c.DateCompleted,
                Description = c.Description,
                Id = c.ProjectId,
                IsPrivate = c.IsPrivate,
                LifeCategory = c.LifeCategory,
                Name = c.Name,
                PotentialRevenue = c.PotentialRevenue,
                RevenueCycle = c.RevenueCycle,
                StartDate = c.StartDate,

                ProjectResearchTopics = c.ProjectResearch.Select(d => new Research()
                {
                    Id = d.ResearchId,
                    LifeCategory = d.LifeCategory,
                    Topic = d.Topic,
                    KnowledgeEntries = d.KnowledgeEntries.Select(z => new Knowledge()
                    {
                        Title = z.Title,
                        Description = z.Description,
                        LifeCategory = z.LifeCategory,
                        Reviewed = z.Reviewed,
                        Url = z.Url
                    }).ToList()

                }).ToList()
            };
            return project;
        }
    }
}
