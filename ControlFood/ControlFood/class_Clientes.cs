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
        private int codCli;
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

        public void setCodCli(int codigo)
        {
            this.codCli = codigo;
        }

        public int getCodCli()
        {
            return this.codCli;
        }
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
        { /*Inserção de dados no banco de dados preenchidos no formulário de cadastro.
           String MySQL de inserção de dados na tabela, com utilização de métodos GET para leitura dos campos Text do Formulário. */

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
            /*Método de busca de todos os registros no banco de dados, sem a utilização de qualquer parametrização de busca por nome ou cpf, trata-se de uma busca por todos registros existentes no banco de dados.*/
        {
            this.abrirConexao();

               /*String MySQL de busca por todos registros no banco de dados*/         
            string mSQL = "Select * from tb_clientes ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable ConsultarNome() //Consulta Nome Cliente
            /*Método de Busca selecionado através de um RadioButtom no formulário, para buscar através do nome do cliente.*/
        {
            this.abrirConexao();
            
            /* String MySQL para busca no banco de dados utilizando o recurso de busca por qualquer parte do dado digitado utilizando o operador LIKE, concatenado com o método GET especifico do campo desejado pela busca. */

            string mSQL = "Select * from tb_clientes where nomeCli like '%" + getNomeCli() +'%'+"'";      

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);           

            this.fecharConexao();          
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable ConsultarCPF() //Consulta CPF CLiente
        {
            this.abrirConexao();

            string mSQL = "Select * from tb_clientes where cpfCli like '%" + getCpfCli()+ '%' + "'";    

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
