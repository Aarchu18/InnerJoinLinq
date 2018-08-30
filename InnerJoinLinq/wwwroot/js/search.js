$('[data-attr="submit"]').on('click', function () {
    $.ajax(
        {
            type: "POST",
            url: "/Search/Index",
            data: $('#SearchId').serialize(),
            success: function (response) {
                $('#divInitialLoad').hide();
                $('#divAjaxLoad').html('');
                $('#divAjaxLoad').html(response);
            },
            error: function (err) {
                console.log(err);
               
            }
        });
});