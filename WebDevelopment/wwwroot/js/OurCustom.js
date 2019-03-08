
//<div class="modal fade" id="large-Modal" tabindex="-1" role="dialog" style="z-index: 1050; display: none;" aria-hidden="true">
//  <div class="modal-dialog modal-lg" role="document">
//    <div id="dialogContent" class="modal-content">

//    </div>
//  </div>
// </div>
//В каждом html где вызывается модальное окно должен быть этот отрезок
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
    // This will make every element with the class "date-picker" into a DatePicker element
    $('.date-picker').datepicker();
});