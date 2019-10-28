$(document).ready(function () {
    $('#calcular').click(function () {

        var url = "http://localhost:59516/api/CalculoIMC?";
        var informacoes = $('#informacao').serialize();

        $.get(url + informacoes, function (data) {
            alert(data);
        });

    });
});

//Acabouuuuuuuuuuuuuuuuuu