$(document).ready(function() {
    $('.text').on('keyup change', function() {
        $('#txtName').val() != '' && $('#txtPassword').val() != '' ?
            $('#btnSignIn').prop('disabled', false) :
            $('#btnSignIn').prop('disabled', true)
    })

});