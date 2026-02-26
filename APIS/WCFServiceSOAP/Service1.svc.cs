using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServiceSOAP.Datos;

namespace WCFServiceSOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        private static List<Producto> producto = new List<Producto>() 
        { 
            new Producto {Id = 1, Nombre = "Laptop", Precio = 300000}, 
            new Producto {Id = 2, Nombre = "Telefono", Precio = 130000}
        };
        public string AgregarProducto(int id, string nombre, double precio)
        {
            producto.Add(new Producto {Id = id, Nombre = nombre, Precio = precio});
            return "Producto Agregado";
        }
        public string ObtenerProductosConcatenado()
        {
            var resultado = "";
            foreach (var item in producto)
            {
                resultado += $"ID: {item.Id} || Nombre: {item.Nombre} || Precio: {item.Precio}\n";
            }
            return resultado;
        }
        public int Calculadora(int a, int b, string operacion)
        {
            Operaciones ope = new Operaciones();
            int resultado = ope.ResultadoOperacion(a, b, operacion);
            return resultado;
        }

        
    }
}
