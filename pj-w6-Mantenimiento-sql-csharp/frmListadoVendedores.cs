using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pj_w6_Mantenimiento_sql_csharp
{
    public partial class frmListadoVendedores : Form
    {
        public frmListadoVendedores()
        {
            InitializeComponent();
        }

        private void frmListadoVendedores_Load(object sender, EventArgs e)
        {
            DAOVendedor objDAO = new DAOVendedor();
            dgVendedores.DataSource = objDAO.listadoVendedores();
            dgVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
