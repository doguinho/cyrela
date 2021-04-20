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
    public class EvolucaoObraController : ControllerBase
    {


        private readonly ILogger<EvolucaoObraController> _logger;

        public EvolucaoObraController(ILogger<EvolucaoObraController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IList<EvolucaoObra> Get()
        {
            EvolucaoObra evo1 = new EvolucaoObra();
            evo1.Date = new DateTime();
            evo1.Evolucao = 0.25;
            evo1.Foto = "https://exame.com/wp-content/uploads/2016/09/size_960_16_9_mrv-obras10.jpg";
            evo1.Summary = "Fundações";

            EvolucaoObra evo2 = new EvolucaoObra();
            evo2.Date = new DateTime().AddDays(5);
            evo2.Evolucao = 0.26;
            evo2.Foto = "https://londrix.com.br/wp-content/uploads/2020/09/MRV-obra-a.jpg";
            evo2.Summary = "Terceiro pavimento";

            EvolucaoObra evo3 = new EvolucaoObra();
            evo3.Date = new DateTime().AddDays(2);
            evo3.Evolucao = 0.27;
            evo3.Foto = "https://tc.com.br/wp-content/uploads/2019/11/mrv.jpg";
            evo3.Summary = "Segundo pavimento";

            List<EvolucaoObra> lista = new List<EvolucaoObra>();
            lista.Add(evo1);
            lista.Add(evo3);
            lista.Add(evo2);

            return new List<EvolucaoObra>(lista);
    }
    }
}
