$(document).ready(
    function () {



        $('input[id="OK"]').click(
            function Converter() {

                var url = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json";

                $.getJSON(url, function (data) {


                    var valordolar = data.value[0].cotacaoVenda;

                    var valor1 = $('input[id="valor1"]').val();//valor em Reais
                    var valor2 = $('input[id="valor2"]').val();//Valor em Dólares

                    $('input[id="valor1"]').mask('#.##0,00', { reverse: true });
                    $('input[id="valor2"]').mask('#.##0,00', { reverse: true });



                    valor1 = valor1.replace(".", "");
                    valor1 = valor1.replace(",", ".");
                    valor1 = valor1.replace("R$ ", "");

                    valor2 = valor2.replace(".", "");
                    valor2 = valor2.replace(",", ".");
                    valor2 = valor2.replace("$ ", "");

                    var resultado;
                    if (valor1 != "" ^ valor2 != "") {
                        if (valor1 != "") {
                            resultado = valor1 / valordolar;
                            var indexPonto = String(resultado).indexOf(".");
                            var resultadoFormatado = String(resultado).substring(0, indexPonto + 3)
                            resultadoFormatado = resultadoFormatado.replace(".", ",");
                            $('input[id="valor2"]').val("$ " + resultadoFormatado);
                        }
                        if (valor2 != "") {
                            resultado = valor2 * valordolar;
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
                });
            }
        );
        $('input[id="Limpar"]').click(
            function () {
                $('input[Id="valor1"]').val("");
                $('input[Id="valor2"]').val("");
            })

        $('input[name="valor1"]').on('keypress', function (e) {
            if (e.which === 13) {
                $('input[Id="valor2"]').val("");
                $('input[id="OK"]').click();
            }
        })

        $('input[name="valor2"]').on('keypress', function (e) {
            if (e.which === 13) {
                $('input[Id="valor1"]').val("");
                $('input[id="OK"]').click();
            }
        })

    });
//Abaixo não são utilizados...
function atualizaData() {
    setInterval(function () { $('span[name="data_atual"]').text(Date()); });
}
function mostrarNome() {
    var nome = $('input[id="nome"]').val();
    alert("Seja bem vindo, " + nome + "!");
}