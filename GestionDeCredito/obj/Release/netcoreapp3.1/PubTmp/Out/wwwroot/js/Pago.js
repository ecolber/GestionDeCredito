$("#btnGuardar").click(function () {

   
    var cliente = $("#IdCliente").val();
    var monto = $("#MontoPagado").val();


    if (monto == "") {
        notif({
            msg: "Ingresar Monto",
            type: "error"
        });

    }
    else {
        //hacer peticion al servidor con AJAX
        var xhr = $.ajax({
            url: "GuardarPago",
            type: "POST",
            data: {
                "IdCliente": cliente,
                "MontoPado": monto,
                "Interes": interes,
                "Plazo": plazo,
                "Estado": estado
            }

        });

        xhr.done(function () {
            notif({
                msg: "Prestamo Guardado",
                type: "success"
            });

            $("#Nombre").val("");
            $("#Apellido").val("");
            $("#Telefono").val("");
            $("#Direccion").val("");
            $("#Genero").val("");
            $("#Cedula").val("");

            setTimeout(function () {
                document.location.href = "/Prestamo";
            }, 2000);


        });

        xhr.fail(function () {
            notif({
                msg: "Error al guardar prestamo",
                type: "success"
            });
        });
    }
});



