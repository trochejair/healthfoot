using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.HealthFoot.Models;

namespace Web.HealthFoot.Controllers
{
    public class RolesController : Controller
    {

        public ActionResult List()
        {
            RolModelo Rol = new RolModelo();
            ViewBag.Rol = Rol.findAll();
            return View();
        }

        public ActionResult Show(int id)
        {
            RolModelo Rol = new RolModelo();
            ViewBag.Rol = Rol.find(id);
            PermisosRolModelo PermisosRol = new PermisosRolModelo();
            ViewBag.PermisosRol = PermisosRol.findRol(id);
            return View();
        }

        public ActionResult Create()
        {
            PermisoModelo Permiso = new PermisoModelo();
            ViewBag.Permiso = Permiso.findAll().OrderBy(pm => pm.Id).ToList();
            return View();
        }

        public ActionResult Edit(int id)
        {

            RolModelo Rol = new RolModelo();
            ViewBag.Rol = Rol.find(id);
            PermisosRolModelo PermisosRol = new PermisosRolModelo();
            ViewBag.PermisosRol = PermisosRol.findRol(id).OrderBy(pr => pr.Permiso.Id).ToList();
            PermisoModelo Permiso = new PermisoModelo();
            ViewBag.Permiso = Permiso.findAll().OrderBy(pm => pm.Id).ToList();
            return View();

        }

        public String Delete()
        {
            return "Eliminado";
        }

        public String Update()
        {
            return "Actualizado";
        }

        public String Store()
        {
            return "Creado";
        }

    }
}