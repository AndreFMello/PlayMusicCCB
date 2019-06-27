using Model;
using SQLServerDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLAddHinos
    {
        private static DALAddHinos dalAddHinos = null;

        public BLLAddHinos()
        {
            if (dalAddHinos == null)
                dalAddHinos = new DALAddHinos();
        }

        public Int64 Inserir(MDLAddHinos mdlAddHInos)
        {
            return dalAddHinos.Inserir(mdlAddHInos);
        }

        public List<MDLAddHinos> RetornarTodosHInos()
        {
            return dalAddHinos.TodosHinos();
        }
    }
}
