using GestionDeCredito.Data;
using GestionDeCredito.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDeCredito.Controllers
{
    public class PagoController : Controller
    {
        public readonly MyDBContext _context;
        private readonly ILogger<PagoController> _logger;

        public PagoController(ILogger<PagoController> logger, MyDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public ActionResult Index()
        {
            PrestamoPago PrestamoPago = new PrestamoPago();
            PrestamoPago.Clientes = _context.Cliente.ToList();
            PrestamoPago.Prestamos = _context.Prestamo.ToList();
            PrestamoPago.Pagos = _context.Pago.ToList();
            return View(PrestamoPago);
        }

        public IActionResult CrearPago(int id,int idcliente)
         {
            PrestamoPago PrestamoPago = new PrestamoPago();
            PrestamoPago.Clientes = _context.Cliente.Where(c => c.Id == idcliente).ToList();
            PrestamoPago.Prestamos = _context.Prestamo.Where(p => p.Id == id).ToList();
            PrestamoPago.Pagos = _context.Pago.ToList();

            //Prestamo Prestamo = _context.Prestamo.Where(p => p.Id == id).FirstOrDefault();

            return View(PrestamoPago);

        }

        public IActionResult GuardarPago(Pago pago)
        {
            //Cliente modeloc = _context.Cliente.Where(c => c.Id == prestamo.IdCliente).FirstOrDefault();

            //prestamo.Cliente = modeloc;
            pago.FechaPago = DateTime.Now;
            _context.Pago.Add(pago);
            

            //actualizar saldo
            Prestamo prestamo = _context.Prestamo.Where(p => p.Id == pago.IdPrestamo).FirstOrDefault();
            prestamo.Saldo = prestamo.Saldo - pago.MontoPagado;

            _context.SaveChanges();


            return RedirectToAction("Index");


        }


    }
}
