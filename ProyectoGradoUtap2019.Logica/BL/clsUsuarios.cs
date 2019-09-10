using System;
using System.Data;
using System.Data.SqlClient;
namespace ProyectoGradoUtap2019.Logica.BL
{
    public class clsUsuarios
    {
        SqlConnection _SqlConnection = null; //Me permite establecer comunicacion con BD
        SqlCommand _SqlCommand = null; //Me permite ejecutar conmandos SQL
        SqlDataAdapter _SqlDataAdapter = null; //Me permite adaptar un conjunto de datos SQL
        string stConexion = string.Empty;//Cadena de conexion

        SqlParameter _SqlParameter = null;

        public clsUsuarios()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }
        /// <summary>
        /// Validar usuario
        /// </summary>
        /// <param name="obclsUsuarios">Objeto usuario</param>
        /// <returns>confirmacion de consulta</returns>
        public bool getValidarUsuario(Models.clsTBUsuarios obclsUsuarios)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultarUsuario", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@cLogin", obclsUsuarios.stUsuario));
                _SqlCommand.Parameters.Add(new SqlParameter("@cPassword", obclsUsuarios.stContraseña));
                _SqlCommand.Parameters.Add(new SqlParameter("@cCoordinador", obclsUsuarios.stTipoUs));

                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                if (dsConsulta.Tables[0].Rows.Count > 0) return true;
                else return false;
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }
    }
}
