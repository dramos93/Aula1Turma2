var DogPadrao = {};

$(document).ready(
    function () {


        function Dog(Nome, Idade, Raca, Coloracao) {
            DogPadrao =
                {
                    Nome: Nome,
                    Idade: Idade,
                    Raca: Raca,
                    Coloracao: Coloracao
                };
        };

        //var MeuNovoDog = Dog("NomeDoDog", 14, "SRD", "Amarelo");
        var MeuNovoDog;

        $('button[id="Salvar"]').click(function () {
            MeuNovoDog.Nome = $('type[id="Nome"]');
            MeuNovoDog.Idade = $('type[id="Idade"]');
            MeuNovoDog.Raca = $('type[id="Raca"]');
            MeuNovoDog.Coloracao = $('type[id="Coloracao"]');
        });
        $('button[id="Mostrar"]').click(function () {
            alert(DogPadrao.Nome + "\r\n" + DogPadrao.Idade);
        });
    }
);
function LimparTela() {
    var meusImputs = $('input[]');
    meusImputs.val("");



}