using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcAluno.Data;
using System;
using System.Linq;

namespace MvcAluno.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AlunoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AlunoContext>>()))
            {
                // Look for any movies.
                if (context.Alunos.Any())
                {
                    return;   // DB has been seeded
                }

                context.Alunos.AddRange(
                    new Aluno
                    {
                        Nome = "José das Couves",
                        Email = "josedascouves@hotmail.com",
                        Rg = "893456789"
                    },

                    new Aluno
                    {
                        Nome = "Maria da Silva",
                        Email = "mariasilva@hotmail.com",
                        Rg = "849613459"
                    },

                    new Aluno
                    {
                        Nome = "Denilson dos Santos",
                        Email = "denilsonsantos@hotmail.com",
                        Rg = "076539763"
                    },

                    new Aluno
                    {
                        Nome = "Renata Santos",
                        Email = "renatasantos@hotmail.com",
                        Rg = "123789065"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}