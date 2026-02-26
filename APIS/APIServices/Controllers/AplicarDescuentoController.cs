using APIServices.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIServices.Controllers
{
    [RoutePrefix("api/aplicaDescuento")]
    public class AplicarDescuentoController : ApiController
    {
        AplicaDescuento aplicar = new AplicaDescuento();

        [HttpPost]
        [Route("")]
        public IHttpActionResult PostAplicaDescuento([FromBody] AplicaDescuento descuento)
        {
            aplicar = new AplicaDescuento { Precio = descuento.Precio, Descuento = descuento.Descuento };
            
            if (descuento == null)
            {
                return BadRequest("No puede ser vacío.");
            }
            else
            {
                double decuentoReal = aplicar.Descuento / 100;
                double precio = aplicar.Precio - (aplicar.Precio * decuentoReal);
                aplicar.Precio = precio;
                return Created($"api/aplicaDescuento/El precio final es: {precio}", aplicar);
            }
        }

    }
}
