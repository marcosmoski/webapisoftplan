using Microsoft.AspNetCore.Mvc;
using WebApiSoftplan.Contracts;
using WebApiSoftplan.Services;

namespace WebApiSoftplan.Controllers
{
  public class ApiController : Controller
  {
    private IApiService _apiService;

    public ApiController(IApiService apiService)
    {
      _apiService = apiService;
    }

    [HttpGet(RotasApi.Rotas.RetornarJuros)]
    public IActionResult GetValorJuros()
    {
      return Ok(_apiService.ValorJuros());
    }

    [HttpGet(RotasApi.Rotas.MostrarCodigo)]
    public IActionResult GetTheCode()
    {
      return Ok(_apiService.RetornarCodigo());
    }

    [HttpGet(RotasApi.Rotas.CalcularJuros)]
    public IActionResult GetCalculoJuros([FromRoute] double valorInicial, [FromRoute] int meses)
    {
      return Ok(_apiService.CalcularJuros(valorInicial, meses));
    }
  }
}
