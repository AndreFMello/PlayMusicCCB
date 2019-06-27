using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlayMusic
{
    public partial class PlayMusic : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [WebMethod]
        public static object BuscarTodosHinos()
        {
            String mensagem = String.Empty;

            List<MDLAddHinos> mdlTodosHinos = new List<MDLAddHinos>();

            try
            {
                mdlTodosHinos = new BLL.BLLAddHinos().RetornarTodosHInos();
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível carregar a lista de hinos. O seguinte erro ocorreu: " + ex.Message;
            }

            return new
            {
                mdlTodosHinos = mdlTodosHinos,
                mensagem = mensagem
            };
        }
    }
}