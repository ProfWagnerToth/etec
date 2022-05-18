using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFood
{
    public partial class frm_Pesquisa : Form
    {
        public frm_Pesquisa()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pcb_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pcb_Pesquisar_Click(object sender, EventArgs e)
        {
            if (rdb_Nome.Checked)
            {
                rdb_CPF.Visible = false;
            }
        }
    }
}
