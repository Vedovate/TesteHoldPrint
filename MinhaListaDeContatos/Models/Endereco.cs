using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MinhaListaDeContatos.Models
{
    public class Endereco
    {
        [Key()]
        public int EnderecoId { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; } = "Brasil";

        public static Endereco GetEndereco(string cep)
        {

            using (var client = new HttpClient())
            {
                var response = client.GetAsync($@"https://viacep.com.br/ws/{cep}/json/").Result.Content.ReadAsStringAsync().Result;
                var resposta = JsonConvert.DeserializeObject<JObject>(response);

                var retorno = new Endereco();

                retorno.Logradouro = resposta["logradouro"].ToString();
                retorno.Bairro = resposta["bairro"].ToString();
                retorno.Cidade = resposta["localidade"].ToString();
                retorno.Estado = resposta["uf"].ToString();

                return retorno;

            }
            
        }

    }
}
