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

            class_Funcionarios buscarFunc = new class_Funcionarios(); //Instanciamento da Classe
            frm_Funcionario formFunc = new frm_Funcionario(); //Instanciamento do Formulario Func

            Class_Fornecedores buscarForn = new Class_Fornecedores(); //Instanciamento da Classe
            frm_Fornecedor formForn = new frm_Fornecedor(); //Instanciamento do Formulario Forncedor

            class_Produtos buscarProd = new class_Produtos(); //Instanciamento da Classe
            frm_Produtos formProd = new frm_Produtos(); //Instanciamento do Formulario Func


            if (rdb_Nome.Checked && rdb_Nome.Visible == true) //Verificando se a opção de pesquisa por esta selecionada
            {
                try //rotina de pesquisa no formulário 
                {
                    buscar.setNomeCli(txt_Pesquisa.Text); //Recebe informação da Text para alimentar o método SET e assim utilizar o objeto instaciado
                    this.Hide();
                    form.Show(); //Abre o formulário para apresentação dos Dados.
                    form.dataGridView1.DataSource = buscar.ConsultarNome(); //apontamento da Datagrid do formulário instanciado, realizando do método de busca.

                }

                finally //Conclusão da pesquisa.
                {
                    MessageBox.Show("Busca Realizada com Sucesso!!!"); //Menssagem de Busca Realizada com Sucesso ao usuário!

                }
            }
            if (rdb_CPF.Checked && rdb_CPF.Visible == true)
            {
                try
                {
                    buscar.setCpfCli(txt_Pesquisa.Text);
                    form.Show();
                    form.dataGridView1.DataSource = buscar.ConsultarCPF();

                }
                finally
                {
                    MessageBox.Show("Busca Realizada com Sucesso!!!");

                }
            }

            if (rdb_NomeFunc.Checked && rdb_NomeFunc.Visible == true) //Verificando se a opção de pesquisa por esta selecionada
            {
                try //rotina de pesquisa no formulário 
                {
                    buscarFunc.setNomeFunc(txt_Pesquisa.Text); //Recebe informação da Text para alimentar o método SET e assim utilizar o objeto instaciado
                    this.Hide();
                    formFunc.Show(); //Abre o formulário para apresentação dos Dados.
                    formFunc.dgv_Funcionario.DataSource = buscarFunc.ConsultarNome(); //apontamento da Datagrid do formulário instanciado, realizando do método de busca.
                }
                finally //Conclusão da pesquisa.
                {
                    MessageBox.Show("Busca Realizada com Sucesso!!!"); //Menssagem de Busca Realizada com Sucesso ao usuário!

                }
            }
            if (rdb_CodFuncionario.Checked && rdb_CodFuncionario.Visible == true)
            {
                try
                {
                    buscarFunc.setCpfFunc(txt_Pesquisa.Text);
                    formFunc.Show();
                    formFunc.dgv_Funcionario.DataSource = buscarFunc.ConsultarCPFFunc();
                }
                finally
                {
                    MessageBox.Show("Busca Realizada com Sucesso!!!");

                }
            }

            if (rdb_RazaoSocial.Checked && rdb_RazaoSocial.Visible == true)
            {
                try
                {
                    buscarForn.setRazaoSocial(txt_Pesquisa.Text);
                    formForn.Show();
                    formForn.dgvFornecedor.DataSource = buscarForn.ConsultarRazaoSocial();
                }
                finally
                {
                    MessageBox.Show("Busca Realizada com Sucesso!!!");

                }

                if (rdb_CNPJ.Checked && rdb_CNPJ.Visible == true)
                {
                    try
                    {
                        buscarForn.setCnpj(txt_Pesquisa.Text);
                        formForn.Show();
                        formForn.dgvFornecedor.DataSource = buscarForn.ConsultarCNPJ();
                    }
                    finally
                    {
                        MessageBox.Show("Busca Realizada com Sucesso!!!");

                    }
                }
                if (rdb_CodBarras.Checked && rdb_CodBarras.Visible == true)
                {
                    try
                    {
                        buscarProd.setCodBarProd(txt_Pesquisa.Text);
                        formProd.Show();
                        formProd.dgvProdutos.DataSource = buscarProd.ConsultarCodBar();
                    }
                    finally
                    {
                        MessageBox.Show("Busca Realizada com Sucesso!!!");

                    }
                }
                if (rdb_Descricao.Checked && rdb_Descricao.Visible == true)
                {
                    try
                    {
                        buscarProd.setDescProd(txt_Pesquisa.Text);
                        formProd.Show();
                        formProd.dgvProdutos.DataSource = buscarProd.ConsultarDescricao();
                    }
                    finally
                    {
                        MessageBox.Show("Busca Realizada com Sucesso!!!");

                    }
                }
                if (rdb_CodigoProduto.Checked && rdb_CodigoProduto.Visible == true)
                {
                    try
                    {
                        buscarProd.setCodProd(Int32.Parse(txt_Pesquisa.Text));
                        formProd.Show();
                        formProd.dgvProdutos.DataSource = buscarProd.ConsultarCodBar();
                    }
                    finally
                    {
                        MessageBox.Show("Busca Realizada com Sucesso!!!");

                    }
                }
            }
        }

       
        private void pcb_Excluir_Click(object sender, EventArgs e)
        {
            txt_Pesquisa.Clear();
            txt_Pesquisa.Focus();
        }
    }
}
