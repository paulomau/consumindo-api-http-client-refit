using MAU.HttpCliente_Refit.App.Models;
using Refit;
using System.Threading.Tasks;
using static System.Console;

namespace MAU.HttpCliente_Refit.App
{
  internal class Program
  {
    static async Task Main(string[] args)
    {
      var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");

      while (true)
      {
        Write("Informe seu CEP: ");
        var cep = ReadLine();
        WriteLine("---------------------");
        WriteLine("Resultado da consulta:");
        WriteLine("---------------------");

        var address = await cepClient.GetAddressAsync(cep);

        WriteLine($"Logradouro: {address.Logradouro}");
        WriteLine($"Bairro: {address.Bairro}");
        WriteLine($"Bairro: {address.Localidade}");
        WriteLine($"Uf: {address.Uf}");
        WriteLine($"Cep: {address.Cep}");
        WriteLine($"Ibge: {address.Ibge}");

        WriteLine("---------------------");
        WriteLine("Aperte Ctrl+C para sair, ou qualquer tecla para continuar.");
        WriteLine("---------------------");
        ReadKey();
        WriteLine(" ");
      }
    }
  }
}
