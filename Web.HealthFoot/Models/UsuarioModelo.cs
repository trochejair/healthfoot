using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.HealthFoot.Models
{
    public class UsuarioModelo
    {

        private List<Usuario> Usuario;

        public UsuarioModelo()
        {

            RolModelo RolModelo = new RolModelo();

            this.Usuario = new List<Usuario> {

                new Usuario{

                    Id = 1,
                    Nombre = "Leonardo",
                    ApellidoP = "Arroyo",
                    ApellidoM = "Sánchez",
                    Email = "leonardo7522@gmail.com",
                    Password = "123456",
                    Rol = RolModelo.find(2),
                    Registro = "10/Nov/2019",
                    UltimaVisita = "10/Nov/2019",
                    Status = 1

                },
                new Usuario{

                    Id = 2,
                    Nombre = "Cliente",
                    ApellidoP = "Arroyo",
                    ApellidoM = "Sánchez",
                    Email = "Cliente7522@gmail.com",
                    Password = "123456",
                    Rol = RolModelo.find(1),
                    Registro = "10/Nov/2019",
                    UltimaVisita = "10/Nov/2019",
                    Status = 1

                }

            };

        }

        public List<Usuario> findAll()
        {

            return this.Usuario;

        }

        public Usuario find(int Id)
        {

            return this.Usuario.Single(p => p.Id == Id);

        }

    }
}