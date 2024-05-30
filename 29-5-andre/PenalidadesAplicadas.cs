using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _29_5_andre
{
    internal class PenalidadesAplicadas
    {

        [JsonProperty("razao_social")]//mapeamento, fala q dentro do arquivo tem um campo com este nome
        public string RazaoSocial { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("nome_motorista")]
        public string NomeMotorista { get; set; }

        [JsonProperty("cpf")]
        public string Cpf { get; set; }

        [JsonProperty("vigencia_do_cadastro")]
        public DateTime VigenciaCadastro { get; set; }

        public override string ToString() => $"RazaoSocial: {RazaoSocial}, Cpf{Cpf}, NomeMotorista {NomeMotorista},Cnpj{Cnpj}, VigenciaCadastro {VigenciaCadastro}";

       
    }

}