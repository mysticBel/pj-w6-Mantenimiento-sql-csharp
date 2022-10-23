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
    public partial class frmBuscaVendedor : Form
    {
        DAOVendedor objDAO = new DAOVendedor();
        public frmBuscaVendedor()
        {
            InitializeComponent();
            cboDistrito.DataSource = objDAO.listadoDistritos();
            cboDistrito.DisplayMember = "nom_dis";
            cboDistrito.ValueMember = "ide_dis";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                DataRow dr = objDAO.buscaVendedor(codigo).Rows[0];

                txtNombres.Text = dr[1].ToString();
                txtApellidos.Text = dr[2].ToString();
                txtSueldo.Text = dr[3].ToString();
                dtFecha.Value = DateTime.Parse(dr[4].ToString());
                cboDistrito.Text = dr[5].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vendedor NO existe..!!!");
            }
        }

    }
}
