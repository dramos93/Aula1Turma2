$(document).ready(
    function () {
        $('input[id="valor1"]').mask('#.##0,00', { reverse: true });
        $('input[id="valor2"]').mask('#.##0,00', { reverse: true});
    });


$('input[id="OK"]').click(
    function Converter() {

        var valor1 = $('input[id="valor1"]').val();//valor em Reais
        var valor2 = $('input[id="valor2"]').val();//Valor em Dólares


        valor1 = valor1.replace(".", "");
        valor1 = valor1.replace(",", ".");
        valor1 = valor1.replace("R$ ", "");

        valor2 = valor2.replace(".", "");
        valor2 = valor2.replace(",", ".");
        valor2 = valor2.replace("$ ", "");

        var resultado;
        if (valor1 != "" ^  valor2 != "") {
            if (valor1 != "") {
                resultado = valor1 / 4.16;
                var indexPonto = String(resultado).indexOf(".");
                var resultadoFormatado = String(resultado).substring(0, indexPonto + 3)
                resultadoFormatado = resultadoFormatado.replace(".", ",");
                $('input[id="valor2"]').val("$ " + resultadoFormatado);
            }
            if (valor2 != "") {
                resultado = valor2 * 4.16;
                indexPonto = String(resultado).indexOf(".");
                resultadoFormatado = String(resultado).substring(0, indexPonto + 3)
                resultadoFormatado = resultadoFormatado.replace(".", ",")
                $('input[id="valor1"]').val("R$ " + resultadoFormatado);
            }

        }
        //if (valor2 != "") {
        //    alert("valor 2 recebido");
        //}
        else {
            alert("Campo Digitado Incorretamente!");
        }
    }
);
$('input[id="Limpar"]').click(
    function () {
        $('input[Id="valor1"]').val("");
        $('input[Id="valor2"]').val("");
    })



//Abaixo não são utilizados...
function atualizaData() {
    setInterval(function () { $('span[name="data_atual"]').text(Date()); });
}
function mostrarNome() {
    var nome = $('input[id="nome"]').val();
    alert("Seja bem vindo, " + nome + "!");
}