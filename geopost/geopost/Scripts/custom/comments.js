var serializeObject = function (form) {
    var o = {};
    var a = form.serializeArray();
    $.each(a, function () {
        if (o[this.name]) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });
    return o;
};


$(document).ready(function (event) {
    $(document).on('click', '#SumbitComment', function (event) {
        event.preventDefault();
        event.stopPropagation();

        var currentForm = $(this).parents('form');
        var adata = serializeObject(currentForm);
        var token = $(currentForm).find('input[name="__RequestVerificationToken"]').val();
        var action = "/umbraco/Surface/Comments/CreateNew";

        $.ajax({
            url: action,
            type: "POST",
            dataType: "application/json",
            data: {
                __RequestVerificationToken: token,
                model: adata
            },
            success: function (data) {
                $(currentForm).html("Success!");
            },
            error: function (request, status, error) {
                console.log(request.responseText);
            }
        });

    });
});