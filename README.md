# buscar-cep

Exemplo de uma aplicação para consumir uma API REST usando **Refit**.

A biblioteca **Refit** é um cliente REST para .NET Core e .Net. Ela permite que façamos chamadas para API REST sem utilizar muito código e de forma simples.

API utilizada no projeto: **ViaCEP**
**https://viacep.com.br/**

### Exemplo

Obter dados do CEP 12242-000 -> <https://viacep.com.br/ws/12242-000/json/>

Retorno:
```
   {
    "cep": "12242-000",
    "logradouro": "Avenida São João",
    "complemento": "de 2001/2002 ao fim",
    "bairro": "Jardim das Colinas",
    "localidade": "São José dos Campos",
    "uf": "SP",
    "unidade": "",
    "ibge": "3549904",
    "gia": "6452"
    } 
```