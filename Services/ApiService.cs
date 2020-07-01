using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSoftplan.Services
{
  public class ApiService : IApiService
  {
    public string CalcularJuros(double valorInicial, int meses)
    {
      double valorFinal = valorInicial * Math.Pow((1 + Convert.ToDouble(this.ValorJuros())), meses);
      valorFinal = Math.Round(valorFinal, 2);
      return valorFinal.ToString("0.00");
    }

    public string RetornarCodigo()
    {
      return "https://gitlab.com/marcosmoski/webapisoftplan.git";
    }

    public string ValorJuros()
    {
      return 0.01.ToString("0.00");
    }
  }
}
