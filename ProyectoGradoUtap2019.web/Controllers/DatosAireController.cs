using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoGradoUtap2019.web.Controllers
{
    public class DatosAireController
    {
        public List<Logica.Models.clsTBDatosAire> getDatosAireController(int inIdAire)
        {
            try
            {
                Logica.BL.clsProcesos obclsProcesos = new Logica.BL.clsProcesos();
                return obclsProcesos.getDatosAire(inIdAire);
            }
            catch (Exception ex) { throw ex; }
        }

    }
}