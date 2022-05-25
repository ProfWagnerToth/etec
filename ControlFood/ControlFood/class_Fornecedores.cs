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
    internal class Class_Fornecedores : Conexao
    {
        //Declaração de Variáveis privadas para uso na classe

        private int codForn;
        private string razaoSocial;
        private string nomeFantasia;
        private string telForn;
        private string cnpjForn;
        private string enderecoForn;
        private int numeroForn;
        private string bairroForn;
        private string cidadeForn;
        private string ufForn;
        private string cepForn;

        // Retornos Set (sem retornos) e Get (com retornos)

        public void setCodForn(int codigo)
        {
            this.codForn = codigo;
        }

        public int getCodForn()
        {
            return this.codForn;
        }
        public void setRazaoSocial(string nome)
        {
            this.razaoSocial = nome;
        }

        public string getRazaoSocial()
        {
            return this.razaoSocial;
        }

        public void setNomeFantasia(string NomeFant)
        {
            this.nomeFantasia = NomeFant;
        }

        public string getNomeFantasia()
        {
            return this.nomeFantasia;
        }

        public void setTelForn(string telefone)
        {
            this.telForn = telefone;
        }

        public string getTelForn()
        {
            return this.telForn;
        }

        public void setCnpj(string cnpj)
        {
            this.cnpjForn = cnpj;
        }

        public string getCnpj()
        {
            return this.cnpjForn;
        }

        public void setEnderecoForn(string endereco)
        {
            this.enderecoForn = endereco;
        }

        public string getEnderecoForn()
        {
            return this.enderecoForn;
        }

        public void setNumForn(int numero)
        {
            this.numeroForn = numero;
        }

        public int getNumForn()
        {
            return this.numeroForn;
        }

        public void setBairroForn(string bairro)
        {
            this.bairroForn = bairro;
        }

        public string getBairroForn()
        {
            return this.bairroForn;
        }

        public void setCidadeForn(string cidade)
        {
            this.cidadeForn = cidade;
        }

        public string getCidadeForn()
        {
            return this.cidadeForn;
        }

        public void setufForn(string estado)
        {
            this.ufForn = estado;
        }

        public string getUfForn()
        {
            return this.ufForn;
        }

        public void setCepForn(string cep)
        {
            this.cepForn = cep;
        }

        public string getCepForn()
        {
            return this.cepForn;
        }

        //Métodos do Sistemas (Inserir, Alterar, Pesquisar, Excluir)

        //Método Inserir dados na Tabela
        public void inserir()
        { /*Inserção de dados no banco de dados preenchidos no formulário de cadastro.
           String MySQL de inserção de dados na tabela, com utilização de métodos GET para leitura dos campos Text do Formulário. */

            string query = "Insert into tb_fornecedores (razaoSocialForn, nomeFantForn, telForn, cnpjForn, enderecoForn, numForn, bairroForn, cidadeForn, ufForn, cepForn) Values ('" + getRazaoSocial() + "','" + getNomeFantasia() + "','" + getTelForn() + "','" + getCnpj() + "','" + getEnderecoForn() + "','" + getNumForn() + "','" + getBairroForn() + "','" + getCidadeForn() + "','" + getUfForn() + "','" + getCepForn() + "')";

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
            string mSQL = "Select codForn as Codigo, razaoSocialForn as Razão_Social, nomeFantForn as Nome_Fantasia, telForn as Telefone, cnpjForn as CNPJ, enderecoForn as Endereço, numForn as Número, bairroForn as Bairro, cidadeForn as Cidade, ufForn as Estado, cepForn as CEP from tb_fornecedores ";

            
            /*
            string mSQL = "Select codCli as Codigo, nomeCli as Nome, cpfCli as CPF, telCli as Telefone, enderecoCli as Endereco, numCli as Numero, bairroCli as Bairro, cidadeCli as Cidade, ufCli as Estado, cepCli as CEP from tb_clientes ";
            */

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable ConsultarCNPJ() //Consulta por CNPJ
        /*Método de Busca selecionado através de um RadioButtom no formulário, para buscar através do nome do cliente.*/
        {
            this.abrirConexao();

            /* String MySQL para busca no banco de dados utilizando o recurso de busca por qualquer parte do dado digitado utilizando o operador LIKE, concatenado com o método GET especifico do campo desejado pela busca. */

            string mSQL = "Select codForn as Codigo, razaoSocialForn as Razão_Social, nomeFantForn as Nome_Fantasia, telForn as Telefone, cnpjForn as CNPJ, enderecoForn as Endereço, numForn as Número, bairroForn as Bairro, cidadeForn as Cidade, ufForn as Estado, cepForn as CEP from tb_fornecedores where cnpjForn like '%" + getCnpj() + '%' + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable ConsultarRazaoSocial() //Consulta por Razão Social
        {
            this.abrirConexao();

            string mSQL = "Select codForn as Codigo, razaoSocialForn as Razão_Social, nomeFantForn as Nome_Fantasia, telForn as Telefone, cnpjForn as CNPJ, enderecoForn as Endereço, numForn as Número, bairroForn as Bairro, cidadeForn as Cidade, ufForn as Estado, cepForn as CEP from tb_fornecedores where razaoSocialForn like '%" + getRazaoSocial() + '%' + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MessageBox.Show(mSQL);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable ConsultarCodForn() //Consulta por Código
        {
            this.abrirConexao();

            string mSQL = "Select codForn as Codigo, razaoSocialForn as Razão_Social, nomeFantForn as Nome_Fantasia, telForn as Telefone, cnpjForn as CNPJ, enderecoForn as Endereço, numForn as Número, bairroForn as Bairro, cidadeForn as Cidade, ufForn as Estado, cepForn as CEP from tb_fornecedores where codForn ='" + getCodForn() + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();


            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void alterar()
        {
            string query = "UPDATE tb_fornecedores SET razaoSocialForn ='" + getRazaoSocial() + "', nomeFantForn = '" + getNomeFantasia() + "', telForn = '" + getTelForn() + "', cnpjForn = '" + getCnpj() + "', enderecoForn = '" + getEnderecoForn() + "', numForn = '" + getNumForn() + "', bairroForn = '" + getBairroForn() + "', cidadeForn = '" + getCidadeForn() + "', ufForn = '" + getUfForn() + "', cepForn = '" + getCepForn() + "'  WHERE codForn = '" + getCodForn() + "'";


            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }

        public void excluir()
        {
            string query = "Delete from tb_fornecedores where codForn= '" + getCodForn() + "'";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
    }
}
