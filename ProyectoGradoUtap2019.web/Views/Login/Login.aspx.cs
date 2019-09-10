using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGradoUtap2019.web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        string stTipo_Usuario = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInicioSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtUsuario.Text)) stMensaje += "Ingrese Email,";
                if (string.IsNullOrEmpty(txtContraseña.Text)) stMensaje += "Ingrese Contraseña,";
                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));
                if (chkCordinador.Checked)
                    stTipo_Usuario = "Coordinador";
                else
                    stTipo_Usuario = "Monitor";

                //Defino Objeto con propiedades
                Logica.Models.clsTBUsuarios obclsTBUsuarios = new Logica.Models.clsTBUsuarios
                {
                    stUsuario = txtUsuario.Text,
                    stContraseña = txtContraseña.Text,
                    stTipoUs = stTipo_Usuario
                };

                //Instancio Controlador
                Controllers.LoginController obLogingController = new Controllers.LoginController();
                bool blBandera = obLogingController.getValidarUsuarioController(obclsTBUsuarios);

                if (blBandera)
                {
                    Session["SessionUser"] = txtUsuario.Text;

                    if (chkCordinador.Checked)
                        Response.Redirect("../Index/IndexCordinador.aspx");//Redirecciono

                    Response.Redirect("../Index/Index.aspx");//Redirecciono
                }
                else
                    throw new Exception("Usuario o password incorrectos");
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }

        }
    }
}