using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlFood
{
    internal class class_Calculos
    {
        private double valorUnitarioProduto;
        private double quantidadeProduto;
        private double valorTotalProduto;
        private double valorSubTotal;
        private double descontoPorcentagem;
        private double descontoValor;
        private double valorTotalCompra;
        private double valorPago;
        private double valorTroco;

        public void setVlUniProd(double valorUnitario)
        {
            this.valorUnitarioProduto = valorUnitario;
        }

        public double getVlUniProd()
        {
            return this.valorUnitarioProduto;
        }

        public void setQtdProd(double qtdProduto)
        {
            this.quantidadeProduto = qtdProduto;
        }

        public double getQtdProd()
        {
            return this.quantidadeProduto;
        }

        public void setValorTotalProduto(double VlTotalProd)
        {
            this.valorTotalProduto = VlTotalProd;
        }

        public double getValorTotalProduto()
        {
            return this.valorTotalProduto;
        }

        public void setValorSubTotal(double subtotal)
        {
            this.valorSubTotal = subtotal;
        }

        public double getValorSubTotal()
        {
            return this.valorSubTotal;
        }

        public void setDescontoPorcentagem(double DescPorc)
        {
            this.descontoPorcentagem = DescPorc;
        }

        public double getDescontoPorcentagem()
        {
            return this.descontoPorcentagem;
        }

        public void setDescontoValor(double DescVal)
        {
            this.descontoValor = DescVal;
        }

        public double getDescontoValor()
        {
            return this.descontoValor;
        }

        public void setValorPago (double VPago)
        {
            this.valorPago = VPago;
        }

        public double getValorPago()
        {
            return this.valorPago;
        }

        public void setTroco(double VTroco)
        {
            this.valorTroco = VTroco;
        }

        public double getTroco()
        {
            return this.valorTroco;
        }

        public void setTotalCompra(double TCompra)
        {
            this.valorTotalCompra = TCompra;
        }

        public double getTotalCompra()
        {
            return this.valorTotalCompra;
        }


        public double calculaTotalProduto()
        {
            double valorUnt = getVlUniProd();
            double quantidade = getQtdProd();
            double total = valorUnt * quantidade;
            return total;
        }        

        public double fecharConta()
        {
            double subtotal = getValorSubTotal();
            double descontoPorecentagem = getDescontoPorcentagem()/100;
            double descontoValor = getDescontoValor();
            
            if (getDescontoPorcentagem() > 0)
            {
                double total = subtotal - (subtotal * descontoPorecentagem);
                return total;
            }
            else if (getDescontoValor() >0)
            {
                double total1 = subtotal - descontoValor; 
                return total1;
            } 
            double total2 = subtotal;
            return total2;
        }

        public double receberConta()
        {
            double valorPago = getValorPago();
            double troco = valorPago - getTotalCompra();
            return troco;
        }
    }
}
