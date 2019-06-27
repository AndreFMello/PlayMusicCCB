$(document).ready(function () {

    $("#adicionar").click(function () {
        window.location = "UploadAddHino.aspx";
    });

    var fs = function () {
        try {
        $.ajax({
            url: "PlayMusic.aspx/BuscarTodosHinos",
            type: "POST",
            data: {},
            async: true,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (retorno) {
                var dataObject = retorno.d.mdlTodosHinos;
                //var dataObject = [
                //    { numero: 441, name: 'Eu sou um cordeirinho', classe: 'Hinário 5' },
                //    { numero: 450, name: 'Vamos queridos escolher a boa parte', classe: 'Hinário 5' },
                //    { numero: 430, name: 'Preciosa é aos olhos do criador', classe: 'Hinário 5' },
                //    { numero: 430, name: 'Preciosa é aos olhos do criador', classe: 'Hinário 5' }
                //];
                var dataSet = [];
                var cont = 0;
                $.each(dataObject, function (index, data) {
                    var img = "<tr><a id='tocarHinos'><img src='../src/img/icone_som.png' width='25' pk_Hinos='" + data.PK_Numero_Hino + "' /></a></tr>";
                    dataSet.push([data.PK_Numero_Hino, data.Vch_Titulo_Hino, data.FK_Classe_Hino.Vch_Classe, img]);
                    cont++;
                });
                var table = $('#example').DataTable({
                    data: dataSet,
                    columns: [
                        { title: 'Numero do Hino' },
                        { title: 'Titulo do Hino' },
                        { title: 'Classe do Hinário' },
                        { title: 'Escutar' }
                    ],

                    "Search": "Pesquisar:",
                    "language": {
                        "search": "Pesquisar:",
                        "info": "Exibir _START_ para _END_ de _TOTAL_ entradas",
                        "infoEmpty": "Exibir 0 para 0 de 0 entrada",
                        "lengthMenu": "Exibir _MENU_ Entradas",
                        "zeroRecords": "Nenhum registro encontrado",
                        "paginate": {
                            "first": "Primero",
                            "last": "Último",
                            "previous": "Anterior",
                            "next": "Próximo"
                        }
                    }
                });

                $('#example tbody').on('click', 'img', function () {
                    var pk_Hinos = $(this).attr("pk_Hinos");
                    alert(pk_Hinos);
                });
            },
            error: function (req, status, error) {
                alert(error);
            }
        });
    }
        catch (ex) { }
    };
    fs();
});

function popularTableHinos() {
    
}

$(function () {
    $('#fupload').change(function () {
        $('.ImportarHino').html('<b>Arquivo Selecionado:</b>' + $(this).val());
    });
});

