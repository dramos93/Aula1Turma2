$(document).ready(
    function () {

        $('button[name="btnboasvindas"]').click(function () {
            debugger
            var nomeUsuario = $('input[name="nomeUsuario"]').val();
            //alert("Bem vindo " + nomeUsuario + ", ao nosso sistema de cervejaria.");
            $('span[name="usuariotext"]').text(nomeUsuario);


        });
        $('input[name="nomeUsuario"]').on('keypress', function (e) {
            if (e.which === 13) {
                debugger
                $('button[name="btnboasvindas"]').click();
            }
        })


    });