namespace ControlFood
{
    partial class frm_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Produtos));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodBarProd = new System.Windows.Forms.TextBox();
            this.pcb_Exclusao = new System.Windows.Forms.PictureBox();
            this.pcb_Edicao = new System.Windows.Forms.PictureBox();
            this.lbl_codProd = new System.Windows.Forms.Label();
            this.gpb_FrmProduto = new System.Windows.Forms.GroupBox();
            this.lbl_CodigoTag = new System.Windows.Forms.Label();
            this.pcb_Cancelar = new System.Windows.Forms.PictureBox();
            this.pcb_Confirmar = new System.Windows.Forms.PictureBox();
            this.txtVlVendProd = new System.Windows.Forms.TextBox();
            this.txtVlCompProd = new System.Windows.Forms.TextBox();
            this.txtUndProd = new System.Windows.Forms.TextBox();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Exclusao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Edicao)).BeginInit();
            this.gpb_FrmProduto.SuspendLayout();
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
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 32);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.Size = new System.Drawing.Size(430, 215);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Location = new System.Drawing.Point(346, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 269);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualização Banco de Dados";
            // 
            // txtCodBarProd
            // 
            this.txtCodBarProd.Location = new System.Drawing.Point(79, 45);
            this.txtCodBarProd.Name = "txtCodBarProd";
            this.txtCodBarProd.PlaceholderText = "Insira o Código de Barras do Produto";
            this.txtCodBarProd.Size = new System.Drawing.Size(242, 23);
            this.txtCodBarProd.TabIndex = 2;
            this.txtCodBarProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pcb_Exclusao
            // 
            this.pcb_Exclusao.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Exclusao.Image")));
            this.pcb_Exclusao.Location = new System.Drawing.Point(284, 104);
            this.pcb_Exclusao.Name = "pcb_Exclusao";
            this.pcb_Exclusao.Size = new System.Drawing.Size(25, 30);
            this.pcb_Exclusao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Exclusao.TabIndex = 21;
            this.pcb_Exclusao.TabStop = false;
            this.pcb_Exclusao.Visible = false;
            this.pcb_Exclusao.Click += new System.EventHandler(this.pcb_Exclusao_Click);
            // 
            // pcb_Edicao
            // 
            this.pcb_Edicao.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Edicao.Image")));
            this.pcb_Edicao.Location = new System.Drawing.Point(253, 104);
            this.pcb_Edicao.Name = "pcb_Edicao";
            this.pcb_Edicao.Size = new System.Drawing.Size(25, 30);
            this.pcb_Edicao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Edicao.TabIndex = 20;
            this.pcb_Edicao.TabStop = false;
            this.pcb_Edicao.Visible = false;
            this.pcb_Edicao.Click += new System.EventHandler(this.pcb_Edicao_Click);
            // 
            // lbl_codProd
            // 
            this.lbl_codProd.AutoSize = true;
            this.lbl_codProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_codProd.ForeColor = System.Drawing.Color.Red;
            this.lbl_codProd.Location = new System.Drawing.Point(83, 193);
            this.lbl_codProd.Name = "lbl_codProd";
            this.lbl_codProd.Size = new System.Drawing.Size(121, 22);
            this.lbl_codProd.TabIndex = 19;
            this.lbl_codProd.Text = "Sem Código";
            this.lbl_codProd.Visible = false;
            // 
            // gpb_FrmProduto
            // 
            this.gpb_FrmProduto.Controls.Add(this.txtCodBarProd);
            this.gpb_FrmProduto.Controls.Add(this.pcb_Exclusao);
            this.gpb_FrmProduto.Controls.Add(this.pcb_Edicao);
            this.gpb_FrmProduto.Controls.Add(this.lbl_codProd);
            this.gpb_FrmProduto.Controls.Add(this.lbl_CodigoTag);
            this.gpb_FrmProduto.Controls.Add(this.pcb_Cancelar);
            this.gpb_FrmProduto.Controls.Add(this.pcb_Confirmar);
            this.gpb_FrmProduto.Controls.Add(this.txtVlVendProd);
            this.gpb_FrmProduto.Controls.Add(this.txtVlCompProd);
            this.gpb_FrmProduto.Controls.Add(this.txtUndProd);
            this.gpb_FrmProduto.Controls.Add(this.txtDescProd);
            this.gpb_FrmProduto.Controls.Add(this.label6);
            this.gpb_FrmProduto.Controls.Add(this.label5);
            this.gpb_FrmProduto.Controls.Add(this.label4);
            this.gpb_FrmProduto.Controls.Add(this.label2);
            this.gpb_FrmProduto.Controls.Add(this.label1);
            this.gpb_FrmProduto.Location = new System.Drawing.Point(10, 66);
            this.gpb_FrmProduto.Name = "gpb_FrmProduto";
            this.gpb_FrmProduto.Size = new System.Drawing.Size(330, 237);
            this.gpb_FrmProduto.TabIndex = 16;
            this.gpb_FrmProduto.TabStop = false;
            this.gpb_FrmProduto.Text = "Ficha Produto";
            this.gpb_FrmProduto.Visible = false;
            // 
            // lbl_CodigoTag
            // 
            this.lbl_CodigoTag.AutoSize = true;
            this.lbl_CodigoTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CodigoTag.Location = new System.Drawing.Point(31, 200);
            this.lbl_CodigoTag.Name = "lbl_CodigoTag";
            this.lbl_CodigoTag.Size = new System.Drawing.Size(49, 14);
            this.lbl_CodigoTag.TabIndex = 18;
            this.lbl_CodigoTag.Text = "Código";
            this.lbl_CodigoTag.Visible = false;
            // 
            // pcb_Cancelar
            // 
            this.pcb_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Cancelar.Image")));
            this.pcb_Cancelar.Location = new System.Drawing.Point(284, 140);
            this.pcb_Cancelar.Name = "pcb_Cancelar";
            this.pcb_Cancelar.Size = new System.Drawing.Size(25, 30);
            this.pcb_Cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Cancelar.TabIndex = 6;
            this.pcb_Cancelar.TabStop = false;
            this.pcb_Cancelar.Click += new System.EventHandler(this.pcb_Cancelar_Click);
            // 
            // pcb_Confirmar
            // 
            this.pcb_Confirmar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Confirmar.Image")));
            this.pcb_Confirmar.Location = new System.Drawing.Point(253, 140);
            this.pcb_Confirmar.Name = "pcb_Confirmar";
            this.pcb_Confirmar.Size = new System.Drawing.Size(25, 30);
            this.pcb_Confirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Confirmar.TabIndex = 5;
            this.pcb_Confirmar.TabStop = false;
            this.pcb_Confirmar.Click += new System.EventHandler(this.pcb_Confirmar_Click);
            // 
            // txtVlVendProd
            // 
            this.txtVlVendProd.Location = new System.Drawing.Point(95, 143);
            this.txtVlVendProd.Name = "txtVlVendProd";
            this.txtVlVendProd.Size = new System.Drawing.Size(126, 23);
            this.txtVlVendProd.TabIndex = 6;
            // 
            // txtVlCompProd
            // 
            this.txtVlCompProd.Location = new System.Drawing.Point(94, 111);
            this.txtVlCompProd.Name = "txtVlCompProd";
            this.txtVlCompProd.Size = new System.Drawing.Size(127, 23);
            this.txtVlCompProd.TabIndex = 5;
            // 
            // txtUndProd
            // 
            this.txtUndProd.Location = new System.Drawing.Point(71, 77);
            this.txtUndProd.Name = "txtUndProd";
            this.txtUndProd.PlaceholderText = "unidade de medida";
            this.txtUndProd.Size = new System.Drawing.Size(108, 23);
            this.txtUndProd.TabIndex = 4;
            // 
            // txtDescProd
            // 
            this.txtDescProd.Location = new System.Drawing.Point(73, 15);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.PlaceholderText = "Insira a Descrição";
            this.txtDescProd.Size = new System.Drawing.Size(251, 23);
            this.txtDescProd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor Venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "unidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod.Barras:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // pcb_Voltar
            // 
            this.pcb_Voltar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Voltar.Image")));
            this.pcb_Voltar.Location = new System.Drawing.Point(306, 27);
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
            this.pcb_Excluir.Location = new System.Drawing.Point(105, 27);
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
            this.voltarAoMenuToolStripMenuItem.Click += new System.EventHandler(this.voltarAoMenuToolStripMenuItem_Click);
            // 
            // pcb_Pesquisar
            // 
            this.pcb_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Pesquisar.Image")));
            this.pcb_Pesquisar.Location = new System.Drawing.Point(74, 27);
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
            this.pcb_Inserir.Location = new System.Drawing.Point(12, 27);
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
            this.pcb_Editar.Location = new System.Drawing.Point(43, 27);
            this.pcb_Editar.Name = "pcb_Editar";
            this.pcb_Editar.Size = new System.Drawing.Size(25, 30);
            this.pcb_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Editar.TabIndex = 12;
            this.pcb_Editar.TabStop = false;
            this.pcb_Editar.Click += new System.EventHandler(this.pcb_Editar_Click);
            // 
            // frm_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_FrmProduto);
            this.Controls.Add(this.pcb_Voltar);
            this.Controls.Add(this.pcb_Excluir);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pcb_Pesquisar);
            this.Controls.Add(this.pcb_Inserir);
            this.Controls.Add(this.pcb_Editar);
            this.Name = "frm_Produtos";
            this.Text = "ControlFood - Automação de Bar e Restaurante - Módulo Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Exclusao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Edicao)).EndInit();
            this.gpb_FrmProduto.ResumeLayout(false);
            this.gpb_FrmProduto.PerformLayout();
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

        public DataGridView dgvProdutos;
        private GroupBox groupBox1;
        private TextBox txtCodBarProd;
        private PictureBox pcb_Exclusao;
        private PictureBox pcb_Edicao;
        private Label lbl_codProd;
        private GroupBox gpb_FrmProduto;
        private Label lbl_CodigoTag;
        private PictureBox pcb_Cancelar;
        private PictureBox pcb_Confirmar;
        private TextBox txtVlVendProd;
        private TextBox txtVlCompProd;
        private TextBox txtUndProd;
        private TextBox txtDescProd;
        private Label label6;
        private Label label5;
        private Label label4;
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