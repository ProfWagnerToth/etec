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
    public partial class frm_Fornecedor : Form
    {
        public frm_Fornecedor()
        {
            InitializeComponent();
        }

        private void pcb_Inserir_Click(object sender, EventArgs e)
        {
            gpb_FrmFornecedor.Visible = true; //Deixando o GroupBox referente ao formulário Visivel
            txtRazaoSocialForn.Focus(); //Dando foco na textbox especifica
        }

        private void pcb_Editar_Click(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaForn = new frm_Pesquisa();
            newPesquisaForn.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaForn.rdb_Nome.Visible = false;
            newPesquisaForn.rdb_CPF.Visible = false;
            newPesquisaForn.rdb_NomeFunc.Visible = false;
            newPesquisaForn.rdb_CodFuncionario.Visible = false;
            newPesquisaForn.rdb_CNPJ.Visible = true;
            newPesquisaForn.rdb_RazaoSocial.Visible = true;
            newPesquisaForn.rdb_CodigoProduto.Visible = false;
            newPesquisaForn.rdb_CodBarras.Visible = false;
            newPesquisaForn.rdb_Descricao.Visible = false;
            newPesquisaForn.txt_Pesquisa.Focus();
        }

        private void pcb_Pesquisar_Click(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaForn = new frm_Pesquisa();
            newPesquisaForn.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaForn.rdb_Nome.Visible = false;
            newPesquisaForn.rdb_CPF.Visible = false;
            newPesquisaForn.rdb_NomeFunc.Visible = false;
            newPesquisaForn.rdb_CodFuncionario.Visible = false;
            newPesquisaForn.rdb_CNPJ.Visible = true;
            newPesquisaForn.rdb_RazaoSocial.Visible = true;
            newPesquisaForn.rdb_CodigoProduto.Visible = false;
            newPesquisaForn.rdb_CodBarras.Visible = false;
            newPesquisaForn.rdb_Descricao.Visible = false;
            newPesquisaForn.txt_Pesquisa.Focus();
        }

        private void pcb_Excluir_Click(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaForn = new frm_Pesquisa();
            newPesquisaForn.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaForn.rdb_Nome.Visible = false;
            newPesquisaForn.rdb_CPF.Visible = false;
            newPesquisaForn.rdb_NomeFunc.Visible = false;
            newPesquisaForn.rdb_CodFuncionario.Visible = false;
            newPesquisaForn.rdb_CNPJ.Visible = true;
            newPesquisaForn.rdb_RazaoSocial.Visible = true;
            newPesquisaForn.rdb_CodigoProduto.Visible = false;
            newPesquisaForn.rdb_CodBarras.Visible = false;
            newPesquisaForn.rdb_Descricao.Visible = false;
            newPesquisaForn.txt_Pesquisa.Focus();
        }

        Class_Fornecedores cadForn = new Class_Fornecedores();
        private void pcb_Edicao_Click(object sender, EventArgs e)
        {
            //Mensagem de Confirmação de Ação
            if (MessageBox.Show("Deseja ALTERAR os dados do Registro?", "CONFIRMAÇÃO DE EDIÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cadForn.setRazaoSocial(txtRazaoSocialForn.Text);
                    cadForn.setNomeFantasia(txtNomeFantasiaForn.Text);
                    cadForn.setTelForn(txtTelForn.Text);
                    cadForn.setCnpj(txtCnpjForn.Text);
                    cadForn.setEnderecoForn(txtEnderecoForn.Text);
                    cadForn.setNumForn(Int32.Parse(txtNumForn.Text));
                    cadForn.setBairroForn(txtBairroForn.Text);
                    cadForn.setCidadeForn(txtCidadeForn.Text);
                    cadForn.setufForn(txtUfForn.Text);
                    cadForn.setCepForn(txtCepForn.Text);
                    cadForn.alterar();
                    dgvFornecedor.DataSource = cadForn.ConsultarCodForn();
                }

                finally
                {
                    MessageBox.Show("Informações alteradas com sucesso");
                }
            }
        }

        private void pcb_Exclusao_Click(object sender, EventArgs e)
        {
            //Mensagem de Confirmação de Ação
            if (MessageBox.Show(" Deseja realmente EXCLUIR o REGISTRO? ", "CONFIRMAÇÃO DE EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cadForn.setCodForn(Int32.Parse(lbl_codForn.Text));
                    cadForn.excluir();
                    dgvFornecedor.DataSource = cadForn.Consultar();

                    pcb_Edicao.Visible = false;
                    pcb_Exclusao.Visible = false;
                    pcb_Confirmar.Visible = true;
                    lbl_CodigoTag.Visible = false;
                    lbl_codForn.Visible = false;

                    txtRazaoSocialForn.Clear();
                    txtNomeFantasiaForn.Clear();
                    txtTelForn.Clear();
                    txtEnderecoForn.Clear();
                    txtNumForn.Clear();
                    txtBairroForn.Clear();
                    txtCidadeForn.Clear();
                    txtUfForn.Clear();
                    txtCepForn.Clear();
                    txtRazaoSocialForn.Focus();
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
                cadForn.setRazaoSocial(txtRazaoSocialForn.Text);
                cadForn.setNomeFantasia(txtNomeFantasiaForn.Text);
                cadForn.setTelForn(txtTelForn.Text);
                cadForn.setCnpj(txtCnpjForn.Text);
                cadForn.setEnderecoForn(txtEnderecoForn.Text);
                cadForn.setNumForn(Int32.Parse(txtNumForn.Text));
                cadForn.setBairroForn(txtBairroForn.Text);
                cadForn.setCidadeForn(txtCidadeForn.Text);
                cadForn.setufForn(txtUfForn.Text);
                cadForn.setCepForn(txtCepForn.Text);
                cadForn.inserir();
                dgvFornecedor.DataSource = cadForn.Consultar();
            }
            finally
            {
                MessageBox.Show("Registro Inserido com Sucesso!!!");
                //Limpeza dos Campos Preenchidos

                txtRazaoSocialForn.Clear();
                txtNomeFantasiaForn.Clear();
                txtTelForn.Clear();
                txtCnpjForn.Clear();
                txtEnderecoForn.Clear();
                txtNumForn.Clear();
                txtBairroForn.Clear();
                txtCidadeForn.Clear();
                txtUfForn.Clear();
                txtCepForn.Clear();
                txtRazaoSocialForn.Focus();
            }
        }

        private void pcb_Cancelar_Click(object sender, EventArgs e)
        {
            txtRazaoSocialForn.Clear();
            txtNomeFantasiaForn.Clear();
            txtTelForn.Clear();
            txtEnderecoForn.Clear();
            txtNumForn.Clear();
            txtBairroForn.Clear();
            txtCidadeForn.Clear();
            txtUfForn.Clear();
            txtCepForn.Clear();
            txtRazaoSocialForn.Focus();
        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Criação de variaveis para obtenção de dados do Banco de Dados Clicando direto na Datagrid do formulario.
            int codigoForn = dgvFornecedor.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvFornecedor.Rows[codigoForn];
            string codigoFornecedor = Convert.ToString(selectedRow.Cells["Codigo"].Value);
            string razaoSocialFornecedor = Convert.ToString(selectedRow.Cells["Razão_Social"].Value);
            string nomeFantasiaFornecedor = Convert.ToString(selectedRow.Cells["Nome_Fantasia"].Value);
            string telefoneFornecedor = Convert.ToString(selectedRow.Cells["Telefone"].Value);
            string cnpjFornecedor = Convert.ToString(selectedRow.Cells["CNPJ"].Value);
            string enderecoFornecedor = Convert.ToString(selectedRow.Cells["Endereço"].Value);
            string numeroFornecedor = Convert.ToString(selectedRow.Cells["Número"].Value);
            string bairroFornecedor = Convert.ToString(selectedRow.Cells["Bairro"].Value);
            string cidadeFornecedor = Convert.ToString(selectedRow.Cells["Cidade"].Value);
            string ufFornecedor = Convert.ToString(selectedRow.Cells["Estado"].Value);
            string cepFornecedor = Convert.ToString(selectedRow.Cells["CEP"].Value);

            //Controle de vizualização de botões do formulário
            gpb_FrmFornecedor.Visible = true;
            pcb_Edicao.Visible = true;
            pcb_Confirmar.Visible = false;
            pcb_Exclusao.Visible = true;
            lbl_CodigoTag.Visible = true;
            lbl_codForn.Visible = true;

            //Passando dados das variaveis para os campos do formulário
            lbl_codForn.Text = codigoFornecedor;
            txtRazaoSocialForn.Text = razaoSocialFornecedor;
            txtNomeFantasiaForn.Text = nomeFantasiaFornecedor;
            txtTelForn.Text = telefoneFornecedor;
            txtCnpjForn.Text= cnpjFornecedor;
            txtEnderecoForn.Text = enderecoFornecedor;
            txtNumForn.Text = numeroFornecedor;
            txtBairroForn.Text = bairroFornecedor;
            txtCidadeForn.Text = cidadeFornecedor;
            txtUfForn.Text = ufFornecedor;
            txtCepForn.Text = cepFornecedor;

            //Recebendo dados pelo método SET
            cadForn.setCodForn(Int32.Parse(codigoFornecedor));
            cadForn.setRazaoSocial(razaoSocialFornecedor);
            cadForn.setNomeFantasia(nomeFantasiaFornecedor);
            cadForn.setTelForn(telefoneFornecedor);
            cadForn.setCnpj(cnpjFornecedor);
            cadForn.setEnderecoForn(enderecoFornecedor);
            cadForn.setNumForn(Int32.Parse(numeroFornecedor));
            cadForn.setBairroForn(bairroFornecedor);
            cadForn.setCidadeForn(cidadeFornecedor);
            cadForn.setufForn(ufFornecedor);
            cadForn.setCepForn(cepFornecedor);
        }

        private void txtCnpjForn_Leave(object sender, EventArgs e)
        {
            /* 
            Aplicação de Mascara ao CNPJ (99.999.999/9999-99)
            1. Ative a o Evento Focus -> Leave da sua TextBox
            2. Crie uma variavel para receber o valor digitado em sua TextBox
            3. Converta o valor da TextBox em Numero 
            4. Aplique a mascara que deseja 
            5. Retorne o valor da variavel para sua textbox agora com a mascara.
            */

            long numCNPJtxt = long.Parse(txtCnpjForn.Text);
            string strMascara = string.Format(@"{0:00\.000\.000\/0000\-00}", numCNPJtxt);
            string cpfMascara = Convert.ToString(string.Format(strMascara, numCNPJtxt));
            txtCnpjForn.Text = cpfMascara;
        }

        private void txtTelForn_Leave(object sender, EventArgs e)
        {
            long numTeltxt = long.Parse(txtTelForn.Text);
            string strMascara = string.Format(@"{0:(00)00000-0000}", numTeltxt);
            txtTelForn.Text = Convert.ToString(string.Format(strMascara, numTeltxt));
        }

        private void txtCepForn_Leave(object sender, EventArgs e)
        {
            long numCEPtxt = long.Parse(txtCepForn.Text);
            string strMascara = string.Format(@"{0:00\.000\-000}", numCEPtxt);
            txtCepForn.Text = Convert.ToString(string.Format(strMascara, numCEPtxt));
        }
    }
}
