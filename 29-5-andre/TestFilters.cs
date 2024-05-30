using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _29_5_andre
{
    internal class TestFilters
    {

        public static int getCountRecords(List<PenalidadesAplicadas> lista) => lista.Count;

        public static List<PenalidadesAplicadas> FilterByNumbercpfLinq(List<PenalidadesAplicadas> lista) => lista.Where(p => p.Cpf.StartsWith("237")).ToList();


        public static void PrintData(List<PenalidadesAplicadas> lista2)
        {
            foreach (var item in lista2)
            {
                Console.WriteLine(item);
            }
        }
        public static List<PenalidadesAplicadas> FilterByAnoLinq(List<PenalidadesAplicadas> lista) => lista.Where(p => p.VigenciaCadastro.Year == 2021).ToList();

        public static List<PenalidadesAplicadas> FilterByRazaoSocial(List<PenalidadesAplicadas> lista) => lista.Where(p => p.RazaoSocial.Contains ("LTDA")).ToList();

        public static List<PenalidadesAplicadas> OrderByRazaoSocialUseLinq(List<PenalidadesAplicadas> lista) => lista.OrderBy (p => p.RazaoSocial).ToList();

        public static List<PenalidadesAplicadas> GroupByCnpjUseLinq(List<PenalidadesAplicadas> lista) => lista.GroupBy(p => p.Cnpj)
            .Select(g => g.First())
            .OrderBy(p => p.RazaoSocial)
            .ToList();

        public static string GenerateXML(List<PenalidadesAplicadas> lista)
        {
            if (lista.Count > 0)
            {
                var penalidadeAplicada = new XElement("Root", from data in lista
                                                               where data.Cpf == "139.***.***-87"
                                                               select new XElement("motorista",
                                                               new XElement("razao_social", data.RazaoSocial),
                                                               new XElement("cnpj", data.Cnpj),
                                                               new XElement("cpf", data.Cpf),
                                                               new XElement("vigência_do_Cadastro", data.VigenciaCadastro)
                                                               )
                                                               );
                return penalidadeAplicada.ToString();
            }
            else
            {
                return "Não existem registros.";
            }
        }
    }
}