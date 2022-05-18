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
    internal class class_Clientes : Conexao
    {
        //Declaração de Variáveis privadas para uso na classe
        private string nomeCli;
        private string cpfCli;
        private string telCli;
        private string enderecoCli;
        private int numeroCli;
        private string bairroCli;
        private string cidadeCli;
        private string ufCli;
        private string cepCli;

        // Retornos Set (sem retornos) e Get (com retornos)
        public void setNomeCli (string nome)
        {
            this.nomeCli = nome;
        }

        public string getNomeCli()
        {
            return this.nomeCli;
        }

        public void setCpfCli(string cpf)
        {
            this.cpfCli = cpf;
        }

        public string getCpfCli()
        {
            return this.cpfCli;
        }

        public void setTelCli(string telefone)
        {
            this.telCli = telefone;
        }

        public string getTelCli()
        {
            return this.telCli;
        }

        public void setEnderecoCli(string endereco)
        {
            this.enderecoCli = endereco;
        }

        public string getEnderecoCli()
        {
            return this.enderecoCli;
        }

        public void setNumCli(int numero)
        {
            this.numeroCli = numero;
        }

        public int getNumCli()
        {
            return this.numeroCli;
        }

        public void setBairroCli(string bairro)
        {
            this.bairroCli = bairro;
        }

        public string getBairroCli()
        {
            return this.bairroCli;
        }

        public void setCidadeCli(string cidade)
        {
            this.cidadeCli = cidade;
        }

        public string getCidadeCli()
        {
            return this.cidadeCli;
        }

        public void setufCli(string estado)
        {
            this.ufCli = estado;
        }

        public string getUfCli()
        {
            return this.ufCli;
        }

        public void setCepCli(string cep)
        {
            this.cepCli = cep;
        }

        public string getCepCli()
        {
            return this.cepCli;
        }

        //Métodos do Sistemas (Inserir, Alterar, Pesquisar, Excluir)

        //Método Inserir dados na Tabela
        public void inserir()
        {
            string query = "Insert into tb_clientes (nomeCli, cpfCli, telCli, enderecoCli, numCli, bairroCli, cidadeCli, ufCli, cepCli) Values ('" + getNomeCli() + "','" + getCpfCli() + "','" + getTelCli() + "','" + getEnderecoCli() + "','" + getNumCli() + "','" + getBairroCli() + "','" + getCidadeCli() + "','" + getUfCli() + "','" + getCepCli() + "')";

            if(this.abrirConexao()==true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

        //Método Consultar dados na tabela
        public DataTable Consultar() //Consulta todos os Registros
        {
            this.abrirConexao();

                        
            string mSQL = "Select * from tb_clientes ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }        
    }
}
