using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MineraLaPitaya.Models
{
    public class Proveedores
    {
        [Key, Required]
        public int IdProveedor { get; set; }
        [Display(Name = "Nombre del Proveedor"), Required]
        public string NombreProveedor { get; set; }
        [Display(Name = "Direccion"), Required]
        public string Direccion { get; set; }
        [Display(Name = "Ciudad"), Required]
        public string Ciudad { get; set; }
        [Display(Name = "Estado"), Required]
        public string Estado { get; set; }
        [Display(Name = "Telefono"), Required, StringLength(10)]
        public string Telefono { get; set; }
        [Display(Name = "Nombre Contacto"), Required]
        public string NombreCon { get; set; }
        [Display(Name = "Email Contacto"), Required]
        public string EmailCon { get; set; }
        [Display(Name = "Telefono Contacto"), Required, StringLength(10)]
        public string TelefonoCon { get; set; }
        [Display(Name = "Extension"), Required]
        public string Extension { get; set; }
        [Display(Name = "Clasificacion"), Required]
        public string Clasificacion { get; set; }
        [Display(Name = "Estatus"), Required, StringLength(1)]
        public string Estatus { get; set; }

        //Cada proveedor tiene una coleccion de productos o servicios
        public virtual ICollection<Productos> ProductosActivos { get; set; }

    }
}