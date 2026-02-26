using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIServices.Controllers
{
    [RoutePrefix("api/productos")]
    public class ProductosController : ApiController
    {
        private static List<Productos> productos = new List<Productos>() 
        { 
            new Productos{ Id = 1, Nombre = "Laptop", Precio =300000},
            new Productos{ Id = 2, Nombre = "Celular", Precio =130000}
        };

        //GET : api/productos 
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetProdcutos()
        {
            return Ok(productos);
        }

        //GET : api/productos/1 
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetProdcutos(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(producto);
            }
        }

        //POST: api/productos
        [HttpPost]
        [Route("")]
        public IHttpActionResult PostProductos([FromBody] Productos produc)
        {
            if (produc == null)
            {
                return BadRequest("El producto no puede ser vacío.");
            }
            else
            {
                productos.Add(produc);
                return Created($"/api/productos/{produc.Id}", produc);
            }
        }

        //PUT: api/productos/1
        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult PutProducto(int id, [FromBody] Productos updateProducto)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            else
            {
                producto.Nombre = updateProducto.Nombre;    
                producto.Precio = updateProducto.Precio;

                return StatusCode(System.Net.HttpStatusCode.NoContent);
            }
        }

        //DELETE: api/productos/1
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult DeleteProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            else
            {
                productos.Remove(producto);
                return StatusCode(System.Net.HttpStatusCode.NoContent);
            }
        }
    }
    }
