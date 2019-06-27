using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlayMusic.AddHinos
{
    public partial class UploadAddHino : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarCombo();
            }

            //var titulo = Request.QueryString["titulo"];
            //var numero = Request.QueryString["numero"];
            //var classe = Request.QueryString["classe"];
            //var novo = Request.QueryString["novo"];
        }

        private void carregarCombo()
        {
            dllCarregarClasse.DataSource = new BLL.BLLGetClasseHinos().RetornarClassesHinos();
            dllCarregarClasse.DataValueField = "pk_Classe_Hino";
            dllCarregarClasse.DataTextField = "vch_Classe";
            dllCarregarClasse.DataBind();
            dllCarregarClasse.Items.Insert(0, new ListItem("Selecione...", "0"));
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (dllImportarArquivo.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(dllImportarArquivo.FileName);
                    dllImportarArquivo.SaveAs(Server.MapPath("~/src/Hinos/") + filename);
                    StatusLabel.Text = "Status do Importe: Sucesso!!!";
                    GarantirUpload.Text = filename;
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Status do Importe: Não foi possível importar o arquivo. O seguinte erro ocorreu: " + ex.Message;
                    GarantirUpload.ID = "";
                }
            }
        }

        [WebMethod]
        public static object SalvarEditarHinos(String numero, String titulo, String classe, bool novo, String caminho)
        {
            bool erros = false;
            String mensagem = String.Empty;

            if (String.IsNullOrEmpty(numero))
            {
                erros = true;
                mensagem = "O campo numero não foi preenchido.<br /><br />";
            }

            if (String.IsNullOrEmpty(titulo))
            {
                erros = true;
                mensagem += "O campo titulo não foi preenchido.<br /><br />";
            }

            if (String.IsNullOrEmpty(classe))
            {
                erros = true;
                mensagem += "O campo classe não foi selecionado.<br /><br />";
            }

            if (String.IsNullOrEmpty(caminho))
            {
                erros = true;
                mensagem += "Não foi importado nenhum hino.";
            }

            if (erros)
            {
                return new
                {
                    erros = erros,
                    mensagem = mensagem
                };
            }
      
            try
            {
                MDLCaminhoHino mdlCaminhoHino = new MDLCaminhoHino()
                {
                    Descricao = caminho
                };

                var pk_Retorno_Caminho = new BLL.BLLCaminhosHino().InserirCaminho(mdlCaminhoHino);

                MDLAddHinos mdlHinos = new MDLAddHinos()
                {
                    PK_Numero_Hino = Convert.ToInt64(numero),
                    Vch_Titulo_Hino = titulo,
                    FK_Classe_Hino = new MDLClasseHinos() { PK_Classe_Hino = Convert.ToInt32(classe) },
                    FK_cod_caminho = new MDLCaminhoHino() { PK_Caminho_Hino = Convert.ToInt32(pk_Retorno_Caminho) }
                };

                bool salvoSucesso = true;

                if (novo)
                {
                    salvoSucesso = Convert.ToBoolean(new BLL.BLLAddHinos().Inserir(mdlHinos));
                }

                if (salvoSucesso)
                {
                    mensagem = "Hino salvo com sucesso.";
                }
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível salvar o hino. O seguinte erro ocorreu: " + ex.Message;
            }

            return new
            {
                erros = erros,
                mensagem = mensagem
            };
        }
        
    }
}
