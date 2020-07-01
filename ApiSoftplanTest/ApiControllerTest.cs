using WebApiSoftplan.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace ApiSoftplanTest
{
  public class ApiControllerTest
  {
    IApiService _service;
    public ApiControllerTest()
    {
      _service = new ApiService();

    }

    [Fact]
    public void VerificarRetornoJurosCorreto()
    {
      Assert.Equal("0,01", _service.ValorJuros());
    }

    [Fact]
    public void VerificarRetornoCalculoJurosCorreto()
    {
      Assert.Equal("105,10", _service.CalcularJuros(100, 5));
    }

    [Fact]
    public void VerificarRepositorioGIT()
    {
      Assert.Equal("https://gitlab.com/marcosmoski/webapisoftplan.git", _service.RetornarCodigo());
    }

  }
}
