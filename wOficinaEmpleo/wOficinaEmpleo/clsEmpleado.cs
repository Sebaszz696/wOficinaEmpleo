using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wOficinaEmpleo
{
    internal class clsEmpleado
    {

        public int intNumeroDocumento { get; set; }
        public string strNombre { get; set; }
        public string strApellido { get; set; }
        public string strDoTipocumento { get; set; }
        public string strFechaNacimiento { get; set; }
        public string strNivelDeEstudios { get; set; }
        public string strTituloAcademico { get; set; }

        public clsEmpleado()
        {
            // Constructor por defecto
        }

        public clsEmpleado(int intNumeroDocumento, string strNombre, string strApellido, string strDoTipocumento, string strFechaNacimiento, string strNivelDeEstudios, string strTituloAcademico)
        {
            // Constructor que asigna los valores proporcionados a las propiedades correspondientes
            this.intNumeroDocumento = intNumeroDocumento;
            this.strNombre = strNombre;
            this.strApellido = strApellido;
            this.strDoTipocumento = strDoTipocumento;
            this.strFechaNacimiento = strFechaNacimiento;
            this.strNivelDeEstudios = strNivelDeEstudios;
            this.strTituloAcademico = strTituloAcademico;
        }

        public bool insertarDato()
        {
            // Establecer la conexión con la base de datos
            SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
            conexion.Open();

            // Definir la consulta de inserción
            string insertar = "INSERT INTO tblEmpleado VALUES(@intNumeroDocumento, @strNombre, @strApellido, @strDoTipocumento, @strFechaNacimiento, @strNivelDeEstudios, @strTituloAcademico)";

            // Crear el comando SQL y asignar los parámetros
            SqlCommand sql = new SqlCommand(insertar, conexion);
            sql.Parameters.AddWithValue("@intNumeroDocumento", this.intNumeroDocumento);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@strDoTipocumento", this.strDoTipocumento);
            sql.Parameters.AddWithValue("@strFechaNacimiento", this.strFechaNacimiento);
            sql.Parameters.AddWithValue("@strNivelDeEstudios", this.strNivelDeEstudios);
            sql.Parameters.AddWithValue("@strTituloAcademico", this.strTituloAcademico);

            // Ejecutar la consulta de inserción
            sql.ExecuteNonQuery();

            return true;
        }
        public DataTable consultarDatos()
        {
            // Establecer la conexión con la base de datos
            SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
            conexion.Open();

            // Crear un objeto DataTable para almacenar los resultados de la consulta
            DataTable dt = new DataTable();

            // Definir la consulta SQL para seleccionar todos los datos de la tabla tblEmpleado
            string consulta = "SELECT * FROM tblEmpleado";

            // Crear el comando SQL y asignar la consulta y la conexión
            SqlCommand cmd = new SqlCommand(consulta, conexion);

            // Crear un SqlDataAdapter para ejecutar el comando y llenar el DataTable con los resultados
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public bool eliminarDatos(int intNumeroDocumento)
        {
            // Establecer la conexión con la base de datos
            SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
            conexion.Open();

            // Asignar el número de documento recibido al campo de la clase
            this.intNumeroDocumento = intNumeroDocumento;

            // Definir la consulta SQL para eliminar el registro con el número de documento especificado
            string eliminar = "DELETE FROM tblEmpleado WHERE intNumeroDocumento = @intNumeroDocumento";

            // Crear el comando SQL y asignar la consulta y la conexión
            SqlCommand sql = new SqlCommand(eliminar, conexion);

            // Asignar el parámetro para el número de documento
            sql.Parameters.AddWithValue("@intNumeroDocumento", this.intNumeroDocumento);

            // Ejecutar la consulta de eliminación
            sql.ExecuteNonQuery();

            return true;
        }

        public bool modificarDato()
        {
            // Establecer la conexión con la base de datos
            SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
            conexion.Open();

            // Definir la consulta SQL para actualizar los datos del registro con el número de documento especificado
            string insertar = "UPDATE tblEmpleado SET strNombre = @strNombre, strApellido = @strApellido, strDoTipocumento = @strDoTipocumento, strFechaNacimiento = @strFechaNacimiento, strNivelDeEstudios = @strNivelDeEstudios, strTituloAcademico = @strTituloAcademico WHERE intNumeroDocumento = @intNumeroDocumento";

            // Crear el comando SQL y asignar la consulta y la conexión
            SqlCommand sql = new SqlCommand(insertar, conexion);

            // Asignar los parámetros para los campos actualizados
            sql.Parameters.AddWithValue("@intNumeroDocumento", this.intNumeroDocumento);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@strDoTipocumento", this.strDoTipocumento);
            sql.Parameters.AddWithValue("@strFechaNacimiento", this.strFechaNacimiento);
            sql.Parameters.AddWithValue("@strNivelDeEstudios", this.strNivelDeEstudios);
            sql.Parameters.AddWithValue("@strTituloAcademico", this.strTituloAcademico);

            // Ejecutar la consulta de actualización
            sql.ExecuteNonQuery();

            return true;
        }
        public DataTable seleccionarDato()
        {
            // Establecer la conexión con la base de datos
            SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
            conexion.Open();

            // Asignar el número de documento recibido al campo de la clase
            this.intNumeroDocumento = intNumeroDocumento;

            // Crear un objeto DataTable para almacenar los resultados de la consulta
            DataTable dt = new DataTable();

            // Definir la consulta SQL para seleccionar el registro con el número de documento especificado
            string seleccionar = "SELECT * FROM tblEmpleado WHERE intNumeroDocumento = @intNumeroDocumento";

            // Crear el comando SQL y asignar la consulta y la conexión
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);

            // Asignar el parámetro para el número de documento
            cmd.Parameters.AddWithValue("@intNumeroDocumento", this.intNumeroDocumento);

            // Crear un SqlDataAdapter para ejecutar el comando y llenar el DataTable con los resultados
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }



    }
}
