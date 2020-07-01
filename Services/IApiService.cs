using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSoftplan.Services
{
  public interface IApiService
  {
    string ValorJuros();
    string RetornarCodigo();
    string CalcularJuros(double valorInicial, int meses);
  }
}
