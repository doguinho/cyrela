using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyrela.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpreendimentosController : ControllerBase
    {

        private readonly ILogger<EmpreendimentosController> _logger;

        public EmpreendimentosController(ILogger<EmpreendimentosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IList<Empreendimento> Get()
        {
            Empreendimento emp1 = new Empreendimento();
            emp1.id = 1;
            emp1.nome = "Sync";
            emp1.endereco = "Rua das Flores, 22";

            Empreendimento emp2 = new Empreendimento();
            emp2.id = 2;
            emp2.nome = "Elev";
            emp2.endereco = "Rua das Orquídeas, 200";

            Empreendimento emp3 = new Empreendimento();
            emp3.id = 2;
            emp3.nome = "Supreme";
            emp3.endereco = "Rua dos Jacintos, 100";

            List<Empreendimento> lista = new List<Empreendimento>();
            lista.Add(emp1);
            lista.Add(emp2);
            lista.Add(emp3);

            return new List<Empreendimento>(lista);
        }
    }

}
