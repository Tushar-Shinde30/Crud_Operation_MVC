using Aarohi_Crud_Operation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Aarohi_Crud_Operation.Data
{
    public class CandidateDbContext:DbContext
    {

        public CandidateDbContext(DbContextOptions<CandidateDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Candidate> candidate { get; set; }

        
    }
}
