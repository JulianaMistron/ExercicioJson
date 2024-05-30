using System.Data.SqlClient;

namespace _29_5_andre
{
    internal class SqlBD
    {   
        public static void Salvar(List<PenalidadesAplicadas> penalidadesAplicadas)
        {
            Banco conn = new Banco();
            SqlConnection conexaoSql = new SqlConnection(conn.Caminho());
            conexaoSql.Open();

            var empresas = TestFilters.GroupByCnpjUseLinq(penalidadesAplicadas).DistinctBy(p => p.Cnpj);

            // inserir empresas
            foreach (var item in empresas)
            {
                SqlCommand cmd = new($"Insert into Empresa (cnpj,razao_social) values ('{item.Cnpj}','{item.RazaoSocial}')", conexaoSql);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            //// inserir motorista
            foreach (var item in penalidadesAplicadas)
            {
                SqlCommand cmd = new($"Insert into Motorista (cpf, nome_motorista, vigencia_cadastro, cnpj_empresa) values ('{item.Cpf}','{item.NomeMotorista}', '{item.VigenciaCadastro.ToString("yyyy-MM-dd")}', '{item.Cnpj}')", conexaoSql);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        // método consultar
        //
    }
}
