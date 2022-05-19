using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Antes da chamada das bibliotecas necessárias para sincronismo da aplicação com o banco de dados você deverá:
 1. Instalar em seu computador o MySQL Conector baixado diretamente do site da MySQL
 2. Tendo o MySQL Conector intalado deverá, instalar em sua aplicação as referencias de banco de dados MySQL Data e MySQLConector através da adição de referencias no projeto ou através do Maneger NuGET Packages
 3. Apontar o Uso das bibliotecas:
 3.1 MySQL.Data;
 3.2 MySQL.Data.MySqlClient;
 3.3 Systema.Data;
*/
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace ControlFood
{
    internal class Conexao
    {
        //Declarando Variáveis para utilização na Classe Conexão
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;
        public string porta;

        public Conexao() //Método Conexão, será responsável por inicializar a conexão entre aplicação e o banco de dados.
        {
            inicializar(); //Chamada do método de inciliazar o banco de dados.
        }

        public void inicializar() //Codificação do Método Inicializar
        {
            servidor = "127.0.0.1"; //Endereço de IP do seu Servidor de Banco de Dados
            database = "food";      //Nome do banco de dados que será utilizado
            usuario = "root";       //Usuário de conexão com o banco de dados
            senha = "root1234";     //Senha de acesso a seu banco de dados
            porta = "3306";         //Porta de comunição do seu banco de dados (normalmente 3306, podendo ser 3307, se atentar a configuração de seu servidor de Banco de Dados)

            string conexaostring; //Variável de armazenamento de dados de conexão com o banco de dados.
            //String de passagem de dados para conexão com banco de dados.
            conexaostring = "SERVER=" + servidor + ";" + "DATABASE=" + database + ";" + "UID=" + usuario + ";" + "PASSWORD=" + senha + ";" + "Port=" + porta + ";";

            //Chamada da string de conexão
            conectar = new MySqlConnection(conexaostring);
           
        }
        /*Para qualquer movimentação no banco de dados será necessário após a conexão com o banco a abertura do banco, realização das ações necessárias e após a conclusão o banco deverá ser fechado para que não haja problemas com a integridade dos dados dentro dele.*/
            public bool abrirConexao() //Método de abertura de Banco de Dados
            {
                try
                {
                    conectar.Open();
                    return true;
                }

                catch (MySqlException ex) //Menssagens de possiveis erros de conexão.
                {
                    switch (ex.Number)
                    {
                        case 0: //Problema com a conexão com o banco verifique seus dados de conexão com o banco. 
                            System.Windows.Forms.MessageBox.Show("Não Foi Possível Conectar");
                            break;
                        case 1045: //Problema com a senha digitada na conexão com o banco verifique se realmente foi configurada corretamente na String de Conexão.
                            System.Windows.Forms.MessageBox.Show("Usuário e Senha Invalidos! Verifique!");
                            break;
                    }
                    return false;
                }
            }

            public bool fecharConexao() //Método de Fechamento de Banco de Dados
            {
                try
                {
                    conectar.Close();
                    return true;
                }
                catch (MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
    }
