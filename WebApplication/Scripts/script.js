$('#generate').click(function () {
    var form = $('#__AjaxAntiForgeryForm');
    var token = $('input[name="__RequestVerificationToken"]', form).val();
    var url = new Object();
    url.LongUrl = $('#LongUrl').val();
    $.ajax({
        url: "/UrlShortener/Generate",
        type: 'POST',
        data: {
            url: url,
            __RequestVerificationToken: token
        },
        success: function (response) {
            $('#ShortUrl').val(response.ShortUrl);
        }
    });
    return false;
});