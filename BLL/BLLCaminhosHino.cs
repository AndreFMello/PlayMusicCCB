using Model;
using SQLServerDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCaminhosHino
    {
        private static DALCaminhoHinos dalCaminhoHinos = null;

        public BLLCaminhosHino()
        {
            if (dalCaminhoHinos == null)
                dalCaminhoHinos = new DALCaminhoHinos();
        }

        public object InserirCaminho(MDLCaminhoHino mdlCaminhoHino)
        {
            var pk_Retorno_Caminho = dalCaminhoHinos.InserirCaminho(mdlCaminhoHino);
            return pk_Retorno_Caminho;
        }
    }
}
