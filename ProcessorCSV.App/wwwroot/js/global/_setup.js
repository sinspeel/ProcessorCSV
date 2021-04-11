var AjaxUrls = {};

var JSSetup = function () {
    function getCookie(cname) {
        var name = cname + "=";
        var ca = document.cookie.split(';');

        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) === ' ') {
                c = c.substring(1);
            }
            if (c.indexOf(name) === 0) {
                return c.substring(name.length, c.length);
            }
        }

        return "";
    }

    return {
        ajaxSetup: function () {
            jQuery.ajaxSetup({
                beforeSend: function (xhr) {
                    var token = getCookie("bearer");
                    xhr.setRequestHeader('Authorization', `Bearer ${token}`);
                }, error: function (jqXHR, textStatus, errorThrown) {
                    console.log(jqXHR);
                }, complete: function (xhr, status) {

                }
            });
        }
    };
}();

$(function () {
    //console.log('_setup.js is loading');
    AjaxUrls.CoreAPI = "https://localhost:44334/v1";
    JSSetup.ajaxSetup();
});