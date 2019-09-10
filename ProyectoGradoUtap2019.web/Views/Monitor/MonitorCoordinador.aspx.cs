using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace ProyectoGradoUtap2019.web.Views.Monitor
{
    public partial class MonitorCoordinador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["SessionUser"] == null)
                    Response.Redirect("../Login/Login.aspx");
            }
        }

        protected void btnConfigurar_Click(object sender, EventArgs e)
        {

        }

        void getDatosAire()
        {
            try
            {
                Controllers.DatosAireController obDatosAireController = new Controllers.DatosAireController();
                List<Logica.Models.clsTBDatosAire> lstclsTBDatosAire = obDatosAireController.getDatosAireController(1);

                if (lstclsTBDatosAire.Count > 0)
                {
                    
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }
    }
}