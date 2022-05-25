namespace ControlFood
{
    partial class frm_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Funcionario));
            this.dgv_Funcionario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCpfFunc = new System.Windows.Forms.TextBox();
            this.pcb_Exclusao = new System.Windows.Forms.PictureBox();
            this.pcb_Edicao = new System.Windows.Forms.PictureBox();
            this.lbl_codFunc = new System.Windows.Forms.Label();
            this.gpb_FrmFuncionario = new System.Windows.Forms.GroupBox();
            this.lbl_CodigoTag = new System.Windows.Forms.Label();
            this.txtCepFunc = new System.Windows.Forms.TextBox();
            this.txtUfFunc = new System.Windows.Forms.TextBox();
            this.pcb_Cancelar = new System.Windows.Forms.PictureBox();
            this.txtCidadeFunc = new System.Windows.Forms.TextBox();
            this.pcb_Confirmar = new System.Windows.Forms.PictureBox();
            this.txtBairroFunc = new System.Windows.Forms.TextBox();
            this.txtNumFunc = new System.Windows.Forms.TextBox();
            this.txtEnderecoFunc = new System.Windows.Forms.TextBox();
            this.txtTelFunc = new System.Windows.Forms.TextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Exclusao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Edicao)).BeginInit();
            this.gpb_FrmFuncionario.SuspendLayout();
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
            // dgv_Funcionario
            // 
            this.dgv_Funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Funcionario.Location = new System.Drawing.Point(6, 32);
            this.dgv_Funcionario.Name = "dgv_Funcionario";
            this.dgv_Funcionario.RowTemplate.Height = 25;
            this.dgv_Funcionario.Size = new System.Drawing.Size(430, 215);
            this.dgv_Funcionario.TabIndex = 0;
            this.dgv_Funcionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Funcionario_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Funcionario);
            this.groupBox1.Location = new System.Drawing.Point(346, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 269);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualização Banco de Dados";
            // 
            // txtCpfFunc
            // 
            this.txtCpfFunc.Location = new System.Drawing.Point(55, 45);
            this.txtCpfFunc.Name = "txtCpfFunc";
            this.txtCpfFunc.PlaceholderText = "999.999.999-99";
            this.txtCpfFunc.Size = new System.Drawing.Size(112, 23);
            this.txtCpfFunc.TabIndex = 2;
            this.txtCpfFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCpfFunc.Leave += new System.EventHandler(this.txtCpfFunc_Leave);
            // 
            // pcb_Exclusao
            // 
            this.pcb_Exclusao.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Exclusao.Image")));
            this.pcb_Exclusao.Location = new System.Drawing.Point(211, 172);
            this.pcb_Exclusao.Name = "pcb_Exclusao";
            this.pcb_Exclusao.Size = new System.Drawing.Size(25, 30);
            this.pcb_Exclusao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Exclusao.TabIndex = 21;
            this.pcb_Exclusao.TabStop = false;
            this.pcb_Exclusao.Visible = false;
            this.pcb_Exclusao.Click += new System.EventHandler(this.pcb_Exclusao_Click_1);
            // 
            // pcb_Edicao
            // 
            this.pcb_Edicao.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Edicao.Image")));
            this.pcb_Edicao.Location = new System.Drawing.Point(180, 172);
            this.pcb_Edicao.Name = "pcb_Edicao";
            this.pcb_Edicao.Size = new System.Drawing.Size(25, 30);
            this.pcb_Edicao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Edicao.TabIndex = 20;
            this.pcb_Edicao.TabStop = false;
            this.pcb_Edicao.Visible = false;
            this.pcb_Edicao.Click += new System.EventHandler(this.pcb_Edicao_Click_1);
            // 
            // lbl_codFunc
            // 
            this.lbl_codFunc.AutoSize = true;
            this.lbl_codFunc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_codFunc.ForeColor = System.Drawing.Color.Red;
            this.lbl_codFunc.Location = new System.Drawing.Point(58, 206);
            this.lbl_codFunc.Name = "lbl_codFunc";
            this.lbl_codFunc.Size = new System.Drawing.Size(121, 22);
            this.lbl_codFunc.TabIndex = 19;
            this.lbl_codFunc.Text = "Sem Código";
            this.lbl_codFunc.Visible = false;
            // 
            // gpb_FrmFuncionario
            // 
            this.gpb_FrmFuncionario.Controls.Add(this.txtCpfFunc);
            this.gpb_FrmFuncionario.Controls.Add(this.pcb_Exclusao);
            this.gpb_FrmFuncionario.Controls.Add(this.pcb_Edicao);
            this.gpb_FrmFuncionario.Controls.Add(this.lbl_codFunc);
            this.gpb_FrmFuncionario.Controls.Add(this.lbl_CodigoTag);
            this.gpb_FrmFuncionario.Controls.Add(this.txtCepFunc);
            this.gpb_FrmFuncionario.Controls.Add(this.txtUfFunc);
            this.gpb_FrmFuncionario.Controls.Add(this.pcb_Cancelar);
            this.gpb_FrmFuncionario.Controls.Add(this.txtCidadeFunc);
            this.gpb_FrmFuncionario.Controls.Add(this.pcb_Confirmar);
            this.gpb_FrmFuncionario.Controls.Add(this.txtBairroFunc);
            this.gpb_FrmFuncionario.Controls.Add(this.txtNumFunc);
            this.gpb_FrmFuncionario.Controls.Add(this.txtEnderecoFunc);
            this.gpb_FrmFuncionario.Controls.Add(this.txtTelFunc);
            this.gpb_FrmFuncionario.Controls.Add(this.txtNomeFunc);
            this.gpb_FrmFuncionario.Controls.Add(this.label9);
            this.gpb_FrmFuncionario.Controls.Add(this.label8);
            this.gpb_FrmFuncionario.Controls.Add(this.label7);
            this.gpb_FrmFuncionario.Controls.Add(this.label6);
            this.gpb_FrmFuncionario.Controls.Add(this.label5);
            this.gpb_FrmFuncionario.Controls.Add(this.label4);
            this.gpb_FrmFuncionario.Controls.Add(this.label3);
            this.gpb_FrmFuncionario.Controls.Add(this.label2);
            this.gpb_FrmFuncionario.Controls.Add(this.label1);
            this.gpb_FrmFuncionario.Location = new System.Drawing.Point(10, 65);
            this.gpb_FrmFuncionario.Name = "gpb_FrmFuncionario";
            this.gpb_FrmFuncionario.Size = new System.Drawing.Size(330, 237);
            this.gpb_FrmFuncionario.TabIndex = 16;
            this.gpb_FrmFuncionario.TabStop = false;
            this.gpb_FrmFuncionario.Text = "Ficha Funcionário";
            this.gpb_FrmFuncionario.Visible = false;
            // 
            // lbl_CodigoTag
            // 
            this.lbl_CodigoTag.AutoSize = true;
            this.lbl_CodigoTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CodigoTag.Location = new System.Drawing.Point(6, 213);
            this.lbl_CodigoTag.Name = "lbl_CodigoTag";
            this.lbl_CodigoTag.Size = new System.Drawing.Size(49, 14);
            this.lbl_CodigoTag.TabIndex = 18;
            this.lbl_CodigoTag.Text = "Código";
            this.lbl_CodigoTag.Visible = false;
            // 
            // txtCepFunc
            // 
            this.txtCepFunc.Location = new System.Drawing.Point(43, 172);
            this.txtCepFunc.Name = "txtCepFunc";
            this.txtCepFunc.PlaceholderText = "99.999-999";
            this.txtCepFunc.Size = new System.Drawing.Size(124, 23);
            this.txtCepFunc.TabIndex = 9;
            this.txtCepFunc.Leave += new System.EventHandler(this.txtCepFunc_Leave);
            // 
            // txtUfFunc
            // 
            this.txtUfFunc.Location = new System.Drawing.Point(241, 143);
            this.txtUfFunc.Name = "txtUfFunc";
            this.txtUfFunc.PlaceholderText = "Insira Estado";
            this.txtUfFunc.Size = new System.Drawing.Size(83, 23);
            this.txtUfFunc.TabIndex = 8;
            // 
            // pcb_Cancelar
            // 
            this.pcb_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Cancelar.Image")));
            this.pcb_Cancelar.Location = new System.Drawing.Point(296, 172);
            this.pcb_Cancelar.Name = "pcb_Cancelar";
            this.pcb_Cancelar.Size = new System.Drawing.Size(25, 30);
            this.pcb_Cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Cancelar.TabIndex = 6;
            this.pcb_Cancelar.TabStop = false;
            this.pcb_Cancelar.Click += new System.EventHandler(this.pcb_Cancelar_Click);
            // 
            // txtCidadeFunc
            // 
            this.txtCidadeFunc.Location = new System.Drawing.Point(64, 143);
            this.txtCidadeFunc.Name = "txtCidadeFunc";
            this.txtCidadeFunc.PlaceholderText = "Insira Cidade";
            this.txtCidadeFunc.Size = new System.Drawing.Size(141, 23);
            this.txtCidadeFunc.TabIndex = 7;
            // 
            // pcb_Confirmar
            // 
            this.pcb_Confirmar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Confirmar.Image")));
            this.pcb_Confirmar.Location = new System.Drawing.Point(265, 172);
            this.pcb_Confirmar.Name = "pcb_Confirmar";
            this.pcb_Confirmar.Size = new System.Drawing.Size(25, 30);
            this.pcb_Confirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Confirmar.TabIndex = 5;
            this.pcb_Confirmar.TabStop = false;
            this.pcb_Confirmar.Click += new System.EventHandler(this.pcb_Confirmar_Click);
            // 
            // txtBairroFunc
            // 
            this.txtBairroFunc.Location = new System.Drawing.Point(173, 112);
            this.txtBairroFunc.Name = "txtBairroFunc";
            this.txtBairroFunc.PlaceholderText = "Insira o Bairro";
            this.txtBairroFunc.Size = new System.Drawing.Size(151, 23);
            this.txtBairroFunc.TabIndex = 6;
            // 
            // txtNumFunc
            // 
            this.txtNumFunc.Location = new System.Drawing.Point(71, 111);
            this.txtNumFunc.Name = "txtNumFunc";
            this.txtNumFunc.PlaceholderText = "999";
            this.txtNumFunc.Size = new System.Drawing.Size(49, 23);
            this.txtNumFunc.TabIndex = 5;
            // 
            // txtEnderecoFunc
            // 
            this.txtEnderecoFunc.Location = new System.Drawing.Point(71, 77);
            this.txtEnderecoFunc.Name = "txtEnderecoFunc";
            this.txtEnderecoFunc.PlaceholderText = "Insira o Endereço";
            this.txtEnderecoFunc.Size = new System.Drawing.Size(253, 23);
            this.txtEnderecoFunc.TabIndex = 4;
            // 
            // txtTelFunc
            // 
            this.txtTelFunc.Location = new System.Drawing.Point(211, 45);
            this.txtTelFunc.Name = "txtTelFunc";
            this.txtTelFunc.PlaceholderText = "(99)99999-1234";
            this.txtTelFunc.Size = new System.Drawing.Size(113, 23);
            this.txtTelFunc.TabIndex = 3;
            this.txtTelFunc.Leave += new System.EventHandler(this.txtTelFunc_Leave);
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(55, 16);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.PlaceholderText = "Insira o Nome do Funcionario";
            this.txtNomeFunc.Size = new System.Drawing.Size(269, 23);
            this.txtNomeFunc.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "CEP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
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
            this.pcb_Voltar.Click += new System.EventHandler(this.pcb_Voltar_Click);
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
            this.pcb_Excluir.Click += new System.EventHandler(this.pcb_Excluir_Click_1);
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
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click_1);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click_1);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click_1);
            // 
            // voltarAoMenuToolStripMenuItem
            // 
            this.voltarAoMenuToolStripMenuItem.Name = "voltarAoMenuToolStripMenuItem";
            this.voltarAoMenuToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.voltarAoMenuToolStripMenuItem.Text = "Voltar ao Menu";
            this.voltarAoMenuToolStripMenuItem.Click += new System.EventHandler(this.voltarAoMenuToolStripMenuItem_Click);
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
            this.pcb_Pesquisar.Click += new System.EventHandler(this.pcb_Pesquisar_Click_1);
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
            // frm_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_FrmFuncionario);
            this.Controls.Add(this.pcb_Voltar);
            this.Controls.Add(this.pcb_Excluir);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pcb_Pesquisar);
            this.Controls.Add(this.pcb_Inserir);
            this.Controls.Add(this.pcb_Editar);
            this.Name = "frm_Funcionario";
            this.Text = "ControlFood - Automação de Bar e Restaurante - Módulo Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Exclusao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Edicao)).EndInit();
            this.gpb_FrmFuncionario.ResumeLayout(false);
            this.gpb_FrmFuncionario.PerformLayout();
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

        public DataGridView dgv_Funcionario;
        private GroupBox groupBox1;
        private TextBox txtCpfFunc;
        private PictureBox pcb_Exclusao;
        private PictureBox pcb_Edicao;
        private Label lbl_codFunc;
        private GroupBox gpb_FrmFuncionario;
        private Label lbl_CodigoTag;
        private TextBox txtCepFunc;
        private TextBox txtUfFunc;
        private PictureBox pcb_Cancelar;
        private TextBox txtCidadeFunc;
        private PictureBox pcb_Confirmar;
        private TextBox txtBairroFunc;
        private TextBox txtNumFunc;
        private TextBox txtEnderecoFunc;
        private TextBox txtTelFunc;
        private TextBox txtNomeFunc;
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
    }
}