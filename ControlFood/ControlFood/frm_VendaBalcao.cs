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
            btnAbrirVenda.Focus();      
        }

        class_Balcao newVenda = new class_Balcao();
        class_Calculos calc = new class_Calculos();
        private void button1_Click(object sender, EventArgs e)
        {
            newVenda.setDiaVenda(DateTime.Now);
            newVenda.novaVenda();
            txtCodProduto.Focus();
            lblExibeSubTotal.Text = lblExibeValorTotalProd.Text;
            dgvItensVendidos.DataSource = newVenda.mostraVendaAberta();
            int Nvenda = dgvItensVendidos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItensVendidos.Rows[Nvenda];
            string Venda = Convert.ToString(selectedRow.Cells["Venda"].Value);
            lblExibeNumeroVenda.Text=Venda;


        }         

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
             
            newVenda.setNumVendaBalcao(Int32.Parse(lblExibeNumeroVenda.Text));
            newVenda.setDiaVenda(DateTime.Now);
            newVenda.setCodProdBalcao(txtCodProduto.Text);
            newVenda.setUndProdBalcao(lblExibeUndProd.Text);
            newVenda.setQtdProdBalcao(Int32.Parse(txtQtdProd.Text));
            newVenda.setVlUnitarioProdBalcao(Convert.ToDouble(lblExibeValorUnt.Text));
            newVenda.setVlTotalProdBalcao(Convert.ToDouble(lblExibeValorTotalProd.Text));
            newVenda.setVlSubTotalBalcao(Convert.ToDouble(lblExibeSubTotal.Text));

            newVenda.InserirItem();            

            newVenda.mostraItensComprados();

            dgvItensVendidos.DataSource = newVenda.mostraItensComprados();
            int Nvenda = dgvItensVendidos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItensVendidos.Rows[Nvenda];

            //Mostrar Valor Total
            double subtotal = Convert.ToDouble(lblExibeSubTotal.Text);            
            calc.setValorSubTotal(subtotal);            
            double total = calc.fecharConta();            
            lblExibeTotalAPagar.Text = Convert.ToString(total);
        }
               
        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtCodProduto.Text != "")
            {
                string codigo = txtCodProduto.Text;
                newVenda.setCodProdBalcao(codigo);
                newVenda.buscaItemCodigo();

                dgvItensVendidos.DataSource = newVenda.buscaItemCodigo();
                int Ncodigo = dgvItensVendidos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvItensVendidos.Rows[Ncodigo];
            }
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            int codigoProd = dgvItensVendidos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItensVendidos.Rows[codigoProd];
            string codigoProduto = Convert.ToString(selectedRow.Cells["codBarProd"].Value);
            string descricaoProd = Convert.ToString(selectedRow.Cells["descProd"].Value);
            string unidadeProd = Convert.ToString(selectedRow.Cells["undProd"].Value);
            string valorProd = Convert.ToString(selectedRow.Cells["vlVendProd"].Value);
            
            txtDescProd.Text = descricaoProd;
            lblExibeUndProd.Text = unidadeProd;
            lblExibeValorUnt.Text= valorProd;            
        }

        private void txtQtdProd_Leave(object sender, EventArgs e)
        {
            double guardaSubtotal;
            double novoSubtotal;

            calc.setQtdProd(double.Parse(txtQtdProd.Text));
            calc.setVlUniProd(double.Parse(lblExibeValorUnt.Text));
            double totalItem = calc.calculaTotalProduto();
            lblExibeValorTotalProd.Text = Convert.ToString(totalItem);

            if (lblExibeSubTotal.Text == "0")
            {
                lblExibeSubTotal.Text = lblExibeValorTotalProd.Text;              
            }
            else
            {
                guardaSubtotal = Convert.ToDouble(lblExibeSubTotal.Text);
                novoSubtotal = Convert.ToDouble(lblExibeValorTotalProd.Text);
                double subTotal = guardaSubtotal + novoSubtotal;
                lblExibeSubTotal.Text = (Convert.ToString(subTotal));             
            }
                        
        }

        private void btnFecharConta_Click(object sender, EventArgs e)
        {
            double subtotal;
            double descontoPerc;
            double descontoVal;
            double totalPagar;

            subtotal = Convert.ToDouble(lblExibeTotalAPagar.Text);
            
            if (txtDescPorcentagem.Text == "")
            {
                txtDescPorcentagem.Text = "0";
            }

            if (txtDecontoValor.Text == "")
            {
                txtDecontoValor.Text = "0";
            }

            descontoPerc = Convert.ToDouble(txtDescPorcentagem.Text);            
            descontoVal = Convert.ToDouble(txtDecontoValor.Text);
           

            calc.setTotalCompra(subtotal);
            calc.setDescontoPorcentagem(descontoPerc);
            calc.setDescontoValor(descontoVal);            
            totalPagar=calc.fecharConta();
            lblExibeTotalAPagar.Text = Convert.ToString(totalPagar);
        }

        private void btnReceberConta_Click(object sender, EventArgs e)
        {
            double totalPagar = Convert.ToDouble(lblExibeTotalAPagar.Text);
            double valorPago = Convert.ToDouble(txtValorPago.Text);
            calc.setTotalCompra(totalPagar);
            calc.setValorPago(valorPago);
            double troco = calc.receberConta();
            lblExibeTroco.Text = Convert.ToString(troco);
            
        }
    }
}
