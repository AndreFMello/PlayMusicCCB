<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayMusic.aspx.cs" Inherits="PlayMusic.PlayMusic" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="../Styles/Estilo.css" />
    <script src="../Bootstrap/jquery-2.0.3.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="../Paginas/paginaPrincipal.js"></script>
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/dt/dt-1.10.18/datatables.min.css" />
    <script type="text/javascript" src="https://cdn.datatables.net/v/dt/dt-1.10.18/datatables.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</head>
<body style="font-family: Georgia, serif">
    <div class="container">
        <div class="jumbotron">
            <div class="modal-header text-center" style="color: #454d55; margin-bottom: 30px; border-bottom: 1px solid; border-color: #454d55;">
                <h2 class="modal-title w-100 font-weight-bold">Congregação Cristã no Brasil</h2>
            </div>
            <div>
                <img src="../src/img/Logoccb.png" id="sizeImgLogo" />
            </div>
            <br />
            <br />
            <table id="example" class="table table-striped" width="100%">
                <tbody>
                </tbody>
            </table>
            <br />
            <br />
            <div style="float: right">
                <label>
                    <h6>Adiciona novos hinos</h6>
                </label>
                <button id="adicionar" type="button" class="btn btn-primary">Adicionar</button>
            </div>
        </div>
    </div>
</body>
</html>
