﻿$('#generate').click(function () {
    var form = $('#__AjaxAntiForgeryForm');
    var token = $('input[name="__RequestVerificationToken"]', form).val();
    var url = new Object();
    url.LongUrl = $('#LongUrl').val();
    if (isURL($('#LongUrl').val())) {
        $.ajax({
            url: "/UrlShortener/Generate",
            type: 'POST',
            data: {
                url: url,
                __RequestVerificationToken: token
            },
            success: function (response) {
                $('#ShortUrl').text(response.ShortUrl);
                $("#ShortUrl").attr("href", response.ShortUrl)
            }
        });
    }
    else {

    }
});

function isURL(str) {
    var pattern = new RegExp('^((ft|htt)ps?:\\/\\/)?' + // protocol
        '((([a-z\\d]([a-z\\d-]*[a-z\\d])*)\\.)+[a-z]{2,}|' + // domain name and extension
        '((\\d{1,3}\\.){3}\\d{1,3}))' + // OR ip (v4) address
        '(\\:\\d+)?' + // port
        '(\\/[-a-z\\d%@_.~+&:]*)*' + // path
        '(\\?[;&a-z\\d%@_.,~+&:=-]*)?' + // query string
        '(\\#[-a-z\\d_]*)?$', 'i'); // fragment locator
    return pattern.test(str);
}