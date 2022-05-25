﻿using System;
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
            //Retornando o formulário anterior
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
                newCli.setCpfCli(Convert.ToString(txtCpfCli.Text));
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
                //Limpeza dos Campos Preenchidos
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
            gpb_FrmCliente.Visible=true; //Deixando o GroupBox referente ao formulário Visivel
            txtNomeCli.Focus(); //Dando foco na textbox especifica
        }

        private void pcb_Cancelar_Click(object sender, EventArgs e)
        {
            /*Botão Cancelar é utillizado para abortar a operação de inserção indevida, limpando dados inseridos e tornando o GroupBox referente ao cadastro invisivel novamente. */

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

        private void pcb_Editar_Click(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaCli = new frm_Pesquisa();
            newPesquisaCli.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaCli.rdb_Nome.Visible = true;
            newPesquisaCli.rdb_CPF.Visible = true;
            newPesquisaCli.rdb_NomeFunc.Visible = false;
            newPesquisaCli.rdb_CodFuncionario.Visible = false;
            newPesquisaCli.rdb_CNPJ.Visible = false;
            newPesquisaCli.rdb_RazaoSocial.Visible = false;
            newPesquisaCli.rdb_CodigoProduto.Visible = false;
            newPesquisaCli.rdb_CodBarras.Visible = false;
            newPesquisaCli.rdb_Descricao.Visible = false;
            newPesquisaCli.txt_Pesquisa.Focus();
            

        }

        class_Clientes cadCli = new class_Clientes();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Criação de variaveis para obtenção de dados do Banco de Dados Clicando direto na Datagrid do formulario.
            int codigoCli = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[codigoCli];
            string codigoCliente = Convert.ToString(selectedRow.Cells["codigo"].Value);
            string nomeCliente = Convert.ToString(selectedRow.Cells["nome"].Value);
            string cpfCliente = Convert.ToString(selectedRow.Cells["cpf"].Value);
            string telefoneCliente = Convert.ToString(selectedRow.Cells["telefone"].Value);
            string enderecoCliente = Convert.ToString(selectedRow.Cells["endereco"].Value);
            string numeroCliente = Convert.ToString(selectedRow.Cells["numero"].Value);
            string bairroCliente = Convert.ToString(selectedRow.Cells["bairro"].Value);
            string cidadeCliente = Convert.ToString(selectedRow.Cells["cidade"].Value);
            string ufCliente = Convert.ToString(selectedRow.Cells["Estado"].Value);
            string cepCliente = Convert.ToString(selectedRow.Cells["cep"].Value);

            //Controle de vizualização de botões do formulário
            gpb_FrmCliente.Visible = true;
            pcb_Edicao.Visible = true;
            pcb_Confirmar.Visible = false;
            pcb_Exclusao.Visible = true;
            lbl_CodigoTag.Visible=true;
            lbl_codCli.Visible = true;
           
            //Passando dados das variaveis para os campos do formulário
            lbl_codCli.Text = codigoCliente;
            txtNomeCli.Text = nomeCliente;
            txtCpfCli.Text = cpfCliente;
            txtTelCli.Text = telefoneCliente;
            txtEnderecoCli.Text = enderecoCliente;
            txtNumCli.Text = numeroCliente;
            txtBairroCli.Text = bairroCliente;
            txtCidadeCli.Text = cidadeCliente;
            txtUfCli.Text = ufCliente;
            txtCepCli.Text = cepCliente;

            //Recebendo dados pelo método SET
            cadCli.setCodCli(Int32.Parse(codigoCliente));
            cadCli.setNomeCli(nomeCliente);
            cadCli.setCpfCli(cpfCliente);
            cadCli.setTelCli(telefoneCliente);
            cadCli.setEnderecoCli(enderecoCliente);
            cadCli.setNumCli(Int32.Parse(numeroCliente));
            cadCli.setBairroCli(bairroCliente);
            cadCli.setCidadeCli(cidadeCliente);
            cadCli.setufCli(ufCliente);
            cadCli.setCepCli(cepCliente);        

        }

        private void pcb_Edicao_Click(object sender, EventArgs e)
        {
            //Mensagem de Confirmação de Ação
            if (MessageBox.Show("Deseja ALTERAR os dados do Registro?", "CONFIRMAÇÃO DE EDIÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cadCli.setNomeCli(txtNomeCli.Text);
                    cadCli.setCpfCli(txtCpfCli.Text);
                    cadCli.setTelCli(txtTelCli.Text);
                    cadCli.setEnderecoCli(txtEnderecoCli.Text);
                    cadCli.setNumCli(Int32.Parse(txtNumCli.Text));
                    cadCli.setBairroCli(txtBairroCli.Text);
                    cadCli.setCidadeCli(txtCidadeCli.Text);
                    cadCli.setufCli(txtUfCli.Text);
                    cadCli.setCepCli(txtCepCli.Text);
                    cadCli.alterar();
                    dataGridView1.DataSource = cadCli.ConsultarCodCli();
                }

                finally
                {
                    MessageBox.Show("Informações alteradas com sucesso");
                }
            }            
        }

        private void pcb_Pesquisar_Click(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaCli = new frm_Pesquisa();
            newPesquisaCli.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaCli.rdb_Nome.Visible = true;
            newPesquisaCli.rdb_CPF.Visible = true;
            newPesquisaCli.rdb_NomeFunc.Visible = false;
            newPesquisaCli.rdb_CodFuncionario.Visible = false;
            newPesquisaCli.rdb_CNPJ.Visible = false;
            newPesquisaCli.rdb_RazaoSocial.Visible = false;
            newPesquisaCli.rdb_CodigoProduto.Visible = false;
            newPesquisaCli.rdb_CodBarras.Visible = false;
            newPesquisaCli.rdb_Descricao.Visible = false;
            newPesquisaCli.txt_Pesquisa.Focus();
        }

        private void pcb_Excluir_Click(object sender, EventArgs e)
        {
            //Chamada do formulário de pesquisa para realizar edição dos dados.
            frm_Pesquisa newPesquisaCli = new frm_Pesquisa();
            newPesquisaCli.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaCli.rdb_Nome.Visible = true;
            newPesquisaCli.rdb_CPF.Visible = true;
            newPesquisaCli.rdb_NomeFunc.Visible = false;
            newPesquisaCli.rdb_CodFuncionario.Visible = false;
            newPesquisaCli.rdb_CNPJ.Visible = false;
            newPesquisaCli.rdb_RazaoSocial.Visible = false;
            newPesquisaCli.rdb_CodigoProduto.Visible = false;
            newPesquisaCli.rdb_CodBarras.Visible = false;
            newPesquisaCli.rdb_Descricao.Visible = false;
            newPesquisaCli.txt_Pesquisa.Focus();
        }

        private void pcb_Exclusao_Click(object sender, EventArgs e)
        {
            //Mensagem de Confirmação de Ação
            if (MessageBox.Show(" Deseja realmente EXCLUIR o REGISTRO? ", "CONFIRMAÇÃO DE EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cadCli.setCodCli(Int32.Parse(lbl_codCli.Text));
                    cadCli.excluir();
                    dataGridView1.DataSource = cadCli.Consultar();
                    pcb_Edicao.Visible = false;
                    pcb_Exclusao.Visible = false;
                    pcb_Confirmar.Visible = true;
                    lbl_CodigoTag.Visible = false;
                    lbl_codCli.Visible = false;
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

                finally
                {
                    MessageBox.Show("Informações excluídas com sucesso");
                }
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpb_FrmCliente.Visible = true; //Deixando o GroupBox referente ao formulário Visivel
            txtNomeCli.Focus(); //Dando foco na textbox especifica
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pesquisa newPesquisaCli = new frm_Pesquisa();
            newPesquisaCli.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaCli.rdb_Nome.Visible = true;
            newPesquisaCli.rdb_CPF.Visible = true;
            newPesquisaCli.rdb_NomeFunc.Visible = false;
            newPesquisaCli.rdb_CodFuncionario.Visible = false;
            newPesquisaCli.rdb_CNPJ.Visible = false;
            newPesquisaCli.rdb_RazaoSocial.Visible = false;
            newPesquisaCli.rdb_CodigoProduto.Visible = false;
            newPesquisaCli.rdb_CodBarras.Visible = false;
            newPesquisaCli.rdb_Descricao.Visible = false;
            newPesquisaCli.txt_Pesquisa.Focus();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pesquisa newPesquisaCli = new frm_Pesquisa();
            newPesquisaCli.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaCli.rdb_Nome.Visible = true;
            newPesquisaCli.rdb_CPF.Visible = true;
            newPesquisaCli.rdb_NomeFunc.Visible = false;
            newPesquisaCli.rdb_CodFuncionario.Visible = false;
            newPesquisaCli.rdb_CNPJ.Visible = false;
            newPesquisaCli.rdb_RazaoSocial.Visible = false;
            newPesquisaCli.rdb_CodigoProduto.Visible = false;
            newPesquisaCli.rdb_CodBarras.Visible = false;
            newPesquisaCli.rdb_Descricao.Visible = false;
            newPesquisaCli.txt_Pesquisa.Focus();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pesquisa newPesquisaCli = new frm_Pesquisa();
            newPesquisaCli.Show();

            /*Controle de visualização de radioButton para pesquisas personalizadas conforme o módulo acessado. */
            newPesquisaCli.rdb_Nome.Visible = true;
            newPesquisaCli.rdb_CPF.Visible = true;
            newPesquisaCli.rdb_NomeFunc.Visible = false;
            newPesquisaCli.rdb_CodFuncionario.Visible = false;
            newPesquisaCli.rdb_CNPJ.Visible = false;
            newPesquisaCli.rdb_RazaoSocial.Visible = false;
            newPesquisaCli.rdb_CodigoProduto.Visible = false;
            newPesquisaCli.rdb_CodBarras.Visible = false;
            newPesquisaCli.rdb_Descricao.Visible = false;
            newPesquisaCli.txt_Pesquisa.Focus();
        }       

        private void txtCpfCli_Leave(object sender, EventArgs e)
        {
            /* 
            Aplicação de Mascara ao CPF
            1. Ative a o Evento Focus -> Leave da sua TextBox
            2. Crie uma variavel para receber o valor digitado em sua TextBox
            3. Converta o valor da TextBox em Numero 
            4. Aplique a mascara que deseja 
            5. Retorne o valor da variavel para sua textbox agora com a mascara.
            */

            long numCPFtxt = long.Parse(txtCpfCli.Text);            
            string strMascara = string.Format(@"{0:000\.000\.000\-00}",numCPFtxt); 
            string cpfMascara = Convert.ToString(string.Format(strMascara, numCPFtxt));           
            txtCpfCli.Text = cpfMascara;   
        }

        private void txtTelCli_Leave(object sender, EventArgs e)
        {
            long numTeltxt = long.Parse(txtTelCli.Text);
            string strMascara = string.Format(@"{0:(00)00000-0000}", numTeltxt);
            txtTelCli.Text =Convert.ToString(string.Format(strMascara, numTeltxt));
        }

        private void txtCepCli_Leave(object sender, EventArgs e)
        {
            long numCEPtxt = long.Parse(txtCepCli.Text);
            string strMascara = string.Format(@"{0:00\.000\-000}", numCEPtxt);
            txtCepCli.Text = Convert.ToString(string.Format(strMascara, numCEPtxt));
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Retornando o formulário anterior
            frm_Menu newFrm_Menu = new frm_Menu();
            newFrm_Menu.Show();
            Close();
        }
    }
}
