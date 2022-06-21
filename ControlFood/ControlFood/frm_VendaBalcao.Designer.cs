namespace ControlFood
{
    partial class frm_VendaBalcao
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
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.lblExibeUndProd = new System.Windows.Forms.Label();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.lblExibeValorUnt = new System.Windows.Forms.Label();
            this.lblExibeValorTotalProd = new System.Windows.Forms.Label();
            this.txtQtdProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItensVendidos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblExibeSubTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescPorcentagem = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDecontoValor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblExibeTroco = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblExibeTotalAPagar = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnInserirItem = new System.Windows.Forms.Button();
            this.btnFecharConta = new System.Windows.Forms.Button();
            this.btnReceberConta = new System.Windows.Forms.Button();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnAbrirVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.lblExibeNumeroVenda = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_ExibeDiaVenda = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVendidos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(10, 37);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(77, 23);
            this.txtCodProduto.TabIndex = 4;
            this.txtCodProduto.TextChanged += new System.EventHandler(this.txtCodProduto_TextChanged);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // lblExibeUndProd
            // 
            this.lblExibeUndProd.AutoSize = true;
            this.lblExibeUndProd.Location = new System.Drawing.Point(104, 40);
            this.lblExibeUndProd.Name = "lblExibeUndProd";
            this.lblExibeUndProd.Size = new System.Drawing.Size(28, 15);
            this.lblExibeUndProd.TabIndex = 1;
            this.lblExibeUndProd.Text = "und";
            // 
            // txtDescProd
            // 
            this.txtDescProd.Location = new System.Drawing.Point(247, 37);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(397, 23);
            this.txtDescProd.TabIndex = 6;
            // 
            // lblExibeValorUnt
            // 
            this.lblExibeValorUnt.AutoSize = true;
            this.lblExibeValorUnt.Location = new System.Drawing.Point(690, 40);
            this.lblExibeValorUnt.Name = "lblExibeValorUnt";
            this.lblExibeValorUnt.Size = new System.Drawing.Size(28, 15);
            this.lblExibeValorUnt.TabIndex = 3;
            this.lblExibeValorUnt.Text = "0,00";
            // 
            // lblExibeValorTotalProd
            // 
            this.lblExibeValorTotalProd.AutoSize = true;
            this.lblExibeValorTotalProd.Location = new System.Drawing.Point(800, 40);
            this.lblExibeValorTotalProd.Name = "lblExibeValorTotalProd";
            this.lblExibeValorTotalProd.Size = new System.Drawing.Size(28, 15);
            this.lblExibeValorTotalProd.TabIndex = 4;
            this.lblExibeValorTotalProd.Text = "0,00";
            // 
            // txtQtdProd
            // 
            this.txtQtdProd.Location = new System.Drawing.Point(191, 37);
            this.txtQtdProd.Name = "txtQtdProd";
            this.txtQtdProd.Size = new System.Drawing.Size(40, 23);
            this.txtQtdProd.TabIndex = 5;
            this.txtQtdProd.Leave += new System.EventHandler(this.txtQtdProd_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Unidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Descrição";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Valor Unitário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(777, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Valor Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCodProduto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblExibeUndProd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDescProd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblExibeValorUnt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblExibeValorTotalProd);
            this.groupBox1.Controls.Add(this.txtQtdProd);
            this.groupBox1.Location = new System.Drawing.Point(37, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 67);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserção de Itens";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvItensVendidos);
            this.groupBox2.Location = new System.Drawing.Point(25, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 306);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens do Pedido";
            // 
            // dgvItensVendidos
            // 
            this.dgvItensVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVendidos.Location = new System.Drawing.Point(12, 19);
            this.dgvItensVendidos.Name = "dgvItensVendidos";
            this.dgvItensVendidos.RowTemplate.Height = 25;
            this.dgvItensVendidos.Size = new System.Drawing.Size(529, 281);
            this.dgvItensVendidos.TabIndex = 0;
            
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Sub Total";
            // 
            // lblExibeSubTotal
            // 
            this.lblExibeSubTotal.AutoSize = true;
            this.lblExibeSubTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExibeSubTotal.Location = new System.Drawing.Point(192, 28);
            this.lblExibeSubTotal.Name = "lblExibeSubTotal";
            this.lblExibeSubTotal.Size = new System.Drawing.Size(0, 25);
            this.lblExibeSubTotal.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Desconto %";
            // 
            // txtDescPorcentagem
            // 
            this.txtDescPorcentagem.Location = new System.Drawing.Point(6, 77);
            this.txtDescPorcentagem.Name = "txtDescPorcentagem";
            this.txtDescPorcentagem.Size = new System.Drawing.Size(69, 23);
            this.txtDescPorcentagem.TabIndex = 7;
            this.txtDescPorcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Desconto Valor R$";
            // 
            // txtDecontoValor
            // 
            this.txtDecontoValor.Location = new System.Drawing.Point(185, 77);
            this.txtDecontoValor.Name = "txtDecontoValor";
            this.txtDecontoValor.Size = new System.Drawing.Size(102, 23);
            this.txtDecontoValor.TabIndex = 8;
            this.txtDecontoValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblExibeTroco);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtValorPago);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lblExibeTotalAPagar);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDecontoValor);
            this.groupBox3.Controls.Add(this.lblExibeSubTotal);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtDescPorcentagem);
            this.groupBox3.Location = new System.Drawing.Point(588, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 229);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conta";
            // 
            // lblExibeTroco
            // 
            this.lblExibeTroco.AutoSize = true;
            this.lblExibeTroco.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExibeTroco.Location = new System.Drawing.Point(265, 185);
            this.lblExibeTroco.Name = "lblExibeTroco";
            this.lblExibeTroco.Size = new System.Drawing.Size(0, 17);
            this.lblExibeTroco.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(27, 185);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Troco";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(185, 146);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(102, 23);
            this.txtValorPago.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(21, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 17);
            this.label16.TabIndex = 22;
            this.label16.Text = "Valor Pago";
            // 
            // lblExibeTotalAPagar
            // 
            this.lblExibeTotalAPagar.AutoSize = true;
            this.lblExibeTotalAPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExibeTotalAPagar.Location = new System.Drawing.Point(193, 118);
            this.lblExibeTotalAPagar.Name = "lblExibeTotalAPagar";
            this.lblExibeTotalAPagar.Size = new System.Drawing.Size(0, 21);
            this.lblExibeTotalAPagar.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(6, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "TOTAL A PAGAR";
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(460, 12);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(102, 23);
            this.btnNovaVenda.TabIndex = 1;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.Location = new System.Drawing.Point(609, 124);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(102, 23);
            this.btnInserirItem.TabIndex = 7;
            this.btnInserirItem.Text = "Inserir Item";
            this.btnInserirItem.UseVisualStyleBackColor = true;
            this.btnInserirItem.Click += new System.EventHandler(this.btnInserirItem_Click);
            // 
            // btnFecharConta
            // 
            this.btnFecharConta.Location = new System.Drawing.Point(609, 153);
            this.btnFecharConta.Name = "btnFecharConta";
            this.btnFecharConta.Size = new System.Drawing.Size(102, 23);
            this.btnFecharConta.TabIndex = 9;
            this.btnFecharConta.Text = "Fechar Conta";
            this.btnFecharConta.UseVisualStyleBackColor = true;
            this.btnFecharConta.Click += new System.EventHandler(this.btnFecharConta_Click);
            // 
            // btnReceberConta
            // 
            this.btnReceberConta.Location = new System.Drawing.Point(743, 153);
            this.btnReceberConta.Name = "btnReceberConta";
            this.btnReceberConta.Size = new System.Drawing.Size(102, 23);
            this.btnReceberConta.TabIndex = 11;
            this.btnReceberConta.Text = "Receber Conta";
            this.btnReceberConta.UseVisualStyleBackColor = true;
            this.btnReceberConta.Click += new System.EventHandler(this.btnReceberConta_Click);
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.Location = new System.Drawing.Point(743, 124);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(102, 23);
            this.btnCancelarItem.TabIndex = 12;
            this.btnCancelarItem.Text = "Cancelar Item";
            this.btnCancelarItem.UseVisualStyleBackColor = true;
            // 
            // btnAbrirVenda
            // 
            this.btnAbrirVenda.Location = new System.Drawing.Point(568, 13);
            this.btnAbrirVenda.Name = "btnAbrirVenda";
            this.btnAbrirVenda.Size = new System.Drawing.Size(102, 23);
            this.btnAbrirVenda.TabIndex = 2;
            this.btnAbrirVenda.Text = "Abrir Venda";
            this.btnAbrirVenda.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(676, 13);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(102, 23);
            this.btnCancelarVenda.TabIndex = 3;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(37, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 21);
            this.label19.TabIndex = 26;
            this.label19.Text = "Numero da Venda";
            // 
            // lblExibeNumeroVenda
            // 
            this.lblExibeNumeroVenda.AutoSize = true;
            this.lblExibeNumeroVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExibeNumeroVenda.Location = new System.Drawing.Point(179, 11);
            this.lblExibeNumeroVenda.Name = "lblExibeNumeroVenda";
            this.lblExibeNumeroVenda.Size = new System.Drawing.Size(46, 21);
            this.lblExibeNumeroVenda.TabIndex = 28;
            this.lblExibeNumeroVenda.Text = "9999";
            
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(784, 13);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 23);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(255, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 21);
            this.label21.TabIndex = 29;
            this.label21.Text = "Hoje é dia:";
            // 
            // lbl_ExibeDiaVenda
            // 
            this.lbl_ExibeDiaVenda.AutoSize = true;
            this.lbl_ExibeDiaVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ExibeDiaVenda.Location = new System.Drawing.Point(343, 12);
            this.lbl_ExibeDiaVenda.Name = "lbl_ExibeDiaVenda";
            this.lbl_ExibeDiaVenda.Size = new System.Drawing.Size(94, 21);
            this.lbl_ExibeDiaVenda.TabIndex = 30;
            this.lbl_ExibeDiaVenda.Text = "31/12/2022";
            // 
            // frm_VendaBalcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lbl_ExibeDiaVenda);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblExibeNumeroVenda);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnAbrirVenda);
            this.Controls.Add(this.btnCancelarItem);
            this.Controls.Add(this.btnReceberConta);
            this.Controls.Add(this.btnFecharConta);
            this.Controls.Add(this.btnInserirItem);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_VendaBalcao";
            this.Text = "Vendas Balcao";
            this.Load += new System.EventHandler(this.frm_VendaBalcao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVendidos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCodProduto;
        private Label lblExibeUndProd;
        private TextBox txtDescProd;
        private Label lblExibeValorUnt;
        private Label lblExibeValorTotalProd;
        private TextBox txtQtdProd;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvItensVendidos;
        private Label label10;
        private Label lblExibeSubTotal;
        private Label label12;
        private TextBox txtDescPorcentagem;
        private Label label13;
        private TextBox txtDecontoValor;
        private GroupBox groupBox3;
        private Label lblExibeTroco;
        private Label label17;
        private TextBox txtValorPago;
        private Label label16;
        private Label lblExibeTotalAPagar;
        private Label label14;
        private Button btnNovaVenda;
        private Button btnInserirItem;
        private Button btnFecharConta;
        private Button btnReceberConta;
        private Button btnCancelarItem;
        private Button btnAbrirVenda;
        private Button btnCancelarVenda;
        private Label label19;
        private Label lblExibeNumeroVenda;
        private Button btnSair;
        private Label label21;
        private Label lbl_ExibeDiaVenda;
    }
}