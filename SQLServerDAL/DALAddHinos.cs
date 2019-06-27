using CONEXAO;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerDAL
{
    public class DALAddHinos
    {
        private Conexao conexao;

        public Int64 Inserir(MDLAddHinos mdlAddHinos)
        {
            try
            {
                //Query de Inclusão de dados
                string sql = string.Format
                    ("insert into db_ccbHinos (pk_Numero_Hino, vch_Titulo_Hino, fk_Classe_Hino, fk_cod_caminho) values ('{0}','{1}','{2}','{3}')",
                    mdlAddHinos.PK_Numero_Hino, mdlAddHinos.Vch_Titulo_Hino, mdlAddHinos.FK_Classe_Hino.PK_Classe_Hino, mdlAddHinos.FK_cod_caminho.PK_Caminho_Hino);

                //Abrir conexão para inclusão das informações
                using (conexao = new Conexao())
                {
                    conexao.ExecutaComando(sql);
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public List<MDLAddHinos> TodosHinos()
        {
            using (conexao = new Conexao())
            {
                var sql = "  Select h.pk_Numero_Hino, h.vch_Titulo_Hino, c.vch_Classe AS vch_classe, ch.descricao from db_ccbHinos h INNER JOIN tb_classesHinos c ON h.fk_Classe_Hino = c.pk_Classe_Hino INNER JOIN tb_Caminho_Hino ch ON ch.pk_Caminho_Hino = h.fk_cod_caminho";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
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
                    FK_cod_caminho = new MDLCaminhoHino() { Descricao = retorno["descricao"].ToString()}
                };

                listHinos.Add(item);
            }
            return listHinos;
        }
    }
}
