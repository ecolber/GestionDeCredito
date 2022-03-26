$("#btnGuardar").click(function () {

    var cliente = $("#Cliente").val();
    var monto = $("#Monto").val();
    var interes = $("#Interes").val();
    var plazo = $("#Plazo").val();
    var estado = $("#Estado").val();


    if (cliente == "") {
        notif({
            msg: "Ingresar cliente",
            type: "error"
        });

    }
    if (monto == "") {
        notif({
            msg: "Ingresar monto",
            type: "error"
        });

    }
    if (interes == "") {
        notif({
            msg: "Ingresar interes",
            type: "error"
        });

    }
    if (plazo == "") {
        notif({
            msg: "Ingresar plazo",
            type: "error"
        });

    }
    if (estado == "") {
        notif({
            msg: "Ingresar estado",
            type: "error"
        });

    }
    else {
        //hacer peticion al servidor con AJAX
        var xhr = $.ajax({
            url: "CrearPrestamo",
            type: "POST",
            data: {
                "IdCliente": cliente,
                "Monto": monto,
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



