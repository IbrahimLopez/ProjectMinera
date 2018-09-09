using ProjectMinera.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Display(Name = "Esta activo"), Required]
        public bool Activo { get; set; }
        [Display(Name = "Fecha de Creacion")]
        public DateTime FechaCreacion { get; set; }

        //Cada proveedor tiene una coleccion de productos o servicios
        public virtual ICollection<Productos> ProductosActivos { get; set; }

        //Relacion con users       
        // ForeignKey => dbo.IdentityUser        
        public string UserId { get; set; }

        [Display(Name = "Usuario")]        
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

    }
}