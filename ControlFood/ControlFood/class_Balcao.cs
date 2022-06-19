using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace ControlFood
{
    internal class class_Balcao : Conexao
    {
        //Delcaração Variaveis 

        private int numVendaBalcao;
        private DateTime diaVenda;
        private string codigoProdBalcao;
        private string unidadeProdBalcao;
        private double qtdProdBalcao;
        private string descProdBalcao;
        private double vlUnitarioProdBalcao;
        private double vlTotalProdBalcao;
        private double descPorcentagem;
        private double descValor;
        private double totalAPagar;
        private double vlPagoBalcao;
        private double trocoBalcao;
                
        //Métodos de Retornos SET e GET
        public void setNumVendaBalcao(int numVendaBalcao)
        {
            this.numVendaBalcao = numVendaBalcao;
        }

        public int getNumVendaBalcao()
        {
            return numVendaBalcao;
        }

        public void setDiaVenda(DateTime date)
        {
           this.diaVenda = date;
        }
        
        public DateTime GetDate()
        {
            return diaVenda;
        }

        public void setCodProdBalcao(string codProdBalcao)
        {
            this.codigoProdBalcao = codProdBalcao;
        }

        public string getCodProdBalcao()
        {
            return codigoProdBalcao;
        }
        public void setUndProdBalcao(string undProdBalcao)
        {
            this.unidadeProdBalcao = undProdBalcao;
        }

        public string getUndProdBalcao()
        {
            return unidadeProdBalcao;
        }
        public void setQtdProdBalcao(double qtdProdBalcao)
        {
            this.qtdProdBalcao = qtdProdBalcao;
        }

        public double getQtdProdBalcao()
        {
            return qtdProdBalcao;
        }

        public void setDescProdBalcao(string descricaoProd)
        {
            this.descProdBalcao = descricaoProd;
        }

        public string getDescProdBalcao()
        {
            return descProdBalcao;
        }
        public void setVlUnitarioProdBalcao(double VlUntProd)
        {
            this.vlUnitarioProdBalcao = VlUntProd;
        }

        public double getVlUnitarioBalcao()
        {
            return vlUnitarioProdBalcao;
        }
        public void setVlTotalProdBalcao(double vlProd)
        {
            this.vlTotalProdBalcao = vlProd;
        }

        public double getVlTotalProdBalcao()
        {
            return vlTotalProdBalcao;
        }
        public void setDescPerc(double descP)
        {
            this.descPorcentagem = descP;
        }

        public double getDescPorc()
        {
            return descPorcentagem;
        }
        public void setDescValor(double DescVl)
        {
            this.descValor = DescVl;
        }

        public double getDescValor()
        {
            return descValor;
        }
        public void setTotalAPagarBalcao(double pagar)
        {
            this.totalAPagar = pagar;
        }

        public double getTotalAPagarBalcao()
        {
            return totalAPagar;
        }
        public void setVlPagoBalcao(double ValorPg)
        {
            this.vlPagoBalcao = ValorPg;
        }

        public double getVlPagoBalcao()
        {
            return vlPagoBalcao;
        }
        public void setTrocoBalcao(double troco)
        {
            this.trocoBalcao = troco;
        }

        public double getTrocoBalcao()
        {
            return trocoBalcao;
        }


        //Funções 

        public void novaVenda()
        {
            string Date = DateTime.Now.ToString("yyyy/MM/dd");
            string query = "Insert into tb_balcao (dataVend) Values ('" + Date + "')";       


            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);

                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }

            MessageBox.Show("Venda aberta com sucesso!!");
            mostraVendaAberta();
        }
        

        public DataTable mostraVendaAberta()
        {
            this.abrirConexao();

            string mSQL = "Select Max(numVend) as Venda, Max(dataVend) as Dia from tb_balcao";
                      
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;            
        }

        public void InserirItem()
        {
            string Date = DateTime.Now.ToString("yyyy/MM/dd");

            string query = "Insert into tb_itemVendaBalcao (numeroVenda, diaVenda, qtd, codProd, valorUnitario) Values ('" + getNumVendaBalcao() + "','" + Date + "','" + getQtdProdBalcao() + "','" + getCodProdBalcao() + "','" + getVlUnitarioBalcao() + "')";

            MessageBox.Show(query);


            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);

                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
            
        }

        public DataTable mostraItensComprados()
        {
            this.abrirConexao();

            string mSQL = "SELECT idxVend as Index, qtd as QTD,codProd as Código,valorUnitario as Unitário, totalItem as Total FROM tb_itemVendaBalcao WHERE numeroVenda=(SELECT max(numeroVenda) FROM tb_itemVendaBalcao)";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}
