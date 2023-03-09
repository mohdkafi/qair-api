using QairService.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace QairService.DB
{
    public class QairDBContext : DbContext
    {
        public QairDBContext() : base()
        {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        DbSet<UserDTO> Users { get; set; }
        DbSet<QuestionDTO> Questions { get; set; }
        DbSet<QairDTO> Qairs { get; set; }
        DbSet<QairInstanceDTO> QairInstances { get; set; }
        DbSet<AnswerDTO> Answers { get; set; }
        DbSet<OptionDTO> Options { get; set; }
    }
}
