using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGradoUtap2019.web.Controllers
{
    public class LoginController
    {
        public bool getValidarUsuarioController(Logica.Models.clsTBUsuarios obclsTBUsuarios)
        {
            try
            {
                Logica.BL.clsUsuarios obclsUsuarios = new Logica.BL.clsUsuarios();
                return obclsUsuarios.getValidarUsuario(obclsTBUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}