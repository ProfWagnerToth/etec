namespace ControlFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                frm_Menu menu = new frm_Menu();
                menu.Show();
                this.Hide();
            }
        }


    }
}