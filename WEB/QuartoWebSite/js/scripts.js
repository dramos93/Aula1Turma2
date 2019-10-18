$(document).ready(
    function myfunction() {
        function Dog(Nome, Idade, Raça, Coloracao) {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Raça = Raca;
            this.Coloracao= Coloracao;
        }
        $('button[name="btnboasvindas"]').click(function () {
            debugger
            var nomeUsuario = $('input[name="nomeUsuario"]').val();
            //alert("Bem vindo " + nomeUsuario + ", ao nosso sistema de cervejaria.");
            $('span[name="usuariotext"]').text(nomeUsuario);


        });











    });