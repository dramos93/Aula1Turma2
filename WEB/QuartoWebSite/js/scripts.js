$(document).ready(
    function myfunction() {
        function Dog(Nome, Idade, Ra�a, Coloracao) {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Ra�a = Raca;
            this.Coloracao= Coloracao;
        }
        $('button[name="btnboasvindas"]').click(function () {
            debugger
            var nomeUsuario = $('input[name="nomeUsuario"]').val();
            //alert("Bem vindo " + nomeUsuario + ", ao nosso sistema de cervejaria.");
            $('span[name="usuariotext"]').text(nomeUsuario);


        });











    });