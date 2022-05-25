namespace ControlFood
{
    partial class frm_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Fornecedor));
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCnpjForn = new System.Windows.Forms.TextBox();
            this.pcb_Exclusao = new System.Windows.Forms.PictureBox();
            this.pcb_Edicao = new System.Windows.Forms.PictureBox();
            this.lbl_codForn = new System.Windows.Forms.Label();
            this.gpb_FrmFornecedor = new System.Windows.Forms.GroupBox();
            this.txtNomeFantasiaForn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_CodigoTag = new System.Windows.Forms.Label();
            this.txtCepForn = new System.Windows.Forms.TextBox();
            this.txtUfForn = new System.Windows.Forms.TextBox();
            this.pcb_Cancelar = new System.Windows.Forms.PictureBox();
            this.txtCidadeForn = new System.Windows.Forms.TextBox();
            this.pcb_Confirmar = new System.Windows.Forms.PictureBox();
            this.txtBairroForn = new System.Windows.Forms.TextBox();
            this.txtNumForn = new System.Windows.Forms.TextBox();
            this.txtEnderecoForn = new System.Windows.Forms.TextBox();
            this.txtTelForn = new System.Windows.Forms.TextBox();
            this.txtRazaoSocialForn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcb_Voltar = new System.Windows.Forms.PictureBox();
            this.pcb_Excluir = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarAoMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcb_Pesquisar = new System.Windows.Forms.PictureBox();
            this.pcb_Inserir = new System.Windows.Forms.PictureBox();
            this.pcb_Editar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Exclusao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Edicao)).BeginInit();
            this.gpb_FrmFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Confirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Excluir)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Pesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Inserir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Editar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(6, 32);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.RowTemplate.Height = 25;
            this.dgvFornecedor.Size = new System.Drawing.Size(430, 265);
            this.dgvFornecedor.TabIndex = 0;
            this.dgvFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(346, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 312);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualização Banco de Dados";
            // 
            // txtCnpjForn
            // 
            this.txtCnpjForn.Location = new System.Drawing.Point(55, 82);
            this.txtCnpjForn.Name = "txtCnpjForn";
            this.txtCnpjForn.PlaceholderText = "99.999.999/9999-99";
            this.txtCnpjForn.Size = new System.Drawing.Size(112, 23);
            this.txtCnpjForn.TabIndex = 3;
            this.txtCnpjForn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCnpjForn.Leave += new System.EventHandler(this.txtCnpjForn_Leave);
            // 
            // pcb_Exclusao
            // 
            this.pcb_Exclusao.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Exclusao.Image")));
            this.pcb_Exclusao.Location = new System.Drawing.Point(211, 209);
            this.pcb_Exclusao.Name = "pcb_Exclusao";
            this.pcb_Exclusao.Size = new System.Drawing.Size(25, 31);
            this.pcb_Exclusao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Exclusao.TabIndex = 21;
            this.pcb_Exclusao.TabStop = false;
            this.pcb_Exclusao.Visible = false;
            this.pcb_Exclusao.Click += new System.EventHandler(this.pcb_Exclusao_Click);
            // 
            // pcb_Edicao
            // 
            this.pcb_Edicao.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Edicao.Image")));
            this.pcb_Edicao.Location = new System.Drawing.Point(180, 209);
            this.pcb_Edicao.Name = "pcb_Edicao";
            this.pcb_Edicao.Size = new System.Drawing.Size(25, 31);
            this.pcb_Edicao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Edicao.TabIndex = 20;
            this.pcb_Edicao.TabStop = false;
            this.pcb_Edicao.Visible = false;
            this.pcb_Edicao.Click += new System.EventHandler(this.pcb_Edicao_Click);
            // 
            // lbl_codForn
            // 
            this.lbl_codForn.AutoSize = true;
            this.lbl_codForn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_codForn.ForeColor = System.Drawing.Color.Red;
            this.lbl_codForn.Location = new System.Drawing.Point(58, 243);
            this.lbl_codForn.Name = "lbl_codForn";
            this.lbl_codForn.Size = new System.Drawing.Size(121, 22);
            this.lbl_codForn.TabIndex = 19;
            this.lbl_codForn.Text = "Sem Código";
            this.lbl_codForn.Visible = false;
            // 
            // gpb_FrmFornecedor
            // 
            this.gpb_FrmFornecedor.Controls.Add(this.txtNomeFantasiaForn);
            this.gpb_FrmFornecedor.Controls.Add(this.label10);
            this.gpb_FrmFornecedor.Controls.Add(this.txtCnpjForn);
            this.gpb_FrmFornecedor.Controls.Add(this.pcb_Exclusao);
            this.gpb_FrmFornecedor.Controls.Add(this.pcb_Edicao);
            this.gpb_FrmFornecedor.Controls.Add(this.lbl_codForn);
            this.gpb_FrmFornecedor.Controls.Add(this.lbl_CodigoTag);
            this.gpb_FrmFornecedor.Controls.Add(this.txtCepForn);
            this.gpb_FrmFornecedor.Controls.Add(this.txtUfForn);
            this.gpb_FrmFornecedor.Controls.Add(this.pcb_Cancelar);
            this.gpb_FrmFornecedor.Controls.Add(this.txtCidadeForn);
            this.gpb_FrmFornecedor.Controls.Add(this.pcb_Confirmar);
            this.gpb_FrmFornecedor.Controls.Add(this.txtBairroForn);
            this.gpb_FrmFornecedor.Controls.Add(this.txtNumForn);
            this.gpb_FrmFornecedor.Controls.Add(this.txtEnderecoForn);
            this.gpb_FrmFornecedor.Controls.Add(this.txtTelForn);
            this.gpb_FrmFornecedor.Controls.Add(this.txtRazaoSocialForn);
            this.gpb_FrmFornecedor.Controls.Add(this.label9);
            this.gpb_FrmFornecedor.Controls.Add(this.label8);
            this.gpb_FrmFornecedor.Controls.Add(this.label7);
            this.gpb_FrmFornecedor.Controls.Add(this.label6);
            this.gpb_FrmFornecedor.Controls.Add(this.label5);
            this.gpb_FrmFornecedor.Controls.Add(this.label4);
            this.gpb_FrmFornecedor.Controls.Add(this.label3);
            this.gpb_FrmFornecedor.Controls.Add(this.label2);
            this.gpb_FrmFornecedor.Controls.Add(this.label1);
            this.gpb_FrmFornecedor.Location = new System.Drawing.Point(10, 65);
            this.gpb_FrmFornecedor.Name = "gpb_FrmFornecedor";
            this.gpb_FrmFornecedor.Size = new System.Drawing.Size(330, 280);
            this.gpb_FrmFornecedor.TabIndex = 16;
            this.gpb_FrmFornecedor.TabStop = false;
            this.gpb_FrmFornecedor.Text = "Ficha Fornecedor";
            this.gpb_FrmFornecedor.Visible = false;
            // 
            // txtNomeFantasiaForn
            // 
            this.txtNomeFantasiaForn.Location = new System.Drawing.Point(95, 50);
            this.txtNomeFantasiaForn.Name = "txtNomeFantasiaForn";
            this.txtNomeFantasiaForn.PlaceholderText = "Insira a Razão Social";
            this.txtNomeFantasiaForn.Size = new System.Drawing.Size(229, 23);
            this.txtNomeFantasiaForn.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nome Fantasia";
            // 
            // lbl_CodigoTag
            // 
            this.lbl_CodigoTag.AutoSize = true;
            this.lbl_CodigoTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CodigoTag.Location = new System.Drawing.Point(6, 250);
            this.lbl_CodigoTag.Name = "lbl_CodigoTag";
            this.lbl_CodigoTag.Size = new System.Drawing.Size(49, 14);
            this.lbl_CodigoTag.TabIndex = 18;
            this.lbl_CodigoTag.Text = "Código";
            this.lbl_CodigoTag.Visible = false;
            // 
            // txtCepForn
            // 
            this.txtCepForn.Location = new System.Drawing.Point(43, 213);
            this.txtCepForn.Name = "txtCepForn";
            this.txtCepForn.PlaceholderText = "99.999-999";
            this.txtCepForn.Size = new System.Drawing.Size(124, 23);
            this.txtCepForn.TabIndex = 10;
            this.txtCepForn.Leave += new System.EventHandler(this.txtCepForn_Leave);
            // 
            // txtUfForn
            // 
            this.txtUfForn.Location = new System.Drawing.Point(241, 180);
            this.txtUfForn.Name = "txtUfForn";
            this.txtUfForn.PlaceholderText = "Insira Estado";
            this.txtUfForn.Size = new System.Drawing.Size(83, 23);
            this.txtUfForn.TabIndex = 9;
            // 
            // pcb_Cancelar
            // 
            this.pcb_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Cancelar.Image")));
            this.pcb_Cancelar.Location = new System.Drawing.Point(296, 209);
            this.pcb_Cancelar.Name = "pcb_Cancelar";
            this.pcb_Cancelar.Size = new System.Drawing.Size(25, 31);
            this.pcb_Cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Cancelar.TabIndex = 6;
            this.pcb_Cancelar.TabStop = false;
            this.pcb_Cancelar.Click += new System.EventHandler(this.pcb_Cancelar_Click);
            // 
            // txtCidadeForn
            // 
            this.txtCidadeForn.Location = new System.Drawing.Point(64, 180);
            this.txtCidadeForn.Name = "txtCidadeForn";
            this.txtCidadeForn.PlaceholderText = "Insira Cidade";
            this.txtCidadeForn.Size = new System.Drawing.Size(141, 23);
            this.txtCidadeForn.TabIndex = 8;
            // 
            // pcb_Confirmar
            // 
            this.pcb_Confirmar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Confirmar.Image")));
            this.pcb_Confirmar.Location = new System.Drawing.Point(265, 209);
            this.pcb_Confirmar.Name = "pcb_Confirmar";
            this.pcb_Confirmar.Size = new System.Drawing.Size(25, 31);
            this.pcb_Confirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Confirmar.TabIndex = 5;
            this.pcb_Confirmar.TabStop = false;
            this.pcb_Confirmar.Click += new System.EventHandler(this.pcb_Confirmar_Click);
            // 
            // txtBairroForn
            // 
            this.txtBairroForn.Location = new System.Drawing.Point(173, 147);
            this.txtBairroForn.Name = "txtBairroForn";
            this.txtBairroForn.PlaceholderText = "Insira o Bairro";
            this.txtBairroForn.Size = new System.Drawing.Size(151, 23);
            this.txtBairroForn.TabIndex = 7;
            // 
            // txtNumForn
            // 
            this.txtNumForn.Location = new System.Drawing.Point(71, 148);
            this.txtNumForn.Name = "txtNumForn";
            this.txtNumForn.PlaceholderText = "999";
            this.txtNumForn.Size = new System.Drawing.Size(49, 23);
            this.txtNumForn.TabIndex = 6;
            // 
            // txtEnderecoForn
            // 
            this.txtEnderecoForn.Location = new System.Drawing.Point(71, 114);
            this.txtEnderecoForn.Name = "txtEnderecoForn";
            this.txtEnderecoForn.PlaceholderText = "Insira o Endereço";
            this.txtEnderecoForn.Size = new System.Drawing.Size(253, 23);
            this.txtEnderecoForn.TabIndex = 5;
            // 
            // txtTelForn
            // 
            this.txtTelForn.Location = new System.Drawing.Point(211, 82);
            this.txtTelForn.Name = "txtTelForn";
            this.txtTelForn.PlaceholderText = "(99)99999-1234";
            this.txtTelForn.Size = new System.Drawing.Size(113, 23);
            this.txtTelForn.TabIndex = 4;
            this.txtTelForn.Leave += new System.EventHandler(this.txtTelForn_Leave);
            // 
            // txtRazaoSocialForn
            // 
            this.txtRazaoSocialForn.Location = new System.Drawing.Point(84, 16);
            this.txtRazaoSocialForn.Name = "txtRazaoSocialForn";
            this.txtRazaoSocialForn.PlaceholderText = "Insira a Razão Social";
            this.txtRazaoSocialForn.Size = new System.Drawing.Size(240, 23);
            this.txtRazaoSocialForn.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "CEP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razão Social";
            // 
            // pcb_Voltar
            // 
            this.pcb_Voltar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Voltar.Image")));
            this.pcb_Voltar.Location = new System.Drawing.Point(306, 26);
            this.pcb_Voltar.Name = "pcb_Voltar";
            this.pcb_Voltar.Size = new System.Drawing.Size(25, 30);
            this.pcb_Voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Voltar.TabIndex = 15;
            this.pcb_Voltar.TabStop = false;
            // 
            // pcb_Excluir
            // 
            this.pcb_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Excluir.Image")));
            this.pcb_Excluir.Location = new System.Drawing.Point(105, 26);
            this.pcb_Excluir.Name = "pcb_Excluir";
            this.pcb_Excluir.Size = new System.Drawing.Size(25, 30);
            this.pcb_Excluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Excluir.TabIndex = 14;
            this.pcb_Excluir.TabStop = false;
            this.pcb_Excluir.Click += new System.EventHandler(this.pcb_Excluir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.voltarAoMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // voltarAoMenuToolStripMenuItem
            // 
            this.voltarAoMenuToolStripMenuItem.Name = "voltarAoMenuToolStripMenuItem";
            this.voltarAoMenuToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.voltarAoMenuToolStripMenuItem.Text = "Voltar ao Menu";
            // 
            // pcb_Pesquisar
            // 
            this.pcb_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Pesquisar.Image")));
            this.pcb_Pesquisar.Location = new System.Drawing.Point(74, 26);
            this.pcb_Pesquisar.Name = "pcb_Pesquisar";
            this.pcb_Pesquisar.Size = new System.Drawing.Size(25, 30);
            this.pcb_Pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Pesquisar.TabIndex = 13;
            this.pcb_Pesquisar.TabStop = false;
            this.pcb_Pesquisar.Click += new System.EventHandler(this.pcb_Pesquisar_Click);
            // 
            // pcb_Inserir
            // 
            this.pcb_Inserir.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Inserir.Image")));
            this.pcb_Inserir.Location = new System.Drawing.Point(12, 26);
            this.pcb_Inserir.Name = "pcb_Inserir";
            this.pcb_Inserir.Size = new System.Drawing.Size(25, 30);
            this.pcb_Inserir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Inserir.TabIndex = 11;
            this.pcb_Inserir.TabStop = false;
            this.pcb_Inserir.Click += new System.EventHandler(this.pcb_Inserir_Click);
            // 
            // pcb_Editar
            // 
            this.pcb_Editar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Editar.Image")));
            this.pcb_Editar.Location = new System.Drawing.Point(43, 26);
            this.pcb_Editar.Name = "pcb_Editar";
            this.pcb_Editar.Size = new System.Drawing.Size(25, 30);
            this.pcb_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Editar.TabIndex = 12;
            this.pcb_Editar.TabStop = false;
            this.pcb_Editar.Click += new System.EventHandler(this.pcb_Editar_Click);
            // 
            // frm_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_FrmFornecedor);
            this.Controls.Add(this.pcb_Voltar);
            this.Controls.Add(this.pcb_Excluir);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pcb_Pesquisar);
            this.Controls.Add(this.pcb_Inserir);
            this.Controls.Add(this.pcb_Editar);
            this.Name = "frm_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlFood - Automação de Bar e Restaurante - Módulo Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Exclusao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Edicao)).EndInit();
            this.gpb_FrmFornecedor.ResumeLayout(false);
            this.gpb_FrmFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Confirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Excluir)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Pesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Inserir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Editar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dgvFornecedor;
        private GroupBox groupBox1;
        private TextBox txtCnpjForn;
        private PictureBox pcb_Exclusao;
        private PictureBox pcb_Edicao;
        private Label lbl_codForn;
        private GroupBox gpb_FrmFornecedor;
        private Label lbl_CodigoTag;
        private TextBox txtCepForn;
        private TextBox txtUfForn;
        private PictureBox pcb_Cancelar;
        private TextBox txtCidadeForn;
        private PictureBox pcb_Confirmar;
        private TextBox txtBairroForn;
        private TextBox txtNumForn;
        private TextBox txtEnderecoForn;
        private TextBox txtTelForn;
        private TextBox txtRazaoSocialForn;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pcb_Voltar;
        private PictureBox pcb_Excluir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem voltarAoMenuToolStripMenuItem;
        private PictureBox pcb_Pesquisar;
        private PictureBox pcb_Inserir;
        private PictureBox pcb_Editar;
        private TextBox txtNomeFantasiaForn;
        private Label label10;
    }
}