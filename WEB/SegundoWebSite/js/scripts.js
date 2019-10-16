$(document).ready(
    function () {
        atualizaData()
    });
function atualizaData() {
    setInterval(function () { $('span[name="data_atual"]').text(Date()); });
}

$('input[id="OK"]').click(
    function () {
        var nome = $('input[id="nome"]').val();
        alert("Seja bem vindo, "+nome+"!");
    });
