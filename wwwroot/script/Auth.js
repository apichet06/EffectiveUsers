 
    $("#loginForm").on("submit", function (e) {
        e.preventDefault();

        var userLogin = $('#userlogin').val();
        var password = $('#password').val();
        $.ajax({
            type: 'POST',
            url: loginUrl,
            data: {
                userLogin: userLogin,
                password: password
            },
            success: function (response) {
                if (response.success) {
                    window.location.href = redirectUrl;
                } else {
                    console.log(response.message);
                    $("#alert").html(
                        `<div class="alert alert-danger" role="alert">
                           <strong class="alert">${response.message}</strong>
                        </div>`
                    )
                }
            },
            error: function (xhr, status, error) {
                console.error(error);
            }
        });
    });
 