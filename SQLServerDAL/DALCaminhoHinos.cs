using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONEXAO;
using Model;

namespace SQLServerDAL
{
    public class DALCaminhoHinos
    {
        private Conexao conexao;

        public Int32 InserirCaminho(MDLCaminhoHino mdlCaminhoHino)
        {
            try
            {
                //Query de Inclusão de dados
                var retorno = 0;

                string sql = string.Format
                    ("insert into tb_Caminho_Hino (descricao) values ('{0}')SELECT SCOPE_IDENTITY()",
                    mdlCaminhoHino.Descricao);

                //Abrir conexão para inclusão das informações
                using (conexao = new Conexao())
                {
                    retorno = conexao.ExecutaRetornoComando(sql);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private List<MDLAddHinos> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listHinos = new List<MDLAddHinos>();

            while (retorno.Read())
            {
                var item = new MDLAddHinos()
                {
                    PK_Numero_Hino = Convert.ToInt64(retorno["pk_Numero_Hino"]),
                    Vch_Titulo_Hino = retorno["vch_Titulo_Hino"].ToString(),
                    FK_Classe_Hino = new MDLClasseHinos() { Vch_Classe = retorno["vch_classe"].ToString() },
                    FK_cod_caminho = new MDLCaminhoHino() { Descricao = retorno["descricao"].ToString() }
                };

                listHinos.Add(item);
            }
            return listHinos;
        }
    }
}
