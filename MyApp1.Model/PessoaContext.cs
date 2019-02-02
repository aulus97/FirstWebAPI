using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MyApp1.Model
{
    public class PessoaContext: DbContext {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options) {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
