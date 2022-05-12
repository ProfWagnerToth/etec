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
    public partial class frm_Cliente : Form
    {
        public frm_Cliente()
        {
            InitializeComponent();
        }

        private void pcb_Voltar_Click(object sender, EventArgs e)
        {
            frm_Menu newFrm_Menu = new frm_Menu();
            newFrm_Menu.Show();
            Close();
            
        }
        //Instanciando a Classe e criando Objeto do Método Inserir
        class_Clientes newCli = new class_Clientes();
        private void pcb_Confirmar_Click(object sender, EventArgs e)
        {
            //Recebendo Informações das TextBox do Formulário
            try
            {
                newCli.setNomeCli(txtNomeCli.Text);
                newCli.setCpfCli(txtCpfCli.Text);
                newCli.setTelCli(txtTelCli.Text);
                newCli.setEnderecoCli(txtEnderecoCli.Text);
                newCli.setNumCli(Int32.Parse(txtNumCli.Text));
                newCli.setBairroCli(txtBairroCli.Text);
                newCli.setCidadeCli(txtCidadeCli.Text);
                newCli.setufCli(txtUfCli.Text);
                newCli.setCepCli(txtCepCli.Text);
                newCli.inserir();
                dataGridView1.DataSource = newCli.Consultar();
            }
            finally
            {
                MessageBox.Show("Registro Inserido com Sucesso!!!");
                txtNomeCli.Clear();
                txtCpfCli.Clear();
                txtTelCli.Clear();
                txtEnderecoCli.Clear();
                txtNumCli.Clear();
                txtBairroCli.Clear();
                txtCidadeCli.Clear();
                txtUfCli.Clear();
                txtCepCli.Clear();
                txtNomeCli.Focus();
            }
        }

        private void pcb_Inserir_Click(object sender, EventArgs e)
        {
            gpb_FrmCliente.Visible=true;
            txtNomeCli.Focus();
        }

        private void pcb_Cancelar_Click(object sender, EventArgs e)
        {
            txtNomeCli.Clear();
            txtCpfCli.Clear();
            txtTelCli.Clear();
            txtEnderecoCli.Clear();
            txtNumCli.Clear();
            txtBairroCli.Clear();
            txtCidadeCli.Clear();
            txtUfCli.Clear();
            txtCepCli.Clear();
            gpb_FrmCliente.Visible = false;
            
        }
    }
}
