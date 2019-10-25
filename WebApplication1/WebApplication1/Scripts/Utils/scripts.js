$(document).ready(function () {
    $('#Button1').click(function () {
        $.getJSON("https://viacep.com.br/ws/RS/Porto%20Alegre/all/json/", function (data) {
            $.each(data, function (key, value) {
                var templateContent;

                templateContent += "{";

                $.each(value, function (key, value) {
                    templateContent += key + ":" + value + ",";
                });
                templateContent += "}";
                $('#TextArea1').append(
                    templateContent + "\n"
                );
                $('#TextArea1').css("height", "300px");
            });
        });
    });
});





//$('#TextArea1').change(
//    <textarea style="width: 90 % ; height: auto"></textarea>

//);