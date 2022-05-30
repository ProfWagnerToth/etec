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
    public partial class frm_Produtos : Form
    {
        public frm_Produtos()
        {
            InitializeComponent();
        }

        private void pcb_Inserir_Click(object sender, EventArgs e)
        {
            gpb_FrmProduto.Visible = true; //Deixando o GroupBox referente ao formulário Visivel
            txtDescProd.Focus(); //Dando foco na textbox especifica
        }

        private void pcb_Editar_Click(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaProd = new frm_Pesquisa ();
            newPesquisaProd.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            
            newPesquisaProd.rdb_Nome.Visible = false;
            newPesquisaProd.rdb_CPF.Visible = false;
            newPesquisaProd.rdb_NomeFunc.Visible = false;
            newPesquisaProd.rdb_CodFuncionario.Visible = false;
            newPesquisaProd.rdb_CNPJ.Visible = false;
            newPesquisaProd.rdb_RazaoSocial.Visible = false;
            newPesquisaProd.rdb_CodigoProduto.Visible = true;
            newPesquisaProd.rdb_CodBarras.Visible = true;
            newPesquisaProd.rdb_Descricao.Visible = true;
            newPesquisaProd.txt_Pesquisa.Focus();
            
        }

        private void pcb_Pesquisar_Click(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaProd = new frm_Pesquisa();
            newPesquisaProd.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */

            newPesquisaProd.rdb_Nome.Visible = false;
            newPesquisaProd.rdb_CPF.Visible = false;
            newPesquisaProd.rdb_NomeFunc.Visible = false;
            newPesquisaProd.rdb_CodFuncionario.Visible = false;
            newPesquisaProd.rdb_CNPJ.Visible = false;
            newPesquisaProd.rdb_RazaoSocial.Visible = false;
            newPesquisaProd.rdb_CodigoProduto.Visible = true;
            newPesquisaProd.rdb_CodBarras.Visible = true;
            newPesquisaProd.rdb_Descricao.Visible = true;
            newPesquisaProd.txt_Pesquisa.Focus();
        }

        private void pcb_Excluir_Click(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaProd = new frm_Pesquisa();
            newPesquisaProd.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */

            newPesquisaProd.rdb_Nome.Visible = false;
            newPesquisaProd.rdb_CPF.Visible = false;
            newPesquisaProd.rdb_NomeFunc.Visible = false;
            newPesquisaProd.rdb_CodFuncionario.Visible = false;
            newPesquisaProd.rdb_CNPJ.Visible = false;
            newPesquisaProd.rdb_RazaoSocial.Visible = false;
            newPesquisaProd.rdb_CodigoProduto.Visible = true;
            newPesquisaProd.rdb_CodBarras.Visible = true;
            newPesquisaProd.rdb_Descricao.Visible = true;
            newPesquisaProd.txt_Pesquisa.Focus();
        }

        class_Produtos cadProd = new class_Produtos();
        private void pcb_Edicao_Click(object sender, EventArgs e)
        {
            //Mensagem de Confirmação de Ação
            if (MessageBox.Show("Deseja ALTERAR os dados do Registro?", "CONFIRMAÇÃO DE EDIÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cadProd.setCodBarProd(txtCodBarProd.Text);
                    cadProd.setDescProd(txtDescProd.Text);
                    cadProd.setUndProd(txtUndProd.Text);
                    cadProd.setVlCompProd(txtVlCompProd.Text);
                    cadProd.setVlVendProd(txtVlVendProd.Text);                    
                    cadProd.alterar();
                    dgvProdutos.DataSource = cadProd.ConsultarCodProd();
                }

                finally
                {
                    MessageBox.Show("Informações alteradas com sucesso");
                }
            }
        }

        private void pcb_Exclusao_Click(object sender, EventArgs e)
        {
            // Mensagem de Confirmação de Ação
            if (MessageBox.Show(" Deseja realmente EXCLUIR o REGISTRO? ", "CONFIRMAÇÃO DE EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cadProd.setCodProd(Int32.Parse(lbl_codProd.Text));
                    cadProd.excluir();
                    dgvProdutos.DataSource = cadProd.Consultar();
                    pcb_Edicao.Visible = false;
                    pcb_Exclusao.Visible = false;
                    pcb_Confirmar.Visible = true;
                    lbl_CodigoTag.Visible = false;
                    lbl_codProd.Visible = false;

                    txtCodBarProd.Clear();
                    txtDescProd.Clear();
                    txtUndProd.Clear();
                    txtVlCompProd.Clear();
                    txtVlVendProd.Clear();
                    lbl_codProd.Text = "";
                    txtCodBarProd.Focus();
                }

                finally
                {
                    MessageBox.Show("Informações excluídas com sucesso");
                }
            }
        }

        private void pcb_Confirmar_Click(object sender, EventArgs e)
        {
            //Recebendo Informações das TextBox do Formulário
            try
            {
                cadProd.setCodBarProd(txtCodBarProd.Text);                
                cadProd.setDescProd(txtDescProd.Text);
                cadProd.setUndProd(txtUndProd.Text);                
                cadProd.setVlCompProd(txtVlCompProd.Text);
                cadProd.setVlVendProd(txtVlVendProd.Text);                
                cadProd.inserir();
                dgvProdutos.DataSource = cadProd.Consultar();
            }
            finally
            {
                MessageBox.Show("Registro Inserido com Sucesso!!!");

                //Limpeza dos Campos Preenchidos
                txtCodBarProd.Clear();
                txtDescProd.Clear();
                txtUndProd.Clear();
                txtVlCompProd.Clear();
                txtVlVendProd.Clear();   
                txtDescProd.Focus();
            }
        }

        private void pcb_Cancelar_Click(object sender, EventArgs e)
        {
            /*Botão Cancelar é utillizado para abortar a operação de inserção indevida, limpando dados inseridos e tornando o GroupBox referente ao cadastro invisivel novamente. */

            txtCodBarProd.Clear();
            txtDescProd.Clear();
            txtUndProd.Clear();
            txtVlCompProd.Clear();
            txtVlVendProd.Clear();                    
            gpb_FrmProduto.Visible = false;
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Criação de variaveis para obtenção de dados do Banco de Dados Clicando direto na Datagrid do formulario.
            int codigoProduto = dgvProdutos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvProdutos.Rows[codigoProduto];
            string codigoProd = Convert.ToString(selectedRow.Cells["Código"].Value);
            string codigoBarrasProd = Convert.ToString(selectedRow.Cells["Código_Barras"].Value);
            string descricaoProduto = Convert.ToString(selectedRow.Cells["Descrição"].Value);
            string unidadeProduto = Convert.ToString(selectedRow.Cells["Unidade"].Value);
            string VlCompraProduto = Convert.ToString(selectedRow.Cells["Vl_Compra"].Value);
            string VlVendaProduto = Convert.ToString(selectedRow.Cells["Vl_Venda"].Value);
            

            //Controle de vizualização de botões do formulário
            gpb_FrmProduto.Visible = true;
            pcb_Edicao.Visible = true;
            pcb_Confirmar.Visible = false;
            pcb_Exclusao.Visible = true;
            lbl_CodigoTag.Visible = true;
            lbl_codProd.Visible = true;

            //Passando dados das variaveis para os campos do formulário
            lbl_codProd.Text = codigoProd;
            txtCodBarProd.Text = codigoBarrasProd;
            txtDescProd.Text = descricaoProduto;
            txtUndProd.Text = unidadeProduto;
            txtVlCompProd.Text = VlCompraProduto;
            txtVlVendProd.Text= VlVendaProduto;            
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Menu newFrm_Menu = new frm_Menu();
            newFrm_Menu.Show();
            Close();
        }

        private void pcb_Voltar_Click(object sender, EventArgs e)
        {
            frm_Menu newFrm_Menu = new frm_Menu();
            newFrm_Menu.Show();
            Close();
        }
    }
}
