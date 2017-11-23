$(function () {
    $.validator.addMethod('date',
        function (value, element) {
            var check = true,
                re = /^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-](\d{4})$/ //for for dd/mm/yyyy
                // re = /^(\d{4})[\/\-](0?[1-9]|1[012])[\/\-](0?[1-9]|[12][0-9]|3[01])$/; for yyyy/mm/dd

            if (re.test(value)) {
                var adata = value.match(re);
                var yyyy = parseInt(adata[1], 10);
                var mm = parseInt(adata[2], 10);
                var dd = parseInt(adata[3], 10);

                if ((mm == 4 || mm == 6 || mm == 9 || mm == 11) && dd == 31) {
                    check = false;
                }
                else if (mm == 2) {
                    var isLeap = (yyyy % 4 == 0 && (yyyy % 100 != 0 || yyyy % 400 == 0));

                    if (dd > 29 || (dd == 29 && !isLeap)) {
                        check = false;
                    }
                }
            } else check = false;

            return this.optional(element) || check;
        });

    $('.date').datetimepicker({

        format: 'DD/MM/YYYY'
    });


   
});