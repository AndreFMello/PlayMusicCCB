var $pk_int_tarifas = 0;
var $titulo = "";
var $numero = "";
var $classe = "";
var $btnAdicionar = "";
var $btnSalvar = "";
var $GarantirUpload;

$(document).ready(function () {
    $titulo = $("#titulo");
    $numero = $("#numero");
    $classe = $('#dllCarregarClasse');
    $btnAdicionar = $("#adicionar");
    $btnSalvar = $("#Salvar");
    $caminho = $("[id$=GarantirUpload]");
    var valor = true;
    var ativo = false;

    bloquearCampos($caminho[0].innerText);

    $("#salvar").click(function () {

        try {
            var param = '{titulo:"' + $titulo.val() +
                '" , numero:"' + $numero.val() +
                '" , classe:"' + $classe.val() +
                '" , caminho:"' + $caminho[0].innerText +
                '" , novo:' + valor + '}';

            $.ajax({
                url: "UploadAddHino.aspx/SalvarEditarHinos",
                type: "POST",
                data: param,
                async: true,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (erros) {
                    alert(erros.d.mensagem);
                    window.location = "PlayMusic.aspx";
                },
                error: function (req, status, error) {
                    alert(error);
                }
            });
        }
        catch (ex) { }
        
        //var param = "?titulo=" + $titulo.val();
        //param += "&numero=" + $numero.val();
        //param += "&classe=" + $classe.val();
        //param += "&novo=" + valor;
        //var mywindow = window.open("UploadAddHino.aspx" + param);
        
    });


    $("#cancelar").click(function () {
        window.location = "PlayMusic.aspx";
    });

    $("#UploadButton").click(function () {
        if ($caminho[0].innerText !== "") {
            $("#titulo").prop("disabled", false);
            $("#numero").prop("disabled", false);
            $("#dllCarregarClasse").prop("disabled", false);
        }
    });
});

function bloquearCampos(caminho) {
    if (caminho != "") {
        $("#titulo").prop("disabled", false);
        $("#numero").prop("disabled", false);
        $("#dllCarregarClasse").prop("disabled", false);
        $("#dllImportarArquivo").prop("disabled", true);
    }
    else {
        $("#dllImportarArquivo").prop("disabled", false);
        $("#titulo").prop("disabled", true);
        $("#numero").prop("disabled", true);
        $("#dllCarregarClasse").prop("disabled", true);
    }
}