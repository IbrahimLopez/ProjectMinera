using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MineraLaPitaya.Models
{
    public class Productos
    {
        [Key, Required]
        public int IdProducto { get; set; }
        [Display(Name = "Nombre"), Required]
        public string Nombre { get; set; }
        [Display(Name ="Decripcion"), Required]
        public string Descripcion { get; set; }
        [Display(Name = "Tiempo de Respuesta"), Required]
        public TimeSpan TiempoRespuesta { get; set; }
        [Display(Name = "Capacidad de Produccion"), Required]
        public int CapacidadProd { get; set; }
        [Display(Name = "Lugar de Entrega"), Required]
        public string LugarEntrega { get; set; }

        
        public int IdProveedor { get; set; }
        public virtual Proveedores Proveedores { get; set; }

    }
}