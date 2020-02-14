$(document).ready(function() {
    $('#accCodeForm, #usernamepasswordform').hide();

    $('#txtUsername').on('keyup change', function() {
        $(this).val() != '' ? $('#btnSubmit').prop('disabled', false) : $('#btnSubmit').prop('disabled', true)
    });

    let _serviceURL_ = '';
    if (window.location.origin === 'http://psl-app-vm3' || window.location.href.indexOf("localhost") > -1) {
        _serviceURL_ = 'http://95.179.229.183/OMSAPI/api/'
    } else {
        _serviceURL_ = 'http://95.179.229.183/OMSAPI/api/'
    }
    let postVerification = {};

    $(document).on('click', '#btnSubmit', function() {
        pageLoader('show')
        let username = { username: $('#txtUsername').val() }

        if ($(this).text() === 'Send Access Code') {
            $.ajax({
                    url: `${_serviceURL_}Users/PostForgotPassword`,
                    method: 'POST',
                    crossDomain: true,
                    data: JSON.stringify(username),
                    contentType: "application/json",
                })
                .done(function(e) {
                    pageLoader('hide')
                    $('#accCodeForm, #usernamepasswordform').show();
                    $('#btnSubmit').text('Submit');
                    postVerification.strUserId = e.id
                    toastr.success("Verification Code Sent successfully");
                })
                .fail(function(xhr) {
                    pageLoader('hide');
                    toastr.error("An error ocurred");
                    console.log(xhr);
                });


        } else if ($(this).text() === 'Submit') {

            postVerification.strCode = $('#txtAccessCode').val();
            postVerification.strNewPassword = $('#txtNewPassword').val();


            if ($('#txtAccessCode').val() != '' || $('#txtNewPassword').val()) {
                $.ajax({
                        url: `${_serviceURL_}Users/PostVerificationCode`,
                        method: 'POST',
                        crossDomain: true,
                        data: JSON.stringify(postVerification),
                        contentType: "application/json",
                    })
                    .done(function(e) {
                        pageLoader('hide');

                        toastr.success("Password Changed successfully");
                        $('input').val('');
                        setTimeout(function() { window.history.back(); }, 2000)

                    })
                    .fail(function(xhr) {
                        console.log(xhr);
                        pageLoader('hide');
                        toastr.error("An error ocurred");
                    });
            } else {
                toastr.info("Please input the code and new password!");
            }


        }
    });



});