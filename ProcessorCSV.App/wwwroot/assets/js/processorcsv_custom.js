$(function () {
    $('a[href="' + this.location.pathname + '"]').parents('li,ul').addClass('menu-item-active');

    // $('#kt_aside_toggle1').click(function () {
    //     $('.tr-charges-01').toggleClass('hidden');
    //     $('body').toggleClass('aside-minimize-hoverable');
    // });

    // Toastr notifications
    // Success Type
    $('#type-success').on('click', function () {
        toastr.success('I do not think that word means what you think it means.', 'Miracle Ash Says!',
            {
                positionClass: 'toast-top-center',
                containerId: 'toast-top-center',
                "showMethod": "slideDown",
                "hideMethod": "slideUp",
                timeOut: 3000
            });
    });
    // Danger Type
    $('#type-error').on('click', function () {
        toastr.error('Hey! What you doing? You done mess up, son!', 'Miracle Ash Says!',
            {
                positionClass: 'toast-top-center',
                containerId: 'toast-top-center',
                "showMethod": "slideDown",
                "hideMethod": "slideUp",
                timeOut: 3000
            });
    });

    // modal autofocus issue fix
    $('.modal').on('shown.bs.modal', function () {
        $(this).find('[autofocus]').focus();
    });

    // Users - Add user: Radios for Account/Farm Level
    $('input[type="radio"]').click(function () {
        var AccLvlvalue = $(this).val();
        $("div.rolesLvlContainer").hide();
        //-- $("div.rolesLvlContainer").toggleClass('d-none');
        $("#d-" + AccLvlvalue).show();
    });

    // Initssssss
    InitTooltips();
});



// Init Tooltips
function InitTooltips() {
    $('[data-toggle="tooltip"]').tooltip({ trigger: 'hover' });
    $('[data-popup=tooltip]').tooltip({ trigger: 'hover' });
    $('[rel="tooltip"]').tooltip({ trigger: 'hover' });
    $('[rel="popover"]').popover();
    $('[data-popup="popover"]').popover();
    //-
    // $(this).tooltip('hide'); // if needed
}