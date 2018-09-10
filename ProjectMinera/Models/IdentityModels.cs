using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MineraLaPitaya.Models;

namespace ProjectMinera.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        public ApplicationUser() { }
        public ApplicationUser(RegisterViewModel model)
        {
            if (!System.String.IsNullOrEmpty(model.userID))
                this.Id = model.userID;
            this.UserName = model.Email;
            this.Email = model.Email;
            this.Nombre = model.Nombre;
            this.ApellidoPaterno = model.ApellidoPaterno;
            this.ApellidoMaterno = model.ApellidoMaterno;
            this.PasswordHash = model.hash;
            this.SecurityStamp = model.stamp;
        }

        public ApplicationUser(RegisterViewModel model, ApplicationDbContext db) : this(model)
        {
            var userFromDB = db.Users.Find(model.userID);
            this.EmailConfirmed = userFromDB.EmailConfirmed;
            this.PhoneNumberConfirmed = this.PhoneNumberConfirmed;
            this.TwoFactorEnabled = this.TwoFactorEnabled;
            this.LockoutEnabled = this.LockoutEnabled;
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [DisplayName("Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [DisplayName("Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [DisplayName("Eliminado")]
        public bool Eliminado{ get; set; }

        [DisplayName("Nombre Completo")]
        public string NombreCompleto
        {
            get { return this.Nombre + " " + this.ApellidoPaterno + " " + this.ApellidoMaterno; }
        }

        public virtual ICollection<SolicitudProveedores> SolicitudProveedores { get; set; }
        public virtual ICollection<Proveedores> Proveedores { get; set; }
        public virtual ICollection<Productos> Productos { get; set; }
        public virtual ICollection<TiposProveedores> TiposProveedores { get; set; }

        public static class RoleNames
        {
            public const string Empleado = "Empleado";
            public const string Gerente = "Gerente";
            public const string ADMIN = "Admin";
        }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Productos> Productos { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<TiposProveedores> TiposProveedores { get; set; }

        public DbSet<SolicitudProveedores> SolicitudProveedores { get; set; }

        
    }
}