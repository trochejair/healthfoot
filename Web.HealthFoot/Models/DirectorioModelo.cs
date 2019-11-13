using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.HealthFoot.Models
{
    public class DirectorioModelo
    {

        private List<Directorio> Directorio;

        public DirectorioModelo()
        {

            UsuarioModelo UsuarioModelo = new UsuarioModelo();

            this.Directorio = new List<Directorio> {

                new Directorio{

                    Id = 1,
                    Titular = "Leonardo",
                    Pais = "México",
                    Estado = "México",
                    Ciudad = "Temoaya",
                    Calle = "Fracc. Rinconada del valle HDA Mezquite Lot 7 C",
                    CP = "50850",
                    Referencia = "Botes Verdes",
                    Telefono = "5546524680",
                    Status = 1,
                    Usuario = UsuarioModelo.find(1)

                },
                new Directorio{

                    Id = 2,
                    Titular = "Leonardo",
                    Pais = "México",
                    Estado = "México",
                    Ciudad = "Temoaya",
                    Calle = "Fracc. Rinconada del valle HDA Mezquite Lot 6 C",
                    CP = "50850",
                    Referencia = "Botes Verdes",
                    Telefono = "5546524680",
                    Status = 1,
                    Usuario = UsuarioModelo.find(1)

                },
                new Directorio{

                    Id = 3,
                    Titular = "Leonardo",
                    Pais = "México",
                    Estado = "México",
                    Ciudad = "Metepec",
                    Calle = "Av. Tecnologico 1050",
                    CP = "00000",
                    Referencia = "Botes Verdes",
                    Telefono = "5546524680",
                    Status = 1,
                    Usuario = UsuarioModelo.find(2)

                }

            };

        }

        public List<Directorio> findAll()
        {

            return this.Directorio;

        }

        public Directorio find(int Id)
        {

            return this.Directorio.Single(p => p.Id == Id);

        }

        public List<Directorio> findUsuario(int Id)
        {

            List<Directorio> dir = new List<Directorio>();
            foreach (Directorio dirus in this.Directorio)
            {

                if (dirus.Usuario.Id == Id)
                {

                    dir.Add(dirus);

                }

            }
            return dir;

        }

    }
}