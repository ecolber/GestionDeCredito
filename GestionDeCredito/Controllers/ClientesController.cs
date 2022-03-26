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
    public class ClientesController : Controller
    {
        public readonly MyDBContext _context;
        private readonly ILogger<ClientesController> _logger;

        public ClientesController(ILogger<ClientesController> logger, MyDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            List<Cliente> clientes = _context.Cliente.ToList();
            return View("Clientes",clientes);
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult CrearCliente(Cliente cliente)
        {
            try
            {
                cliente.FechaCreacion = Convert.ToString(DateTime.Now);
                _context.Cliente.Add(cliente);
                _context.SaveChanges();

                List<Cliente> clientes = _context.Cliente.ToList();
                return View("Clientes", clientes);

            }
            catch (Exception)
            {

                throw;
            }

           
        }

        public IActionResult ListaClientes()
        {
            List<Cliente> clientes = _context.Cliente.ToList();
            return View(clientes);
        }

        public IActionResult EditarCliente(int id)
        {
            Cliente modelo = _context.Cliente.Where(c => c.Id == id).FirstOrDefault();
            return View("EditarCliente", modelo);
        }

        public IActionResult ActualizarCliente(Cliente cliente)
        {
            //valor actual desde bases
            Cliente clienteActual = _context.Cliente
                .Where(a => a.Id == cliente.Id).FirstOrDefault();

            clienteActual.Nombre = cliente.Nombre;
            clienteActual.Apellido = cliente.Apellido;
            clienteActual.Telefono = cliente.Telefono;
            clienteActual.Direccion = cliente.Direccion;
            clienteActual.Genero = cliente.Genero;
            clienteActual.Cedula = cliente.Cedula;
            _context.SaveChanges();

            List<Cliente> clientes = _context.Cliente.ToList();

            return View("Clientes", clientes);

        }

        public IActionResult EliminarCliente(int id)
        {       
            //Prestamo prestamo = _context.Prestamo.Where(p => p.IdCliente == id).FirstOrDefault();

            //if(prestamo != null)
            //{

            //}
            Cliente cliente = _context.Cliente
                .Where(a => a.Id == id).FirstOrDefault();

            _context.Remove(cliente);
            _context.SaveChanges();
            List<Cliente> clientes = _context.Cliente.ToList();

            return View("Clientes", clientes);
        }
    }
}
