var action_user_login = 'user-login';
var action_read_later = 'read-later';

var login_form_container = '.login-form-container';

var registAjaxBtn = '#UserRegister';
var loginForm = '#login-form';
var registerForm = '#register-form';
var loginFormContainer = '.login-container';


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

var register = function (event, isLogin) {
    event.preventDefault();
    event.stopPropagation();

    var currentForm = $(event.currentTarget).parents('form');
    var adata = serializeObject(currentForm);
    var token = $(currentForm).find('input[name="__RequestVerificationToken"]').val();
    var formContainer = $(currentForm).parents('.authentication-form-container');
    var action = '/umbraco/Surface/Users/' + (isLogin ? "Login" : "Register");

    $.ajax({
        url: action,
        type: "POST",
        dataType: "json",
        data: {
            __RequestVerificationToken: token,
            model: adata
        },
        success: function (data) {
            $(formContainer).html(data);
        },
        error: function (request, status, error) {
            $(formContainer).html(request.responseText);
        }
    });
};


$(document).ready(function () {
    $(document).on('click', '.navbar-custom-action-btn', function (event) {
        if ($(this).children('a').attr('href') == "#") {
            event.preventDefault();
            event.stopPropagation();

            var that = $(this);
            var action = $(that).data('action');
            var btn_position = $(that).offset();

            if (action == action_user_login) {
                $(login_form_container).css({ "left": (btn_position.left + $(that).width() - $(login_form_container).width()) });
                $(login_form_container).css({ "top": (btn_position.top + $(that).height()) });
                $(login_form_container).show();
            }
        }
    });

    $(document).on('click', '#UserRegister', function (event) {
        register(event, false);
    });

    $(document).on('click', '#UserLogin', function (event) {
        register(event, true);
    });

});