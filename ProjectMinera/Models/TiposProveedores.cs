using MineraLaPitaya.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectMinera.Models
{
    public class TiposProveedores
    {
        [Key, Required]
        public int IdTipo { get; set; }
        [Required, Display(Name = "Tipo Proveedor")]
        public string NombreTipo { get; set; }

        public virtual ICollection<Proveedores> Proveedores{ get; set; }

        //Relacion con users       
        // ForeignKey => dbo.IdentityUser
        public string UserId { get; set; }

        [Display(Name = "Usuario")]
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}