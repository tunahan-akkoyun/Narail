var jQueryCalis = $.noConflict(true);
(function ($) {
    $(document).ready(function () {
        $('#example').DataTable({
            "lenghtMenu": [[25, 50, -1], [25, 50, "Tümü"]],

            "language": {
                "url": "//cdn.datatables.net/plug-ins/1.10.12/i18n/Turkish.json"
            }
        });
        var table = $('#example').DataTable();
        $('#example').show();
    });
})(jQueryCalis);