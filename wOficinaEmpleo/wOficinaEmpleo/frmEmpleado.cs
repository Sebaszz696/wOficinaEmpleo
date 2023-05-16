using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wOficinaEmpleo
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void dtgEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer la conexión a la base de datos.
                SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
                conexion.Open();

                // Crear una instancia de la clase clsEmpleado y pasar los valores ingresados en los TextBox y ComboBox.
                clsEmpleado empleado = new clsEmpleado(Convert.ToInt32(intNumeroDocumento.Text), txtNombre.Text, txtApellido.Text, cboDoTipoDocumento.Text, strFechaNacimiento.Text, cboNivelEstudios.Text, txtTitulo.Text);

                // Insertar el dato en la base de datos.
                empleado.insertarDato();

                MessageBox.Show("Dato ingresado correctamente");

                // Consultar los datos actualizados y mostrarlos en el DataGridView.
                dtgEmpleado.DataSource = empleado.consultarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar el dato: " + ex.Message);
            }
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer la conexión a la base de datos.
                SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
                conexion.Open();

                // Crear una instancia de la clase clsEmpleado.
                clsEmpleado empleado = new clsEmpleado();

                // Consultar todos los datos y mostrarlos en el DataGridView.
                dtgEmpleado.DataSource = empleado.consultarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los datos: " + ex.Message);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer la conexión a la base de datos.
                SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
                conexion.Open();

                // Crear una instancia de la clase clsEmpleado.
                clsEmpleado empleado = new clsEmpleado();

                // Eliminar el dato correspondiente al número de documento ingresado.
                empleado.eliminarDatos(Convert.ToInt32(intNumeroDocumento.Text));

                // Consultar los datos actualizados y mostrarlos en el DataGridView.
                dtgEmpleado.DataSource = empleado.consultarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se eliminó ningún dato: " + ex.Message);
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer la conexión a la base de datos.
                SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
                conexion.Open();

                // Crear una instancia de la clase clsEmpleado y pasar los valores ingresados en los TextBox y ComboBox.
                clsEmpleado empleado = new clsEmpleado(Convert.ToInt32(intNumeroDocumento.Text), txtNombre.Text, txtApellido.Text, cboDoTipoDocumento.Text, strFechaNacimiento.Text, cboNivelEstudios.Text, txtTitulo.Text);

                // Modificar el dato correspondiente al número de documento ingresado.
                empleado.modificarDato();

                MessageBox.Show("Datos modificados correctamente");

                // Consultar los datos actualizados y mostrarlos en el DataGridView.
                dtgEmpleado.DataSource = empleado.consultarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el dato: " + ex.Message);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpia los campos del form
            intNumeroDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cboDoTipoDocumento.Text = "";
            strFechaNacimiento.Text ="";
            cboNivelEstudios.Text = "";
            txtTitulo.Text = "";
        }

        private void dtgEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            // Obtener los valores de la fila seleccionada en el DataGridView y asignarlos a los controles correspondientes.
            intNumeroDocumento.Text = dtgEmpleado.SelectedRows[0].Cells[0].Value.ToString();
            txtNombre.Text = dtgEmpleado.SelectedRows[0].Cells[1].Value.ToString();
            txtApellido.Text = dtgEmpleado.SelectedRows[0].Cells[2].Value.ToString();
            cboDoTipoDocumento.Text = dtgEmpleado.SelectedRows[0].Cells[3].Value.ToString();
            strFechaNacimiento.Text= dtgEmpleado.SelectedRows[0].Cells[4].Value.ToString();
            cboNivelEstudios.Text= dtgEmpleado.SelectedRows[0].Cells[5].Value.ToString();
            txtTitulo.Text = dtgEmpleado.SelectedRows[0].Cells[6].Value.ToString();



        }
    }
}
