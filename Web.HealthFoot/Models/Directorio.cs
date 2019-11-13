using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.HealthFoot.Models
{
    public class Directorio
    {

        public int Id { get; set; }
        public String Titular { get; set; }
        public String Pais { get; set; }
        public String Estado { get; set; }
        public String Ciudad { get; set; }
        public String Calle { get; set; }
        public String CP { get; set; }
        public String Referencia { get; set; }
        public String Telefono { get; set; }
        public int Status { get; set; }
        public Usuario Usuario { get; set; }

    }
}