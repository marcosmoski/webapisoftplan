using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSoftplan.Contracts
{
  public class RotasApi
  {
     public static class Rotas {
       public const string RetornarJuros = "/taxaJuros";
       public const string CalcularJuros = "/calculajuros/{valorInicial}/{meses}";
       public const string MostrarCodigo = "/showmethecode";
    }
  }
}
