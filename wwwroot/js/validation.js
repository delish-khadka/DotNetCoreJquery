function isNumber(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        return false;
    }
    return true;
}

function fnValidateMobileNo(data) {
    var regex = new RegExp("^([+][9][1][9][1][0]){0,1}([6-9]{1})([0-9]{9})");
    return regex.test(data);
}

function validEmail(email) {
    var regex = new RegExp('[a-z0-9]+@[a-z]+\.[a-z]{2,3}');;
    return regex.test(email);
}