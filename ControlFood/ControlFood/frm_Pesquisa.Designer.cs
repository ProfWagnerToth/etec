namespace ControlFood
{
    partial class frm_Pesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pesquisa));
            this.gpb_PessoaFisica = new System.Windows.Forms.GroupBox();
            this.rdb_CPF = new System.Windows.Forms.RadioButton();
            this.rdb_Nome = new System.Windows.Forms.RadioButton();
            this.gpb_PessoaJuridica = new System.Windows.Forms.GroupBox();
            this.rdb_CNPJ = new System.Windows.Forms.RadioButton();
            this.rdb_RazaoSocial = new System.Windows.Forms.RadioButton();
            this.gpb_Produtos = new System.Windows.Forms.GroupBox();
            this.rdb_CodigoProduto = new System.Windows.Forms.RadioButton();
            this.rdb_CodBarras = new System.Windows.Forms.RadioButton();
            this.rdb_Descricao = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcb_Pesquisar = new System.Windows.Forms.PictureBox();
            this.pcb_Voltar = new System.Windows.Forms.PictureBox();
            this.pcb_Excluir = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_CodFuncionario = new System.Windows.Forms.RadioButton();
            this.rdb_NomeFunc = new System.Windows.Forms.RadioButton();
            this.gpb_PessoaFisica.SuspendLayout();
            this.gpb_PessoaJuridica.SuspendLayout();
            this.gpb_Produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Pesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Excluir)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_PessoaFisica
            // 
            this.gpb_PessoaFisica.Controls.Add(this.rdb_CPF);
            this.gpb_PessoaFisica.Controls.Add(this.rdb_Nome);
            this.gpb_PessoaFisica.Location = new System.Drawing.Point(12, 12);
            this.gpb_PessoaFisica.Name = "gpb_PessoaFisica";
            this.gpb_PessoaFisica.Size = new System.Drawing.Size(156, 100);
            this.gpb_PessoaFisica.TabIndex = 0;
            this.gpb_PessoaFisica.TabStop = false;
            this.gpb_PessoaFisica.Text = "Clientes";
            this.gpb_PessoaFisica.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdb_CPF
            // 
            this.rdb_CPF.AutoSize = true;
            this.rdb_CPF.Location = new System.Drawing.Point(18, 55);
            this.rdb_CPF.Name = "rdb_CPF";
            this.rdb_CPF.Size = new System.Drawing.Size(46, 19);
            this.rdb_CPF.TabIndex = 1;
            this.rdb_CPF.TabStop = true;
            this.rdb_CPF.Text = "CPF";
            this.rdb_CPF.UseVisualStyleBackColor = true;
            // 
            // rdb_Nome
            // 
            this.rdb_Nome.AutoSize = true;
            this.rdb_Nome.Location = new System.Drawing.Point(18, 30);
            this.rdb_Nome.Name = "rdb_Nome";
            this.rdb_Nome.Size = new System.Drawing.Size(58, 19);
            this.rdb_Nome.TabIndex = 0;
            this.rdb_Nome.TabStop = true;
            this.rdb_Nome.Text = "Nome";
            this.rdb_Nome.UseVisualStyleBackColor = true;
            // 
            // gpb_PessoaJuridica
            // 
            this.gpb_PessoaJuridica.Controls.Add(this.rdb_CNPJ);
            this.gpb_PessoaJuridica.Controls.Add(this.rdb_RazaoSocial);
            this.gpb_PessoaJuridica.Location = new System.Drawing.Point(336, 12);
            this.gpb_PessoaJuridica.Name = "gpb_PessoaJuridica";
            this.gpb_PessoaJuridica.Size = new System.Drawing.Size(156, 100);
            this.gpb_PessoaJuridica.TabIndex = 1;
            this.gpb_PessoaJuridica.TabStop = false;
            this.gpb_PessoaJuridica.Text = "Pessoa Juridica";
            // 
            // rdb_CNPJ
            // 
            this.rdb_CNPJ.AutoSize = true;
            this.rdb_CNPJ.Location = new System.Drawing.Point(18, 56);
            this.rdb_CNPJ.Name = "rdb_CNPJ";
            this.rdb_CNPJ.Size = new System.Drawing.Size(52, 19);
            this.rdb_CNPJ.TabIndex = 1;
            this.rdb_CNPJ.TabStop = true;
            this.rdb_CNPJ.Text = "CNPJ";
            this.rdb_CNPJ.UseVisualStyleBackColor = true;
            // 
            // rdb_RazaoSocial
            // 
            this.rdb_RazaoSocial.AutoSize = true;
            this.rdb_RazaoSocial.Location = new System.Drawing.Point(18, 31);
            this.rdb_RazaoSocial.Name = "rdb_RazaoSocial";
            this.rdb_RazaoSocial.Size = new System.Drawing.Size(90, 19);
            this.rdb_RazaoSocial.TabIndex = 0;
            this.rdb_RazaoSocial.TabStop = true;
            this.rdb_RazaoSocial.Text = "Razão Social";
            this.rdb_RazaoSocial.UseVisualStyleBackColor = true;
            // 
            // gpb_Produtos
            // 
            this.gpb_Produtos.Controls.Add(this.rdb_CodigoProduto);
            this.gpb_Produtos.Controls.Add(this.rdb_CodBarras);
            this.gpb_Produtos.Controls.Add(this.rdb_Descricao);
            this.gpb_Produtos.Location = new System.Drawing.Point(498, 12);
            this.gpb_Produtos.Name = "gpb_Produtos";
            this.gpb_Produtos.Size = new System.Drawing.Size(156, 100);
            this.gpb_Produtos.TabIndex = 2;
            this.gpb_Produtos.TabStop = false;
            this.gpb_Produtos.Text = "Produtos";
            // 
            // rdb_CodigoProduto
            // 
            this.rdb_CodigoProduto.AutoSize = true;
            this.rdb_CodigoProduto.Location = new System.Drawing.Point(18, 50);
            this.rdb_CodigoProduto.Name = "rdb_CodigoProduto";
            this.rdb_CodigoProduto.Size = new System.Drawing.Size(110, 19);
            this.rdb_CodigoProduto.TabIndex = 2;
            this.rdb_CodigoProduto.TabStop = true;
            this.rdb_CodigoProduto.Text = "Código Produto";
            this.rdb_CodigoProduto.UseVisualStyleBackColor = true;
            // 
            // rdb_CodBarras
            // 
            this.rdb_CodBarras.AutoSize = true;
            this.rdb_CodBarras.Location = new System.Drawing.Point(18, 75);
            this.rdb_CodBarras.Name = "rdb_CodBarras";
            this.rdb_CodBarras.Size = new System.Drawing.Size(115, 19);
            this.rdb_CodBarras.TabIndex = 1;
            this.rdb_CodBarras.TabStop = true;
            this.rdb_CodBarras.Text = "Código de Barras";
            this.rdb_CodBarras.UseVisualStyleBackColor = true;
            // 
            // rdb_Descricao
            // 
            this.rdb_Descricao.AutoSize = true;
            this.rdb_Descricao.Location = new System.Drawing.Point(18, 27);
            this.rdb_Descricao.Name = "rdb_Descricao";
            this.rdb_Descricao.Size = new System.Drawing.Size(76, 19);
            this.rdb_Descricao.TabIndex = 0;
            this.rdb_Descricao.TabStop = true;
            this.rdb_Descricao.Text = "Descrição";
            this.rdb_Descricao.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(642, 113);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Location = new System.Drawing.Point(12, 140);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(518, 23);
            this.txt_Pesquisa.TabIndex = 3;
            this.txt_Pesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite sua pesquisa:";
            // 
            // pcb_Pesquisar
            // 
            this.pcb_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Pesquisar.Image")));
            this.pcb_Pesquisar.Location = new System.Drawing.Point(538, 133);
            this.pcb_Pesquisar.Name = "pcb_Pesquisar";
            this.pcb_Pesquisar.Size = new System.Drawing.Size(25, 30);
            this.pcb_Pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Pesquisar.TabIndex = 5;
            this.pcb_Pesquisar.TabStop = false;
            this.pcb_Pesquisar.Click += new System.EventHandler(this.pcb_Pesquisar_Click);
            // 
            // pcb_Voltar
            // 
            this.pcb_Voltar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Voltar.Image")));
            this.pcb_Voltar.Location = new System.Drawing.Point(599, 133);
            this.pcb_Voltar.Name = "pcb_Voltar";
            this.pcb_Voltar.Size = new System.Drawing.Size(25, 30);
            this.pcb_Voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Voltar.TabIndex = 9;
            this.pcb_Voltar.TabStop = false;
            this.pcb_Voltar.Click += new System.EventHandler(this.pcb_Voltar_Click);
            // 
            // pcb_Excluir
            // 
            this.pcb_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Excluir.Image")));
            this.pcb_Excluir.Location = new System.Drawing.Point(569, 133);
            this.pcb_Excluir.Name = "pcb_Excluir";
            this.pcb_Excluir.Size = new System.Drawing.Size(25, 30);
            this.pcb_Excluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Excluir.TabIndex = 8;
            this.pcb_Excluir.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_CodFuncionario);
            this.groupBox1.Controls.Add(this.rdb_NomeFunc);
            this.groupBox1.Location = new System.Drawing.Point(174, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionarios";
            // 
            // rdb_CodFuncionario
            // 
            this.rdb_CodFuncionario.AutoSize = true;
            this.rdb_CodFuncionario.Location = new System.Drawing.Point(6, 55);
            this.rdb_CodFuncionario.Name = "rdb_CodFuncionario";
            this.rdb_CodFuncionario.Size = new System.Drawing.Size(130, 19);
            this.rdb_CodFuncionario.TabIndex = 1;
            this.rdb_CodFuncionario.TabStop = true;
            this.rdb_CodFuncionario.Text = "Código Funcionario";
            this.rdb_CodFuncionario.UseVisualStyleBackColor = true;
            // 
            // rdb_NomeFunc
            // 
            this.rdb_NomeFunc.AutoSize = true;
            this.rdb_NomeFunc.Location = new System.Drawing.Point(6, 30);
            this.rdb_NomeFunc.Name = "rdb_NomeFunc";
            this.rdb_NomeFunc.Size = new System.Drawing.Size(58, 19);
            this.rdb_NomeFunc.TabIndex = 0;
            this.rdb_NomeFunc.TabStop = true;
            this.rdb_NomeFunc.Text = "Nome";
            this.rdb_NomeFunc.UseVisualStyleBackColor = true;
            // 
            // frm_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 296);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcb_Voltar);
            this.Controls.Add(this.pcb_Excluir);
            this.Controls.Add(this.pcb_Pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pesquisa);
            this.Controls.Add(this.gpb_Produtos);
            this.Controls.Add(this.gpb_PessoaJuridica);
            this.Controls.Add(this.gpb_PessoaFisica);
            this.Name = "frm_Pesquisa";
            this.Text = "Formulário de Pesquisa";
            this.gpb_PessoaFisica.ResumeLayout(false);
            this.gpb_PessoaFisica.PerformLayout();
            this.gpb_PessoaJuridica.ResumeLayout(false);
            this.gpb_PessoaJuridica.PerformLayout();
            this.gpb_Produtos.ResumeLayout(false);
            this.gpb_Produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Pesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Excluir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gpb_PessoaFisica;
        private GroupBox gpb_PessoaJuridica;
        private GroupBox gpb_Produtos;
        private RadioButton rdb_CPF;
        private RadioButton rdb_Nome;
        private RadioButton rdb_CNPJ;
        private RadioButton rdb_RazaoSocial;
        private RadioButton rdb_CodigoProduto;
        private RadioButton rdb_CodBarras;
        private RadioButton rdb_Descricao;
        private TextBox txt_Pesquisa;
        private Label label1;
        private PictureBox pcb_Pesquisar;
        private PictureBox pcb_Voltar;
        private PictureBox pcb_Excluir;
        private GroupBox groupBox1;
        private RadioButton rdb_CodFuncionario;
        private RadioButton rdb_NomeFunc;
        private DataGridView dataGridView1;
    }
}