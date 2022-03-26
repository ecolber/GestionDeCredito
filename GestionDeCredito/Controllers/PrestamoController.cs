using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDeCredito.Models;
using Microsoft.EntityFrameworkCore;
using GestionDeCredito.Data;
using Microsoft.Extensions.Logging;

namespace GestionDeCredito.Controllers
{
    public class PrestamoController : Controller
    {
        public readonly MyDBContext _context;
        private readonly ILogger<PrestamoController> _logger;

        public PrestamoController(ILogger<PrestamoController> logger, MyDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            //List<Prestamo> prestamos = _context.Prestamo.ToList();
            //List<Cliente> clientes = _context.Cliente.ToList();
            //return View(prestamos,clientes);
            ClientePrestamo ClientePrestamo = new ClientePrestamo();
            ClientePrestamo.Clientes = _context.Cliente.ToList();
            ClientePrestamo.Prestamos = _context.Prestamo.ToList();
            return View(ClientePrestamo);



        }

        public IActionResult CrearPrestamo(Prestamo prestamo)
        {
            Cliente modeloc = _context.Cliente.Where(c => c.Id == prestamo.IdCliente).FirstOrDefault();

            prestamo.Cliente = modeloc;
            prestamo.FechaCreacion = Convert.ToString(DateTime.Now);
            prestamo.Saldo = prestamo.Monto;
            _context.Prestamo.Add(prestamo);
            _context.SaveChanges();
            return RedirectToAction("Index");


        }

        public IActionResult Prestamo()
        {
            List<Cliente> clientes = _context.Cliente.ToList();
            return View("CrearPrestamo",clientes);
        }

        public IActionResult EditarPrestamo(int id)
        {

            //Cliente modeloc = _context.Cliente.Where(c => c.Id == id).FirstOrDefault();
            Prestamo modelo = _context.Prestamo.Where(p => p.Id == id).FirstOrDefault();
            return View("EditarPrestamo", modelo);
        }

        public IActionResult ActualizarPrestamo(Prestamo Prestamo)
        {
            //valor actual desde bases
            Prestamo prestamoActual = _context.Prestamo
                .Where(p => p.Id == Prestamo.Id).FirstOrDefault();

            prestamoActual.Monto = Prestamo.Monto;
            prestamoActual.Interes = Prestamo.Interes;
            prestamoActual.Plazo = Prestamo.Plazo;
            prestamoActual.Estado = Prestamo.Estado;
            _context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
