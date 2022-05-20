using Refit;
using System.Threading.Tasks;

namespace MAU.HttpCliente_Refit.App.Models
{
  public interface ICepApiService
  {
    [Get("/ws/{cep}/json")]
    Task<CepResponse> GetAddressAsync(string cep);
  }
}
