using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wOficinaEmpleo
{
    internal class clsBuscarEmpleo
    {

       
            public int intIdEmpleo { get; set; }
            public string strNombreEmpleo { get; set; }
            public string strDescripcion { get; set; }
            public int intRangoSalarial { get; set; }
            public string strExperiencia { get; set; }

            public clsBuscarEmpleo()
            {

            }

            public clsBuscarEmpleo(int intIdEmpleo, string strNombreEmpleo, string strDescripcion, int intRangoSalarial, string strExperiencia)
            {
                this.intIdEmpleo = intIdEmpleo;
                this.strNombreEmpleo = strNombreEmpleo;
                this.strDescripcion = strDescripcion;
                this.intRangoSalarial = intRangoSalarial;
                this.strExperiencia = strExperiencia;
            }

            public DataTable consultarDatos()
            {
                // Establecer la conexión con la base de datos
                SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
                conexion.Open();

                // Crear un objeto DataTable para almacenar los resultados de la consulta
                DataTable dt = new DataTable();

                // Definir la consulta SQL para seleccionar el registro con el ID de empleo especificado
                string consulta = "SELECT * FROM tblEmpleos WHERE intIdEmpleo = @intIdEmpleo";

                // Crear el comando SQL y asignar la consulta y la conexión
                SqlCommand cmd = new SqlCommand(consulta, conexion);

                // Asignar el parámetro para el ID de empleo
                cmd.Parameters.AddWithValue("@intIdEmpleo", intIdEmpleo);

                // Crear un SqlDataAdapter para ejecutar el comando y llenar el DataTable con los resultados
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }

            public DataTable seleccionarDato()
            {
                // Establecer la conexión con la base de datos
                SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
                conexion.Open();

                // Asignar el ID de empleo recibido al campo de la clase
                this.intIdEmpleo = intIdEmpleo;

                // Crear un objeto DataTable para almacenar los resultados de la consulta
                DataTable dt = new DataTable();

                // Definir la consulta SQL para seleccionar el registro con el ID de empleo especificado
                string seleccionar = "SELECT * FROM tblEmpleos WHERE intIdEmpleo = @intIdEmpleo";

                // Crear el comando SQL y asignar la consulta y la conexión
                SqlCommand cmd = new SqlCommand(seleccionar, conexion);

                // Asignar el parámetro para el ID de empleo
                cmd.Parameters.AddWithValue("@intIdEmpleo", this.intIdEmpleo);

                // Crear un SqlDataAdapter para ejecutar el comando y llenar el DataTable con los resultados
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
        }

    }


