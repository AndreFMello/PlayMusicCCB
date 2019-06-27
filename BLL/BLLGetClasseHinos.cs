using Model;
using SQLServerDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLGetClasseHinos
    {
        private static DALGetClasses dalGetClasses = null;

        public BLLGetClasseHinos()
        {
            if (dalGetClasses == null)
                dalGetClasses = new DALGetClasses();
        }

        public List<MDLClasseHinos> RetornarClassesHinos()
        {
            return dalGetClasses.All();
        }
    }
}
