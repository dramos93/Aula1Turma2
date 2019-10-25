$(document).ready(function () {
    $('#Calcular').click(function () {

        var informacoes = $('#Lista_Info').serialize();
        $.get("http://localhost:64921/api/IMC?" + informacoes, function (data) {
            alert(data);
        });
    });
});

