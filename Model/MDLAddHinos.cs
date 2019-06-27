using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MDLAddHinos
    {
        #region Atributos Internos

        private Int64 pk_Numero_Hino;
        private String vch_Titulo_Hino;
        private MDLClasseHinos fk_Classe_Hino;
        private MDLCaminhoHino fk_cod_caminho;

        #endregion

        #region Propriedades

        public Int64 PK_Numero_Hino
        {
            get { return this.pk_Numero_Hino; }
            set { this.pk_Numero_Hino = value; }
        }

        public String Vch_Titulo_Hino
        {
            get { return this.vch_Titulo_Hino; }
            set { this.vch_Titulo_Hino = value; }
        }

        public MDLClasseHinos FK_Classe_Hino
        {
            get { return this.fk_Classe_Hino; }
            set { this.fk_Classe_Hino = value; }
        }

        public MDLCaminhoHino FK_cod_caminho
        {
            get { return this.fk_cod_caminho; }
            set { this.fk_cod_caminho = value; }
        }

        public MDLAddHinos MDLAddHino { get; set; }

        #endregion

        #region Construtores

        public MDLAddHinos() { }

        public MDLAddHinos(Int64 pk_Numero_Hino, String vch_Titulo_Hino, MDLClasseHinos fk_Classe_Hino, MDLCaminhoHino fk_cod_caminho)
        {
            this.pk_Numero_Hino = pk_Numero_Hino;
            this.vch_Titulo_Hino = vch_Titulo_Hino;
            this.fk_Classe_Hino = fk_Classe_Hino;
            this.fk_cod_caminho = fk_cod_caminho;
        }

        #endregion
    }
}
