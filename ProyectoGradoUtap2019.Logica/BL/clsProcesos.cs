using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGradoUtap2019.Logica.BL
{
    public class clsProcesos
    {

        public string addUsuario(Models.clsTBUsuarios obclsUsuarios)
        {
            try
            {
                using (Entidades.bdProyectoGradoEntities obbdProyectoGradoEntities = new Entidades.bdProyectoGradoEntities())
                {
                    Entidades.Usuarios obUsuarios = new Entidades.Usuarios
                    {
                        Id = obclsUsuarios.inId,
                        Nombre = obclsUsuarios.stNombre,
                        Apellido = obclsUsuarios.stApellido,
                        Usuario = obclsUsuarios.stUsuario,
                        Contraseña = obclsUsuarios.stContraseña,
                        Correo = obclsUsuarios.stCorreo,
                        Tipo_Usuario = Convert.ToInt32(obclsUsuarios.stTipoUs)
                    };

                    obbdProyectoGradoEntities.Usuarios.Add(obUsuarios);
                    obbdProyectoGradoEntities.SaveChanges();

                    return "Se realizo proceso con exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Models.clsTBUsuarios> getUsuarios(Models.clsTBUsuarios obclsUsuarios)
        {
            try
            {
                using (Entidades.bdProyectoGradoEntities obbdProyectoGradoEntities = new Entidades.bdProyectoGradoEntities())
                {
                    return (from q in obbdProyectoGradoEntities.Usuarios
                            join a in obbdProyectoGradoEntities.Tipo_Usuario on q.Tipo_Usuario equals a.Id
                            where q.Usuario == obclsUsuarios.stUsuario
                            select new Models.clsTBUsuarios
                            {
                                inId = q.Id,
                                stNombre = q.Nombre,
                                stApellido = q.Apellido,
                                stUsuario = q.Usuario,
                                stContraseña = q.Contraseña,
                                stTipoUs = a.Descripcion

                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Models.clsTBUsuarios> getUsuarios()
        {
            try
            {
                using (Entidades.bdProyectoGradoEntities obbdProyectoGradoEntities = new Entidades.bdProyectoGradoEntities())
                {
                    return (from q in obbdProyectoGradoEntities.Usuarios
                            join a in obbdProyectoGradoEntities.Tipo_Usuario on q.Tipo_Usuario equals a.Id
                            select new Models.clsTBUsuarios
                            {
                                inId = q.Id,
                                stNombre = q.Nombre,
                                stApellido = q.Apellido,
                                stUsuario = q.Usuario,
                                stContraseña = q.Contraseña,
                                stTipoUs = a.Descripcion
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Models.clsTBDatosAire> getDatosAire(int inIdAire)
        {
            try
            {
                using (Entidades.bdProyectoGradoEntities obbdProyectoGradoEntities = new Entidades.bdProyectoGradoEntities())
                {
                    return (from q in obbdProyectoGradoEntities.Datos_Aire
                            where q.Id == inIdAire
                            select new Models.clsTBDatosAire
                            {
                                inIdAire = q.Id,
                                stNombre = q.Nombre,
                                inTemperatura = q.Temperatura,
                                stUltimaRev = q.Ultima_Revision,
                                stProximaRev = q.Proxima_Revision,
                                stConsumoMen = q.Consumo_mes,
                                stEstadoMotor = q.Estado_Motor
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
