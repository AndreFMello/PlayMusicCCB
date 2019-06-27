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
    public class DALGetClasses
    {
        private StringBuilder sb;
        private Conexao conexao;

        public List<MDLClasseHinos> All()
        {
            using (conexao = new Conexao())
            {
                var sql = "SELECT pk_Classe_Hino, vch_Classe FROM tb_classesHinos";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<MDLClasseHinos> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listClasseHinos = new List<MDLClasseHinos>();

            while (retorno.Read())
            {
                var item = new MDLClasseHinos()
                {
                    PK_Classe_Hino = Convert.ToInt32(retorno["pk_Classe_Hino"]),
                    Vch_Classe = retorno["vch_Classe"].ToString()
                };

                listClasseHinos.Add(item);
            }
            return listClasseHinos;
        }
    }
}


