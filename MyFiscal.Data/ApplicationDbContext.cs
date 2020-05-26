using Microsoft.EntityFrameworkCore;
using MyFiscal.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFiscal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<ResearchDataModel> Research { get; set; }
        public DbSet<ProjectDataModel> Projects { get; set; }
        public DbSet<IssueDataModel> Issues { get; set; }
        public DbSet<TodoDataModel> Todos { get; set; }
        public DbSet<KnowledgeEntryDataModel> KnowledgeEntries { get; set; }
    }
}
