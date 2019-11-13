using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.HealthFoot.Models
{
    public class PermisosRol
    {

        public int Id { get; set; }
        public Permiso Permiso { get; set; }
        public Rol Rol { get; set; }

    }
}