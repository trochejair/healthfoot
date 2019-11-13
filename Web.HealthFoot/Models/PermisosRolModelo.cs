using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.HealthFoot.Models
{
    public class PermisosRolModelo
    {

        private List<PermisosRol> PermisosRol;

        public PermisosRolModelo()
        {

            PermisoModelo PermisoModelo = new PermisoModelo();
            RolModelo RolModelo = new RolModelo();

            this.PermisosRol = new List<PermisosRol> {

                new PermisosRol{

                    Id = 1,
                    Permiso = PermisoModelo.find(1),
                    Rol = RolModelo.find(2)

                },
                new PermisosRol{

                    Id = 2,
                    Permiso = PermisoModelo.find(2),
                    Rol = RolModelo.find(2)

                },
                new PermisosRol{

                    Id = 3,
                    Permiso = PermisoModelo.find(3),
                    Rol = RolModelo.find(2)

                },
                new PermisosRol{

                    Id = 4,
                    Permiso = PermisoModelo.find(4),
                    Rol = RolModelo.find(2)

                }

            };

        }

        public List<PermisosRol> findAll()
        {

            return this.PermisosRol;

        }

        public PermisosRol find(int Id)
        {

            return this.PermisosRol.Single(p => p.Id == Id);

        }

        public List<PermisosRol> findRol(int Id)
        {

            List<PermisosRol> per = new List<PermisosRol>();
            foreach (PermisosRol perrol in this.PermisosRol) {

                if (perrol.Rol.Id==Id) {

                    per.Add(perrol);

                }

            }
            return per;

        }

    }
}