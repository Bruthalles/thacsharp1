using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class TimeController : ControllerBase{

        [HttpGet("horaAtual")]
        public IActionResult GetDataEHoraAtual(){
            var obj = new {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome){
            var mensagem = $"Olá {nome}, seja bem vindo";
            return Ok(new {mensagem});
        }
    }
}