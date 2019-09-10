using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace ProyectoGradoUtap2019.web.Views.Gestionar_Usuarios
{
    public partial class GestionarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionUser"] == null) Response.Redirect("../Login/Login.aspx");

            getUsuarios();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Logica.Models.clsTBUsuarios obclsTBUsuarios = new Logica.Models.clsTBUsuarios
                {
                    stNombre = txtNombre.Text,
                    stApellido = txtApellido.Text,
                    stUsuario = txtUsuario.Text,
                    stContraseña = txtContraseña.Text,
                    stCorreo = txtCorreo.Text,
                    stTipoUs = ddlTipoUsuario.SelectedItem.Text
                };

                Controllers.GestionUsuariosController obGestionUsuariosController = new Controllers.GestionUsuariosController();
                string stMensaje = obGestionUsuariosController.addUsuarioController(obclsTBUsuarios);

                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('MENSAJE!', '" + stMensaje + "!', 'info')</Script>");

                getUsuarios();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = " ";
            txtApellido.Text = " ";
            txtCorreo.Text = " ";
            txtUsuario.Text = " ";
            txtContraseña.Text = " ";
            ddlTipoUsuario.SelectedIndex.Equals(0);
        }

        protected void gvwUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int inIndice = Convert.ToInt32(e.CommandArgument);
            }
            catch (Exception ex) { throw ex; }
        }

        void getUsuarios()
        {
            try
            {
                Controllers.GestionUsuariosController obGestionUsuariosController = new Controllers.GestionUsuariosController();
                List<Logica.Models.clsTBUsuarios> lstclsTBUsuarios = obGestionUsuariosController.getUsuarioController();

                if (lstclsTBUsuarios.Count > 0) gvwUsuarios.DataSource = lstclsTBUsuarios;
                else gvwUsuarios.DataSource = null;

                gvwUsuarios.DataBind();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }
    }
}