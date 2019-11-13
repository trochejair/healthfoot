using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.HealthFoot.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        public String Nombre { get; set; }
        public String ApellidoP { get; set; }
        public String ApellidoM { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public Rol Rol { get; set; }
        public int Status { get; set; }
        public String Registro { get; set; }
        public String UltimaVisita { get; set; }

    }
}