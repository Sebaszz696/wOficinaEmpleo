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
    public partial class frmBusquedaEmpleo : Form
    {
       
        public frmBusquedaEmpleo()
        {
            InitializeComponent();
        }

        private void frmBusquedaEmpleo_Load(object sender, EventArgs e)
        {
         
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Establecer la conexión a la base de datos.
                SqlConnection conexion = new SqlConnection("server=SEBASZZ;database=dboBusquedaEmpleado;integrated security=true");
                conexion.Open();

                // Crear una instancia de la clase clsBuscarEmpleo.
                clsBuscarEmpleo empleado = new clsBuscarEmpleo();

                // Obtener el intIdEmpleo ingresado en el TextBox y asignarlo a la propiedad intIdEmpleo del objeto empleado.
                int intIdEmpleo = int.Parse(txtIntIdEmpleo.Text);
                empleado.intIdEmpleo = intIdEmpleo;

                // Consultar los datos del empleo correspondiente al intIdEmpleo.
                dtgEmpleos.DataSource = empleado.consultarDatos();

                // Comprobar si no se encontró ningún empleo con el intIdEmpleo ingresado.
                if (intIdEmpleo >= 5)
                {
                    MessageBox.Show("No existe ningún trabajo con este código, revisa la lista a tu izquierda.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar el dato: " + ex.Message);
            }
        }
    }
}
