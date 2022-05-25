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
    public partial class frm_Funcionario : Form
    {
        public frm_Funcionario()
        {
            InitializeComponent();
        }

        private void pcb_Inserir_Click(object sender, EventArgs e)
        {
            gpb_FrmFuncionario.Visible = true; //Deixando o GroupBox referente ao formulário Visivel
            txtNomeFunc.Focus(); //Dando foco na textbox especifica
        }

        private void pcb_Editar_Click(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaFunc = new frm_Pesquisa();
            newPesquisaFunc.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaFunc.rdb_Nome.Visible = false;
            newPesquisaFunc.rdb_CPF.Visible = false;
            newPesquisaFunc.rdb_NomeFunc.Visible = true;
            newPesquisaFunc.rdb_CodFuncionario.Visible = true;
            newPesquisaFunc.rdb_CNPJ.Visible = false;
            newPesquisaFunc.rdb_RazaoSocial.Visible = false;
            newPesquisaFunc.rdb_CodigoProduto.Visible = false;
            newPesquisaFunc.rdb_CodBarras.Visible = false;
            newPesquisaFunc.rdb_Descricao.Visible = false;
            newPesquisaFunc.txt_Pesquisa.Focus();


        }

        class_Funcionarios cadFunc = new class_Funcionarios();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Criação de variaveis para obtenção de dados do Banco de Dados Clicando direto na Datagrid do formulario.
            int codigoCli = dgv_Funcionario.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_Funcionario.Rows[codigoCli];
            string codigoFuncionario = Convert.ToString(selectedRow.Cells["codigo"].Value);
            string nomeFuncionario = Convert.ToString(selectedRow.Cells["nome"].Value);
            string cpfFuncionario = Convert.ToString(selectedRow.Cells["cpf"].Value);
            string telefoneFuncionario = Convert.ToString(selectedRow.Cells["telefone"].Value);
            string enderecoFuncionario = Convert.ToString(selectedRow.Cells["endereco"].Value);
            string numeroFuncionario = Convert.ToString(selectedRow.Cells["numero"].Value);
            string bairroFuncionario = Convert.ToString(selectedRow.Cells["bairro"].Value);
            string cidadeFuncionario = Convert.ToString(selectedRow.Cells["cidade"].Value);
            string ufFuncionario = Convert.ToString(selectedRow.Cells["Estado"].Value);
            string cepFuncionario = Convert.ToString(selectedRow.Cells["cep"].Value);

            //Controle de vizualização de botões do formulário
            gpb_FrmFuncionario.Visible = true;
            pcb_Edicao.Visible = true;
            pcb_Confirmar.Visible = false;
            pcb_Exclusao.Visible = true;
            lbl_CodigoTag.Visible = true;
            lbl_codFunc.Visible = true;

            //Passando dados das variaveis para os campos do formulário
            lbl_codFunc.Text = codigoFuncionario;
            txtNomeFunc.Text = nomeFuncionario;
            txtCpfFunc.Text = cpfFuncionario;
            txtTelFunc.Text = telefoneFuncionario;
            txtEnderecoFunc.Text = enderecoFuncionario;
            txtNumFunc.Text = numeroFuncionario;
            txtBairroFunc.Text = bairroFuncionario;
            txtCidadeFunc.Text = cidadeFuncionario;
            txtUfFunc.Text = ufFuncionario;
            txtCepFunc.Text = cepFuncionario;

            //Recebendo dados pelo método SET
            cadFunc.setCodFunc(Int32.Parse(codigoFuncionario));
            cadFunc.setNomeFunc(nomeFuncionario);
            cadFunc.setCpfFunc(cpfFuncionario);
            cadFunc.setTelFunc(telefoneFuncionario);
            cadFunc.setEnderecoFunc(enderecoFuncionario);
            cadFunc.setNumFunc(Int32.Parse(numeroFuncionario));
            cadFunc.setBairroFunc(bairroFuncionario);
            cadFunc.setCidadeFunc(cidadeFuncionario);
            cadFunc.setufFunc(ufFuncionario);
            cadFunc.setCepFunc(cepFuncionario);

        }

        private void pcb_Edicao_Click(object sender, EventArgs e)
        {
            //Mensagem de Confirmação de Ação
            if (MessageBox.Show("Deseja ALTERAR os dados do Registro?", "CONFIRMAÇÃO DE EDIÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cadFunc.setNomeFunc(txtNomeFunc.Text);
                    cadFunc.setCpfFunc(txtCpfFunc.Text);
                    cadFunc.setTelFunc(txtCpfFunc.Text);
                    cadFunc.setEnderecoFunc(txtEnderecoFunc.Text);
                    cadFunc.setNumFunc(Int32.Parse(txtNumFunc.Text));
                    cadFunc.setBairroFunc(txtBairroFunc.Text);
                    cadFunc.setCidadeFunc(txtCidadeFunc.Text);
                    cadFunc.setufFunc(txtUfFunc.Text);
                    cadFunc.setCepFunc(txtCepFunc.Text);
                    cadFunc.alterar();
                    dgv_Funcionario.DataSource = cadFunc.ConsultarCodFunc();
                }

                finally
                {
                    MessageBox.Show("Informações alteradas com sucesso");
                }
            }
        }   
        private void pcb_Pesquisar_Click_1(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaFunc = new frm_Pesquisa();
            newPesquisaFunc.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaFunc.rdb_Nome.Visible = false;
            newPesquisaFunc.rdb_CPF.Visible = false;
            newPesquisaFunc.rdb_NomeFunc.Visible = true;
            newPesquisaFunc.rdb_CodFuncionario.Visible = true;
            newPesquisaFunc.rdb_CNPJ.Visible = false;
            newPesquisaFunc.rdb_RazaoSocial.Visible = false;
            newPesquisaFunc.rdb_CodigoProduto.Visible = false;
            newPesquisaFunc.rdb_CodBarras.Visible = false;
            newPesquisaFunc.rdb_Descricao.Visible = false;
            newPesquisaFunc.txt_Pesquisa.Focus();
        }

        private void pcb_Excluir_Click_1(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaFunc = new frm_Pesquisa();
            newPesquisaFunc.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaFunc.rdb_Nome.Visible = false;
            newPesquisaFunc.rdb_CPF.Visible = false;
            newPesquisaFunc.rdb_NomeFunc.Visible = true;
            newPesquisaFunc.rdb_CodFuncionario.Visible = true;
            newPesquisaFunc.rdb_CNPJ.Visible = false;
            newPesquisaFunc.rdb_RazaoSocial.Visible = false;
            newPesquisaFunc.rdb_CodigoProduto.Visible = false;
            newPesquisaFunc.rdb_CodBarras.Visible = false;
            newPesquisaFunc.rdb_Descricao.Visible = false;
            newPesquisaFunc.txt_Pesquisa.Focus();
        }

        private void pcb_Voltar_Click(object sender, EventArgs e)
        {
            //Retornando o formulário anterior
            frm_Menu newFrm_Menu = new frm_Menu();
            newFrm_Menu.Show();
            Close();
        }

        private void pcb_Edicao_Click_1(object sender, EventArgs e)
        {
            //Mensagem de Confirmação de Ação
            if (MessageBox.Show("Deseja ALTERAR os dados do Registro?", "CONFIRMAÇÃO DE EDIÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cadFunc.setNomeFunc(txtNomeFunc.Text);
                    cadFunc.setCpfFunc(txtCpfFunc.Text);
                    cadFunc.setTelFunc(txtCpfFunc.Text);
                    cadFunc.setEnderecoFunc(txtEnderecoFunc.Text);
                    cadFunc.setNumFunc(Int32.Parse(txtNumFunc.Text));
                    cadFunc.setBairroFunc(txtBairroFunc.Text);
                    cadFunc.setCidadeFunc(txtCidadeFunc.Text);
                    cadFunc.setufFunc(txtUfFunc.Text);
                    cadFunc.setCepFunc(txtCepFunc.Text);
                    cadFunc.alterar();
                    dgv_Funcionario.DataSource = cadFunc.ConsultarCodFunc();
                }

                finally
                {
                    MessageBox.Show("Informações alteradas com sucesso");
                }
            }
        }

        private void pcb_Exclusao_Click_1(object sender, EventArgs e)
        {
            //Mensagem de Confirmação de Ação
            if (MessageBox.Show(" Deseja realmente EXCLUIR o REGISTRO? ", "CONFIRMAÇÃO DE EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cadFunc.setCodFunc(Int32.Parse(lbl_codFunc.Text));
                    cadFunc.excluir();
                    dgv_Funcionario.DataSource = cadFunc.Consultar();
                    pcb_Edicao.Visible = false;
                    pcb_Exclusao.Visible = false;
                    pcb_Confirmar.Visible = true;
                    lbl_CodigoTag.Visible = false;
                    lbl_codFunc.Visible = false;
                    txtNomeFunc.Clear();
                    txtCpfFunc.Clear();
                    txtTelFunc.Clear();
                    txtEnderecoFunc.Clear();
                    txtNumFunc.Clear();
                    txtBairroFunc.Clear();
                    txtCidadeFunc.Clear();
                    txtUfFunc.Clear();
                    txtCepFunc.Clear();
                    txtNomeFunc.Focus();
                }

                finally
                {
                    MessageBox.Show("Informações excluídas com sucesso");
                }
            }
        }

        class_Funcionarios newFunc = new class_Funcionarios();
        private void pcb_Confirmar_Click(object sender, EventArgs e)
        {
            //Recebendo Informações das TextBox do Formulário
            try
            {
                newFunc.setNomeFunc(txtNomeFunc.Text);
                newFunc.setCpfFunc(Convert.ToString(txtCpfFunc.Text));
                newFunc.setTelFunc(txtTelFunc.Text);
                newFunc.setEnderecoFunc(txtEnderecoFunc.Text);
                newFunc.setNumFunc(Int32.Parse(txtNumFunc.Text));
                newFunc.setBairroFunc(txtBairroFunc.Text);
                newFunc.setCidadeFunc(txtCidadeFunc.Text);
                newFunc.setufFunc(txtUfFunc.Text);
                newFunc.setCepFunc(txtCepFunc.Text);
                newFunc.inserir();
                dgv_Funcionario.DataSource = newFunc.Consultar();
            }
            finally
            {
                MessageBox.Show("Registro Inserido com Sucesso!!!");
                //Limpeza dos Campos Preenchidos
                txtNomeFunc.Clear();
                txtCpfFunc.Clear();
                txtTelFunc.Clear();
                txtEnderecoFunc.Clear();
                txtNumFunc.Clear();
                txtBairroFunc.Clear();
                txtCidadeFunc.Clear();
                txtUfFunc.Clear();
                txtCepFunc.Clear();
                txtNomeFunc.Focus();
            }
        }

        private void pcb_Cancelar_Click(object sender, EventArgs e)
        {
            /*Botão Cancelar é utillizado para abortar a operação de inserção indevida, limpando dados inseridos e tornando o GroupBox referente ao cadastro invisivel novamente. */

            txtNomeFunc.Clear();
            txtCpfFunc.Clear();
            txtTelFunc.Clear();
            txtEnderecoFunc.Clear();
            txtNumFunc.Clear();
            txtBairroFunc.Clear();
            txtCidadeFunc.Clear();
            txtUfFunc.Clear();
            txtCepFunc.Clear();
            gpb_FrmFuncionario.Visible = false;

        }

        private void dgv_Funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Criação de variaveis para obtenção de dados do Banco de Dados Clicando direto na Datagrid do formulario.
            int codigoCli = dgv_Funcionario.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_Funcionario.Rows[codigoCli];
            string codigoFuncionario = Convert.ToString(selectedRow.Cells["codigo"].Value);
            string nomeFuncionario = Convert.ToString(selectedRow.Cells["nome"].Value);
            string cpfFuncionario = Convert.ToString(selectedRow.Cells["cpf"].Value);
            string telefoneFuncionario = Convert.ToString(selectedRow.Cells["telefone"].Value);
            string enderecoFuncionario = Convert.ToString(selectedRow.Cells["endereco"].Value);
            string numeroFuncionario = Convert.ToString(selectedRow.Cells["numero"].Value);
            string bairroFuncionario = Convert.ToString(selectedRow.Cells["bairro"].Value);
            string cidadeFuncionario = Convert.ToString(selectedRow.Cells["cidade"].Value);
            string ufFuncionario = Convert.ToString(selectedRow.Cells["Estado"].Value);
            string cepFuncionario = Convert.ToString(selectedRow.Cells["cep"].Value);

            //Controle de vizualização de botões do formulário
            gpb_FrmFuncionario.Visible = true;
            pcb_Edicao.Visible = true;
            pcb_Confirmar.Visible = false;
            pcb_Exclusao.Visible = true;
            lbl_CodigoTag.Visible = true;
            lbl_codFunc.Visible = true;

            //Passando dados das variaveis para os campos do formulário
            lbl_codFunc.Text = codigoFuncionario;
            txtNomeFunc.Text = nomeFuncionario;
            txtCpfFunc.Text = cpfFuncionario;
            txtTelFunc.Text = telefoneFuncionario;
            txtEnderecoFunc.Text = enderecoFuncionario;
            txtNumFunc.Text = numeroFuncionario;
            txtBairroFunc.Text = bairroFuncionario;
            txtCidadeFunc.Text = cidadeFuncionario;
            txtUfFunc.Text = ufFuncionario;
            txtCepFunc.Text = cepFuncionario;

            //Recebendo dados pelo método SET
            cadFunc.setCodFunc(Int32.Parse(codigoFuncionario));
            cadFunc.setNomeFunc(nomeFuncionario);
            cadFunc.setCpfFunc(cpfFuncionario);
            cadFunc.setTelFunc(telefoneFuncionario);
            cadFunc.setEnderecoFunc(enderecoFuncionario);
            cadFunc.setNumFunc(Int32.Parse(numeroFuncionario));
            cadFunc.setBairroFunc(bairroFuncionario);
            cadFunc.setCidadeFunc(cidadeFuncionario);
            cadFunc.setufFunc(ufFuncionario);
            cadFunc.setCepFunc(cepFuncionario);
        }

        private void txtCpfFunc_Leave(object sender, EventArgs e)
        {
            /* 
            Aplicação de Mascara ao CPF
            1. Ative a o Evento Focus -> Leave da sua TextBox
            2. Crie uma variavel para receber o valor digitado em sua TextBox
            3. Converta o valor da TextBox em Numero 
            4. Aplique a mascara que deseja 
            5. Retorne o valor da variavel para sua textbox agora com a mascara.
            */

            long numCPFtxt = long.Parse(txtCpfFunc.Text);
            string strMascara = string.Format(@"{0:000\.000\.000\-00}", numCPFtxt);
            string cpfMascara = Convert.ToString(string.Format(strMascara, numCPFtxt));
            txtCpfFunc.Text = cpfMascara;
        }

        private void txtTelFunc_Leave(object sender, EventArgs e)
        {
            long numTeltxt = long.Parse(txtTelFunc.Text);
            string strMascara = string.Format(@"{0:(00)00000-0000}", numTeltxt);
            txtTelFunc.Text = Convert.ToString(string.Format(strMascara, numTeltxt));
        }

        private void txtCepFunc_Leave(object sender, EventArgs e)
        {
            long numCEPtxt = long.Parse(txtCepFunc.Text);
            string strMascara = string.Format(@"{0:00\.000\-000}", numCEPtxt);
            txtCepFunc.Text = Convert.ToString(string.Format(strMascara, numCEPtxt));
        }

        private void adicionarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gpb_FrmFuncionario.Visible = true; //Deixando o GroupBox referente ao formulário Visivel
            txtNomeFunc.Focus(); //Dando foco na textbox especifica
        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_Pesquisa newPesquisaFunc = new frm_Pesquisa();
            newPesquisaFunc.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaFunc.rdb_Nome.Visible = false;
            newPesquisaFunc.rdb_CPF.Visible = false;
            newPesquisaFunc.rdb_NomeFunc.Visible = true;
            newPesquisaFunc.rdb_CodFuncionario.Visible = true;
            newPesquisaFunc.rdb_CNPJ.Visible = false;
            newPesquisaFunc.rdb_RazaoSocial.Visible = false;
            newPesquisaFunc.rdb_CodigoProduto.Visible = false;
            newPesquisaFunc.rdb_CodBarras.Visible = false;
            newPesquisaFunc.rdb_Descricao.Visible = false;
            newPesquisaFunc.txt_Pesquisa.Focus();
        }

        private void pesquisarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_Pesquisa newPesquisaFunc = new frm_Pesquisa();
            newPesquisaFunc.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaFunc.rdb_Nome.Visible = false;
            newPesquisaFunc.rdb_CPF.Visible = false;
            newPesquisaFunc.rdb_NomeFunc.Visible = true;
            newPesquisaFunc.rdb_CodFuncionario.Visible = true;
            newPesquisaFunc.rdb_CNPJ.Visible = false;
            newPesquisaFunc.rdb_RazaoSocial.Visible = false;
            newPesquisaFunc.rdb_CodigoProduto.Visible = false;
            newPesquisaFunc.rdb_CodBarras.Visible = false;
            newPesquisaFunc.rdb_Descricao.Visible = false;
            newPesquisaFunc.txt_Pesquisa.Focus();
        }

        private void excluirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_Pesquisa newPesquisaFunc = new frm_Pesquisa();
            newPesquisaFunc.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaFunc.rdb_Nome.Visible = false;
            newPesquisaFunc.rdb_CPF.Visible = false;
            newPesquisaFunc.rdb_NomeFunc.Visible = true;
            newPesquisaFunc.rdb_CodFuncionario.Visible = true;
            newPesquisaFunc.rdb_CNPJ.Visible = false;
            newPesquisaFunc.rdb_RazaoSocial.Visible = false;
            newPesquisaFunc.rdb_CodigoProduto.Visible = false;
            newPesquisaFunc.rdb_CodBarras.Visible = false;
            newPesquisaFunc.rdb_Descricao.Visible = false;
            newPesquisaFunc.txt_Pesquisa.Focus();
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Menu newFrm_Menu = new frm_Menu();
            newFrm_Menu.Show();
            Close();
        }
    }
}