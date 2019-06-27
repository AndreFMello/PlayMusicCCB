using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MDLClasseHinos
    {
        #region Atributos Internos

        private Int32 pk_Classe_Hino;
        private String vch_Classe;

        #endregion

        #region Propriedades

        public Int32 PK_Classe_Hino
        {
            get { return this.pk_Classe_Hino; }
            set { this.pk_Classe_Hino = value; }
        }
       
        public String Vch_Classe
        {
            get { return this.vch_Classe; }
            set { this.vch_Classe = value; }
        }

        public MDLClasseHinos MDLAddHino { get; set; }

        #endregion

        #region Construtores

        public MDLClasseHinos() { }

        public MDLClasseHinos(Int32 pk_Classe_Hino, String vch_Classe)
        {
            this.pk_Classe_Hino = pk_Classe_Hino;
            this.vch_Classe = vch_Classe;
        }

        #endregion
    }
}
