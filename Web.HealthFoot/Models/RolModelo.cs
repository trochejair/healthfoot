using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.HealthFoot.Models
{
    public class RolModelo
    {

        private List<Rol> Rol;

        public RolModelo()
        {

            
            this.Rol = new List<Rol> {

                new Rol{

                    Id = 1,
                    Nombre = "Cliente",
                    Status = 1

                },
                new Rol{

                    Id = 2,
                    Nombre = "Admin",
                    Status = 1

                }

            };

        }

        public List<Rol> findAll()
        {

            return this.Rol;

        }

        public Rol find(int Id)
        {

            return this.Rol.Single(r => r.Id == Id);

        }

    }
}