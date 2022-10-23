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
    public partial class frmNuevoVendedor : Form
    {

        DAOVendedor objDAO = new DAOVendedor();
        public frmNuevoVendedor()
        {
            InitializeComponent(); 
            cboDistrito.DataSource = objDAO.listadoDistritos();
            cboDistrito.DisplayMember = "nom_dis";
            cboDistrito.ValueMember = "ide_dis";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Vendedor objV = new Vendedor()
               {
                   nom_ven = txtNombres.Text,
                   ape_ven = txtApellidos.Text,
                   sue_ven = double.Parse(txtSueldo.Text),
                   fec_ing = dtFecha.Value,
                   ide_dis = int.Parse(cboDistrito.SelectedValue.ToString())
               };
            try
            {
                int n = objDAO.nuevoVendedor(objV);
                if (n == 1)

                    MessageBox.Show
                    (n + " Registro de vendedor correcto ");
            }
            catch (Exception ex)
            {

                MessageBox.Show
                (ex.Message);
            }
        }

        private void frmNuevoVendedor_Load(object sender, EventArgs e)
        {
            int n = objDAO.generaCodigo();
            lblCodigo.Text = n.ToString("0000");
        }
    }
}
