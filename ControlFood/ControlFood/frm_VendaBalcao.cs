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
    public partial class frm_VendaBalcao : Form
    {
        public frm_VendaBalcao()
        {
            InitializeComponent();
        }
               
        private void frm_VendaBalcao_Load(object sender, EventArgs e)
        {
            string Date = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_ExibeDiaVenda.Text = Date;
        }

        class_Balcao newVenda = new class_Balcao();
        private void button1_Click(object sender, EventArgs e)
        {
            newVenda.setDiaVenda(DateTime.Now);
            newVenda.novaVenda();
            txtCodProduto.Focus();
            dgvItensVendidos.DataSource = newVenda.mostraVendaAberta();
            int Nvenda = dgvItensVendidos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItensVendidos.Rows[Nvenda];
            string Venda = Convert.ToString(selectedRow.Cells["Venda"].Value);
            lblExibeNumeroVenda.Text=Venda;


        }

        private void dgvItensVendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblExibeNumeroVenda_Click(object sender, EventArgs e)
        {
           
        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            newVenda.setNumVendaBalcao(Int32.Parse(lblExibeNumeroVenda.Text));
            newVenda.setDiaVenda(DateTime.Now);
            newVenda.setCodProdBalcao(txtCodProduto.Text);
            newVenda.setUndProdBalcao(lblExibeUndProd.Text);
            newVenda.setQtdProdBalcao(Int32.Parse(txtQtdProd.Text));
            newVenda.setVlUnitarioProdBalcao(Convert.ToDouble(lblExibeValorUnt.Text));
            newVenda.InserirItem();
            newVenda.mostraItensComprados();

            dgvItensVendidos.DataSource = newVenda.mostraItensComprados();
            int Nvenda = dgvItensVendidos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItensVendidos.Rows[Nvenda];
        }
    }
}
