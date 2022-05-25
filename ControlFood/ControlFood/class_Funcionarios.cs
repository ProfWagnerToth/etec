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
    internal class class_Funcionarios : Conexao
    {
        //Declaração de Variáveis privadas para uso na classe
        private int codFunc;
        private string nomeFunc;
        private string cpfFunc;
        private string telFunc;
        private string enderecoFunc;
        private int numeroFunc;
        private string bairroFunc;
        private string cidadeFunc;
        private string ufFunc;
        private string cepFunc;

        // Retornos Set (sem retornos) e Get (com retornos)

        public void setCodFunc(int codigo)
        {
            this.codFunc = codigo;
        }

        public int getCodFunc()
        {
            return this.codFunc;
        }
        public void setNomeFunc(string nome)
        {
            this.nomeFunc = nome;
        }

        public string getNomeFunc()
        {
            return this.nomeFunc;
        }

        public void setCpfFunc(string cpf)
        {
            this.cpfFunc = cpf;
        }

        public string getCpfFunc()
        {
            return this.cpfFunc;
        }

        public void setTelFunc(string telefone)
        {
            this.telFunc = telefone;
        }

        public string getTelFunc()
        {
            return this.telFunc;
        }

        public void setEnderecoFunc(string endereco)
        {
            this.enderecoFunc = endereco;
        }

        public string getEnderecoFunc()
        {
            return this.enderecoFunc;
        }

        public void setNumFunc(int numero)
        {
            this.numeroFunc = numero;
        }

        public int getNumFunc()
        {
            return this.numeroFunc;
        }

        public void setBairroFunc(string bairro)
        {
            this.bairroFunc = bairro;
        }

        public string getBairroFunc()
        {
            return this.bairroFunc;
        }

        public void setCidadeFunc(string cidade)
        {
            this.cidadeFunc = cidade;
        }

        public string getCidadeFunc()
        {
            return this.cidadeFunc;
        }

        public void setufFunc(string estado)
        {
            this.ufFunc = estado;
        }

        public string getUfFunc()
        {
            return this.ufFunc;
        }

        public void setCepFunc(string cep)
        {
            this.cepFunc = cep;
        }

        public string getCepFunc()
        {
            return this.cepFunc;
        }

        //Métodos do Sistemas (Inserir, Alterar, Pesquisar, Excluir)

        //Método Inserir dados na Tabela
        public void inserir()
        { /*Inserção de dados no banco de dados preenchidos no formulário de cadastro.
           String MySQL de inserção de dados na tabela, com utilização de métodos GET para leitura dos campos Text do Formulário. */

            string query = "Insert into tb_funcionarios (nomeFunc, cpfFunc, telFunc, enderecoFunc, numFunc, bairroFunc, cidadeFunc, ufFunc, cepFunc) Values ('" + getNomeFunc() + "','" + getCpfFunc() + "','" + getTelFunc() + "','" + getEnderecoFunc() + "','" + getNumFunc() + "','" + getBairroFunc() + "','" + getCidadeFunc() + "','" + getUfFunc() + "','" + getCepFunc() + "')";

            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);

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
            string mSQL = "Select codFunc as Codigo, nomeFunc as Nome, cpfFunc as CPF, telFunc as Telefone, enderecoFunc as Endereco, numFunc as Numero, bairroFunc as Bairro, cidadeFunc as Cidade, ufFunc as Estado, cepFunc as CEP from tb_funcionarios ";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable ConsultarNome() //Consulta por Nome
        /*Método de Busca selecionado através de um RadioButtom no formulário, para buscar através do nome do cliente.*/
        {
            this.abrirConexao();

            /* String MySQL para busca no banco de dados utilizando o recurso de busca por qualquer parte do dado digitado utilizando o operador LIKE, concatenado com o método GET especifico do campo desejado pela busca. */

            string mSQL = "Select codFunc as Codigo, nomeFunc as Nome, cpfFunc as CPF, telFunc as Telefone, enderecoFunc as Endereco, numFunc as Numero, bairroFunc as Bairro, cidadeFunc as Cidade, ufFunc as Estado, cepFunc as CEP from tb_funcionarios where nomeFunc like '%" + getNomeFunc() + '%' + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable ConsultarCPFFunc() //Consulta por CPF
        {
            this.abrirConexao();

            string mSQL = "Select codFunc as Codigo, nomefunc as Nome, cpfFunc as CPF, telFunc as Telefone, enderecoFunc as Endereco, numfunc as Numero, bairrofunc as Bairro, cidadeFunc as Cidade, ufFunc as Estado, cepFunc as CEP from tb_funcionarios where cpfFunc like '%" + getCpfFunc() + '%' + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable ConsultarCodFunc() //Consulta por Código
        {
            this.abrirConexao();

            string mSQL = "Select nomeFunc as Nome, cpfFunc as CPF, enderecoFunc as Endereço,numFunc as Numero, bairroFunc as Bairro, cidadeFunc as Cidade, ufFunc as Estado from tb_funcionarios where codFunc ='" + getCodFunc() + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void alterar()
        {
            string query = "UPDATE tb_funcionarios SET nomeFunc ='" + getNomeFunc() + "', cpfFunc = '" + getCpfFunc() + "', telFunc = '" + getTelFunc() + "', enderecoFunc = '" + getEnderecoFunc() + "', numFunc = '" + getNumFunc() + "', bairroFunc = '" + getBairroFunc() + "', cidadeFunc = '" + getCidadeFunc() + "', ufFunc = '" + getUfFunc() + "', cepFunc = '" + getCepFunc() + "'  WHERE codFunc = '" + getCodFunc() + "'";


            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

        public void excluir()
        {
            string query = "Delete from tb_funcionarios where codFunc= '" + getCodFunc() + "'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
    }
}

