namespace ControlFood
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void sairDoAplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Confirmação de Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frm_Cliente newFrm_Cliente = new frm_Cliente();
            newFrm_Cliente.ShowDialog();


        }
    }
}
