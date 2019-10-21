


$(document).ready(function () {
        var cep = $('input[id="cep"]');
        $("#botao").click(
        function () {

                                                               
            $.get("https://viacep.com.br/ws/" + cep.val() + "/json/", function (data, status) {

                if (data.erro)
                    alert("CEP ERRADO");
                else {
                    alert(
                        data.cep + "\r\n" +
                        data.logradouro + "\r\n" +
                        data.complemento + "\r\n" +
                        data.bairro + "\r\n" +
                        data.localidade + "\r\n" +
                        data.uf + "\r\n" +
                        data.unidade + "\r\n" +
                        data.ibge + "\r\n" +
                        data.gia
                    );
                }

            });
        });
});


//Máscara para CEP
//http://www.kadunew.com/blog/exemplo-mascara-masked-input.html

//var app = new Vue({
//    el: "#app",
//    data: {
//        city: "",
//        cep: "56302000",
//        error: ""
//    },
//    methods: {
//        getCity: function () {
//            var self = this;
//            $.getJSON("https://viacep.com.br/ws/" + this.cep + "/json", function (result) {
//                if (("erro" in result)) {
//                    self.error = "CEP não encontrado";
//                    self.city = "";
//                    $(".error").addClass("no");
//                } else {
//                    self.city = result.logradouro + ", " + result.bairro + " - " + result.localidade + "/" + result.uf;
//                    $(".display").addClass("animated fadeInDown");
//                }
//                console.log(result);
//            });
//        }
//    },
//    watch: {
//        cep: function () {
//            if (this.cep.length === 8) {
//                this.getCity();
//                this.error = "";
//                $(".error").removeClass("no");
//            }
//            if (this.cep.length < 8) {
//                this.city = "";
//                this.error = "CEP Inválido";
//                $(".error").addClass("no");
//                $(".display").removeClass("animated fadeInDown");
//            }
//        }
//    },
//    mounted: function () {
//        this.getCity();
//    }
//})







