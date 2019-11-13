using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.HealthFoot.Models
{
    public class PermisoModelo
    {

        private List<Permiso> Permisos;

        public PermisoModelo() {

            this.Permisos = new List<Permiso> {

                new Permiso{

                    Id = 4,
                    Nombre = "Usuario"

                },
                new Permiso{

                    Id = 3,
                    Nombre = "Suministros"

                },
                new Permiso{

                    Id = 2,
                    Nombre = "Ventas"

                },
                new Permiso{

                    Id = 1,
                    Nombre = "Embarque"

                },

            };

        }

        public List<Permiso> findAll() {

            return this.Permisos;

        }

        public Permiso find(int Id) {

            return this.Permisos.Single(p => p.Id==Id);

        }

    }
}