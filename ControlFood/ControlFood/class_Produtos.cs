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
    internal class class_Produtos : Conexao
    {
        //Declaração de Variáveis privadas para uso na classe

        private int codProd;
        private string codBarProd;
        private string descProd;
        private string undProd;
        private string vlCompProd;
        private string vlVendProd;
        

        // Retornos Set (sem retornos) e Get (com retornos)

        public void setCodProd(int codigo)
        {
            this.codProd = codigo;
        }

        public int getCodProd()
        {
            return this.codProd;
        }
        public void setCodBarProd(string codBarras)
        {
            this.codBarProd = codBarras;
        }

        public string getCodBarProd()
        {
            return this.codBarProd;
        }

        public void setDescProd(string descricao)
        {
            this.descProd = descricao;
        }

        public string getDescProd()
        {
            return this.descProd;
        }

        public void setUndProd(string unidade)
        {
            this.undProd = unidade;
        }

        public string getUndProd()
        {
            return this.undProd;
        }

        public void setVlCompProd(string VlCompra)
        {
            this.vlCompProd = VlCompra;
        }

        public string getVlCompProd()
        {
            return this.vlCompProd;
        }

        public void setVlVendProd(string VlVenda)
        {
            this.vlVendProd = VlVenda;
        }

        public string getVlVendProd()
        {
            return this.vlVendProd;
        }        

        //Métodos do Sistemas (Inserir, Alterar, Pesquisar, Excluir)

        //Método Inserir dados na Tabela
        public void inserir()
        { /*Inserção de dados no banco de dados preenchidos no formulário de cadastro.
           String MySQL de inserção de dados na tabela, com utilização de métodos GET para leitura dos campos Text do Formulário. */

            string query = "Insert into tb_produtos (codBarProd, descProd, undProd, vlCompProd, vlVendProd) Values ('" + getCodBarProd() + "','" + getDescProd() + "','" + getUndProd() + "','" + getVlCompProd() + "','" + getVlVendProd() + "')";

            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);

                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

        //Método Consultar dados na tabela
        public DataTable Consultar() //Consulta todos os Registros
        /*Método de busca de todos os registros no banco de dados, sem a utilização de qualquer parametrização de busca por Razão Social ou CNPJ, trata-se de uma busca por todos registros existentes no banco de dados.*/
        {
            this.abrirConexao();

            /*String MySQL de busca por todos registros no banco de dados*/
            string mSQL = "Select codProd as Codigo, codBarProd as Codigo_Barras, descProd as Descricao, undProd as Unidade, VlCompProd as Valor_Compra, VlVendProd as Valor_Venda from tb_produtos ";
                   

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable ConsultarDescricao() //Consulta por Descrição
        /*Método de Busca selecionado através de um RadioButtom no formulário, para buscar através do nome do cliente.*/
        {
            this.abrirConexao();

            /* String MySQL para busca no banco de dados utilizando o recurso de busca por qualquer parte do dado digitado utilizando o operador LIKE, concatenado com o método GET especifico do campo desejado pela busca. */

            string mSQL = "Select codProd as Codigo, codBarProd as Codigo_Barras, descProd as Descricao, undProd as Unidade, VlCompProd as Valor_Compra, VlVendProd as Valor_Venda from tb_produtos where descProd like '%" + getDescProd() + '%' + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        
        public DataTable ConsultarCodProd() //Consulta por Código
        { 
            this.abrirConexao();

            string mSQL = "Select codProd as Codigo, codBarProd as Codigo_Barras, descProd as Descricao, undProd as Unidade, VlCompProd as Valor_Compra, VlVendProd as Valor_Venda from tb_produtos where codProd like '%" + getCodProd() + '%' + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MessageBox.Show(mSQL);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        
        public DataTable ConsultarCodBar() //Consulta por Código de Barras
        {
            this.abrirConexao();

            string mSQL = "Select codProd as Codigo, codBarProd as Codigo_Barras, descProd as Descricao, undProd as Unidade, VlCompProd as Valor_Compra, VlVendProd as Valor_Venda from tb_produtos where codBarProd ='" + getCodBarProd() + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void alterar()
        {
            string query = "UPDATE tb_produtos SET codBarProd ='" + getCodBarProd() + "', descProd = '" + getDescProd() + "', undProd = '" + getUndProd() + "', vlCompProd = '" + getVlCompProd() + "', vlVendProd = '" + getVlVendProd() + "' WHERE codProd = '" + getCodProd() + "'";


            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

        public void excluir()
        {
            string query = "Delete from tb_produtos where codProd= '" + getCodProd() + "'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
    }
} 

