//<div class="modal fade" id="large-Modal" tabindex="-1" role="dialog" style="z-index: 1050; display: none;" aria-hidden="true">
//  <div class="modal-dialog modal-lg" role="document">
//    <div id="dialogContent" class="modal-content">

//    </div>
//  </div>
// </div>
//В каждом html где вызывается модальное окно должен быть этот отрезок

function ShowModal(windowName) {
    var w = $("#" + windowName).data("kendoWindow");
    w.open();
}

$(function () {
    $.ajaxSetup({ cache: false });
    $(".modalLargeBtn").click(function (e) {

        e.preventDefault();
        $.get(this.href, function (data) {
            $('#dialogContent').html(data);
            $('#large-Modal').modal('show');
        });
    });
});

$(function () {
    $.ajaxSetup({ cache: false });
    $(".modalmdBtn").click(function (e) {

        e.preventDefault();
        $.get(this.href, function (data) {
            $('#dialogmdContent').html(data);
            $('#md-Modal').modal('show');
        });
    });
});

$(function () {
    $.ajaxSetup({ cache: false });
    $(".modalxlBtn").click(function (e) {

        e.preventDefault();
        $.get(this.href, function (data) {
            $('#dialogxlContent').html(data);
            $('#xl-Modal').modal('show');
        });
    });
});


$(function () {
    $.ajaxSetup({ cache: false });
    $(".modalConfirmDeleteBtn").click(function (e) {

        e.preventDefault();
        $.get(this.href, function (data) {
            $('#dialogDeleteContent').html(data);
            $('#small-Modal').modal('show');
        });
    });
});


$(function () {
    // This will make every element with the class "date-picker" into a DatePicker element
    $('.date-picker').datepicker();
});


