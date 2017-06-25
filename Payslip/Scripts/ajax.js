define('ajax', [], function () {

    var errorPrefix = "AJAX ERROR: ";

    function setErrorPrefix(errMsg) {
        errorPrefix = errMsg;
    };

    function call(url, method, data) {
        return $.ajax({
            url: url,
            method: method,
            data: data,
            error: function (jqXhr, textStatus, errorThrown) {
                alert(errorPrefix + errorThrown);
            }
        });
        
    };

    return {
        setErrorPrefix: setErrorPrefix,
        call: call
    };
});
