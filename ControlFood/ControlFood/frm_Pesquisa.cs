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
            class_Clientes buscar = new class_Clientes();
            frm_Cliente form = new frm_Cliente();
            
            if (rdb_Nome.Checked)
            {
                try
                {
                    buscar.setNomeCli(txt_Pesquisa.Text);
                    form.Show();
                    form.dataGridView1.DataSource = buscar.ConsultarNome();
                    
                    /*
                    //Alteração dos nomes das colunas do datagridview
                    dataGridView1.Columns["nomeCli"].HeaderText = "Nome";
                    dataGridView1.Columns["telCli"].HeaderText = "Código";
                    dataGridView1.Columns["cidadeCli"].HeaderText = "Sobrenome";
                    dataGridView1.Columns["ufCli"].HeaderText = "CPF"; */

                }
                finally
                {
                    MessageBox.Show("Busca Realizada com Sucesso!!!");

                }
            }
            if (rdb_CPF.Checked)
            {
                try
                {
                    buscar.setCpfCli(txt_Pesquisa.Text);
                    form.Show();
                    form.dataGridView1.DataSource = buscar.ConsultarCPF();
                    
                    /*
                    //Alteração dos nomes das colunas do datagridview
                    dataGridView1.Columns["nomeCli"].HeaderText = "Nome";
                    dataGridView1.Columns["telCli"].HeaderText = "Código";
                    dataGridView1.Columns["cidadeCli"].HeaderText = "Sobrenome";
                    dataGridView1.Columns["ufCli"].HeaderText = "CPF"; */

                }
                finally
                {
                    MessageBox.Show("Busca Realizada com Sucesso!!!");

                }
            }
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
