
$("#btnEditar").click(function () {

    var id = $(".Id").val();
    var nombre = $(".Nombre").val();
    var apellido = $(".Apellido").val();
    var telefono = $(".Telefono").val();
    var direccion = $(".Direccion").val();
    var genero = $(".Genero").val();
    var cedula = $(".Cedula").val();


    if (nombre == "") {
        notif({
            msg: "Ingresar nombre",
            type: "error"
        });

    }
    if (apellido == "") {
        notif({
            msg: "Ingresar apellido",
            type: "error"
        });

    }
    if (telefono == "") {
        notif({
            msg: "Ingresar telefono",
            type: "error"
        });

    }
    if (direccion == "") {
        notif({
            msg: "Ingresar direccion",
            type: "error"
        });

    }
    if (genero == "") {
        notif({
            msg: "Ingresar genero",
            type: "error"
        });

    }
    if (cedula == "") {
        notif({
            msg: "Ingresar cedula",
            type: "error"
        });

    }
    else {
        //hacer peticion al servidor con AJAX
        var xhr = $.ajax({
            url: "/Clientes/ActualizarCliente",
            type: "POST",
            data: {
                "Id":id,
                "Nombre": nombre,
                "Apellido": apellido,
                "Telefono": telefono,
                "Direccion": direccion,
                "Genero": genero,
                "Cedula": cedula
            }

        });

        xhr.done(function () {
            notif({
                msg: "Cliente Guardado",
                type: "success"
            });         

            setTimeout(function () {
                document.location.href = "/Clientes";
            }, 2000);


        });

        xhr.fail(function () {
            notif({
                msg: "Error al guardar cliente",
                type: "success"
            });
        });
    }
});