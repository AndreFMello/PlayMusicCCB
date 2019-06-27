using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MDLCaminhoHino
    {
        #region Atributos Internos

        private Int64 pk_Caminho_Hino;
        private String descricao;

        #endregion

        #region Propriedades

        public Int64 PK_Caminho_Hino
        {
            get { return pk_Caminho_Hino; }
            set { pk_Caminho_Hino = value; }
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        #endregion

        #region Construtores

        public MDLCaminhoHino() { }

        public MDLCaminhoHino(Int64 pk_Caminho_Hino, String descricao)
        {
            this.pk_Caminho_Hino = pk_Caminho_Hino;
            this.descricao = descricao;
        }

        #endregion
    }
}
