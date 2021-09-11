using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : Controller
    {
        private ICidadeService _service;
        public CidadeController(ICidadeService service)
        {
            _service = service;
        }
        [HttpGet("ListaCidades")]
        public JsonResult ListaCidades()
        {
            return Json(_service.ListaCidades());
        }
        [HttpGet("BuscaPorCep")]
        public JsonResult BuscaPorCep(string Cep)
        {
            return Json(_service.BuscaPorCep(Cep));
        }
        [HttpPost("Salvar")]
        public JsonResult Salvar(string cep, string uf, string nome)
        {
            var obj = new Cidade
            {
                Cep = cep,
                Uf = uf,
                Nome = nome
            };
            _service.Salvar(obj);
            return Json(true);
        }
    }
}
