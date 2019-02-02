using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp1.Model;

namespace MyApp1.Controllers {
    [Route("api/[controller]")]
    [ApiController]

    public class PessoaController : ControllerBase {
        private readonly PessoaContext _context;

        public PessoaController(PessoaContext context) {
            _context = context;

            if(_context.Pessoas.Count() == 0) {
                _context.Pessoas.Add(new Pessoa { Nome = "P1" });
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public async Task <ActionResult <IEnumerable <Pessoa>>> GetPessoas()
        {
            return await _context.Pessoas.ToListAsync();
        }
    }
}