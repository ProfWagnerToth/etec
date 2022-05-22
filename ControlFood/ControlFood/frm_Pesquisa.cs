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
            /* Método de pesquisar através de formulário de pesquisa por nome e por cpf, utilizando a apresentação dos dados em Datagrid pertecente ao formulário Clientes.
             1. Instanciar a Classe com Objeto especifico para realizar a busca no banco de dados.
             2. Instanciar o formulário que deseja apresentar as informações dentro do botão de pesquisa.
             3. Criar Estrutura de decisão para escolha a forma de pesquisa, utilizando um elemento Radio Buttom para seleção do metodo especifico de Pesquisa.
             4. Criar métodos de pesquisar dentro da Classe especificos para Busca por Nome e por CPF.
             5. No formulário onde irá aparecer os dados deverá alterar a propriedade do elemento DataGrid no Seção Design -> Modifiers, trocar de Private para Public, desta forma poderá acessar o DataGrid publico de qualquer outro formulário desde que esteja instanciado.
            */
            
            class_Clientes buscar = new class_Clientes(); //Instanciamento da Classe
            frm_Cliente form = new frm_Cliente(); //Instanciamento do Formulario Cliente
                       

            if (rdb_Nome.Checked) //Verificando se a opção de pesquisa por esta selecionada
            {
                try //rotina de pesquisa no formulário 
                {
                    buscar.setNomeCli(txt_Pesquisa.Text); //Recebe informação da Text para alimentar o método SET e assim utilizar o objeto instaciado
                    this.Hide();
                    form.Show(); //Abre o formulário para apresentação dos Dados.
                    form.dataGridView1.DataSource = buscar.ConsultarNome(); //apontamento da Datagrid do formulário instanciado, realizando do método de busca.

                    
                    /* Alterções não Aplicadas no Projeto 
                    //Alteração dos nomes das colunas do datagridview
                    dataGridView1.Columns["nomeCli"].HeaderText = "Nome";
                    dataGridView1.Columns["telCli"].HeaderText = "Código";
                    dataGridView1.Columns["cidadeCli"].HeaderText = "Sobrenome";
                    dataGridView1.Columns["ufCli"].HeaderText = "CPF"; */

                }
                finally //Conclusão da pesquisa.
                {
                    MessageBox.Show("Busca Realizada com Sucesso!!!"); //Menssagem de Busca Realizada com Sucesso ao usuário!

                }
            }
            if (rdb_CPF.Checked)
            {
                try
                {
                    buscar.setCpfCli(txt_Pesquisa.Text);
                    form.Show();
                    form.dataGridView1.DataSource = buscar.ConsultarCPF();

                    /* Alterções não Aplicadas no Projeto
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

        private void pcb_Excluir_Click(object sender, EventArgs e)
        {
            txt_Pesquisa.Clear();
            txt_Pesquisa.Focus();
        }
    }
}
