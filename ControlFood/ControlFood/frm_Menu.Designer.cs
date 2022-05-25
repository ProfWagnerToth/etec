namespace ControlFood
{
    partial class frm_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.móduloBalcãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.móduloMesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.móduloDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoAplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrativoToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.sairDoAplicativoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.módulosToolStripMenuItem});
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.administrativoToolStripMenuItem.Text = "Administrativo";
            // 
            // módulosToolStripMenuItem
            // 
            this.módulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.módulosToolStripMenuItem.Name = "módulosToolStripMenuItem";
            this.módulosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.módulosToolStripMenuItem.Text = "Módulos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.móduloBalcãoToolStripMenuItem,
            this.móduloMesaToolStripMenuItem,
            this.móduloDeliveryToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // móduloBalcãoToolStripMenuItem
            // 
            this.móduloBalcãoToolStripMenuItem.Name = "móduloBalcãoToolStripMenuItem";
            this.móduloBalcãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.móduloBalcãoToolStripMenuItem.Text = "Módulo Balcão";
            // 
            // móduloMesaToolStripMenuItem
            // 
            this.móduloMesaToolStripMenuItem.Name = "móduloMesaToolStripMenuItem";
            this.móduloMesaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.móduloMesaToolStripMenuItem.Text = "Módulo Mesa";
            // 
            // móduloDeliveryToolStripMenuItem
            // 
            this.móduloDeliveryToolStripMenuItem.Name = "móduloDeliveryToolStripMenuItem";
            this.móduloDeliveryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.móduloDeliveryToolStripMenuItem.Text = "Módulo Delivery";
            // 
            // sairDoAplicativoToolStripMenuItem
            // 
            this.sairDoAplicativoToolStripMenuItem.Name = "sairDoAplicativoToolStripMenuItem";
            this.sairDoAplicativoToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.sairDoAplicativoToolStripMenuItem.Text = "Sair do Aplicativo";
            this.sairDoAplicativoToolStripMenuItem.Click += new System.EventHandler(this.sairDoAplicativoToolStripMenuItem_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlFood - Automação de Bar e Restaurante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem administrativoToolStripMenuItem;
        private ToolStripMenuItem módulosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem móduloBalcãoToolStripMenuItem;
        private ToolStripMenuItem móduloMesaToolStripMenuItem;
        private ToolStripMenuItem móduloDeliveryToolStripMenuItem;
        private ToolStripMenuItem sairDoAplicativoToolStripMenuItem;
    }
}