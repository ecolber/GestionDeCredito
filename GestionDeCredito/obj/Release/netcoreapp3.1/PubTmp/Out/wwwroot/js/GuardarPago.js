$("#btnGuardar").click(function () {

    var prestamo = $("#IdPrestamo").val();
    var monto = $("#MontoPagado").val();


    if (monto == "") {
        notif({
            msg: "Ingresar MontoPagado",
            type: "error"
        });

    }
    else {
        //hacer peticion al servidor con AJAX
        var xhr = $.ajax({
            url: "../GuardarPago",
            type: "POST",
            data: {
                "IdPrestamo": prestamo,
                "MontoPagado": monto
            }

        });

        xhr.done(function () {
            notif({
                msg: "Pago Guardado",
                type: "success"
            });

            setTimeout(function () {
                document.location.href = "/Pago";
            }, 2000);


        });

        xhr.fail(function () {
            notif({
                msg: "Error al guardar pago",
                type: "success"
            });
        });
    }
});



