using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wOficinaEmpleo
{/// <summary>
/// Sebastian Velasquez 
/// Mateo Becerra 
/// 16/05/2023
/// Trabajo de buscar empleo y registrar empleado
/// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moduloEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //comprueba que no haya ningun formularo hijo abierto
            Form frmHijo = this.ActiveMdiChild;
            if (frmHijo != null)
            {

                frmHijo.Close();
            }
            //Abre Modulo Empleado
            frmEmpleado frmEmpleado = new frmEmpleado();
            frmEmpleado.MdiParent = this;
            frmEmpleado.Show();
        }

        private void buscarEmpleoToolStripMenuItem_Click(object sender, EventArgs e)
        {   //comprueba que no haya ningun formularo hijo abierto
            Form frmHijo = this.ActiveMdiChild;
            if (frmHijo != null)
            {

                frmHijo.Close();
            }
            //Abre Buscar Empleado
            frmBusquedaEmpleo frmBusquedaEmpleo = new frmBusquedaEmpleo();
            frmBusquedaEmpleo.MdiParent = this;
            frmBusquedaEmpleo.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
