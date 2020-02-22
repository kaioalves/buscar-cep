using System;
using System.Threading.Tasks;
using Refit;

namespace buscar_cep
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
                Console.WriteLine("Digite o CEP:");

                string cepDigitado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando informações do CEP: " + cepDigitado);

                var adress = await cepClient.GetAdressAsync(cepDigitado);

                Console.WriteLine($"\nLogradouro: { adress.Logradouro} \nBairro: {adress.Bairro} \nCidade: {adress.Localidade}/{adress.UF}");
                Console.ReadKey();
            } catch (Exception e)
            {
                Console.WriteLine("Erro ao consultar CEP! Verifique o CEP digitado e tente novamente.");
                //Console.WriteLine("Erro ao consultar CEP! Verifique o CEP digitado e tente novamente." + "\n" + e.Message);
            }

        }
    }
}
