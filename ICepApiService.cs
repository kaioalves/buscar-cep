using System.Threading.Tasks;
using Refit;

namespace buscar_cep
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAdressAsync(string cep);
    }
}
