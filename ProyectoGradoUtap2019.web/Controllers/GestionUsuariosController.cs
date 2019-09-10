using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGradoUtap2019.web.Controllers
{
    public class GestionUsuariosController
    {
        public string addUsuarioController(Logica.Models.clsTBUsuarios obclsTBUsuarios)
        {
            try
            {
                Logica.BL.clsProcesos obclsProcesos = new Logica.BL.clsProcesos();
                return obclsProcesos.addUsuario(obclsTBUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Logica.Models.clsTBUsuarios> getUsuarioController(Logica.Models.clsTBUsuarios obclsTBUsuarios)
        {
            try
            {
                Logica.BL.clsProcesos obclsProcesos = new Logica.BL.clsProcesos();
                return obclsProcesos.getUsuarios(obclsTBUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Logica.Models.clsTBUsuarios> getUsuarioController()
        {
            try
            {
                Logica.BL.clsProcesos obclsProcesos = new Logica.BL.clsProcesos();
                return obclsProcesos.getUsuarios();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}