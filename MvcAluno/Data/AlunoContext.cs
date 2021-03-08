using Microsoft.EntityFrameworkCore;
using MvcAluno.Models;

namespace MvcAluno.Data
{
    public class AlunoContext : DbContext
    {
        public AlunoContext (DbContextOptions<AlunoContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}