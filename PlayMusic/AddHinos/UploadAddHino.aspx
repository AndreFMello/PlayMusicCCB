<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadAddHino.aspx.cs" Inherits="PlayMusic.AddHinos.UploadAddHino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="../Styles/Estilo.css" />
    <script src="../Bootstrap/jquery-2.0.3.min.js" type="text/javascript"></script>
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/dt/dt-1.10.18/datatables.min.css" />
    <script type="text/javascript" src="https://cdn.datatables.net/v/dt/dt-1.10.18/datatables.min.js"></script>
    <script type="text/javascript" src="../Paginas/AddHinoUpload.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</head>
<body style="font-family: Georgia, serif">
    <div class="container">
        <div class="jumbotron">
            <div class="modal-header text-center" style="background-color: #454d55; color: #fff;">
                <h4 class="modal-title w-100 font-weight-bold">Adicionar Novos Hinos</h4>
                <button type="button" class="close" aria-label="Close">
                    <span aria-hidden="true" style="color: #ffffff;">&times;</span>
                </button>
            </div>
            <br />
            <br />
            <form id="form1" runat="server">

                <div class="row">
                    <fieldset class="form-group col-md-11">
                        <label data-error="wrong" data-success="right" for="defaultForm-pass">Importar hinos:</label>
                        <asp:FileUpload ID="dllImportarArquivo" runat="server" />
                    </fieldset>
                    <fieldset class="form-group col-md-1">
                        <asp:Button runat="server" ID="UploadButton" Text="Upload" class="btn btn-info" OnClick="UploadButton_Click" />
                    </fieldset>
                </div>

                <div class="md-form mb-4">
                    <i class="fas fa-envelope prefix grey-text"></i>
                    <label data-error="wrong" data-success="right" for="defaultForm-email">Titulo do Hino:</label>
                    <input type="text" id="titulo" class="form-control validate" />
                </div>

                <div class="md-form mb-4">
                    <i class="fas fa-lock prefix grey-text"></i>
                    <label data-error="wrong" data-success="right" for="defaultForm-pass">Numero do hino:</label>
                    <input type="text" id="numero" class="form-control validate" />
                </div>

                <label data-error="wrong" data-success="right" for="defaultForm-pass">Categorias de Hinários:</label>
                <asp:DropDownList ID="dllCarregarClasse" runat="server"></asp:DropDownList>
                <br />
                <br />
                <asp:Label runat="server" ID="StatusLabel" Text="Status do Importe: " Style="float: left; margin-top: 15px;" class="font-weight-bold" />
                <br />
                <asp:Label runat="server" ID="GarantirUpload" Text="" Style="float: left; margin-top: 15px; display: none;" class="font-weight-bold" />

            </form>
            
            <div class="float-right">
                <button id="salvar" class="btn btn-success">Salvar</button>
            </div>

            <div class="float-right">
                <button id="cancelar" class="btn btn-danger">Cancelar</button>
            </div>
        </div>
    </div>
</body>
</html>
