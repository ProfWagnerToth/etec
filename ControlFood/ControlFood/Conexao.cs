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
    internal class Conexao
    {
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public String senha;
        public string porta;

        public Conexao()
        {
            inicializar();
        }

        public void inicializar()
        {
            servidor = "127.0.0.1";
            database = "food";
            usuario = "root";
            senha = "root1234";
            porta = "3306";

            string conexaostring;
            conexaostring = "SERVER=" + servidor + ";" + "DATABASE=" + database + ";" + "UID=" + usuario + ";" + "PASSWORD=" + senha + ";" + "Port=" + porta + ";";

            conectar = new MySqlConnection(conexaostring);
           
        }
            public bool abrirConexao()
            {
                try
                {
                    conectar.Open();
                    return true;
                }

                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            System.Windows.Forms.MessageBox.Show("Não Foi Possível Conectar");
                            break;
                        case 1045:
                            System.Windows.Forms.MessageBox.Show("Usuário e Senha Invalidos! Verifique");
                            break;
                    }
                    return false;
                }
            }

            public bool fecharConexao()
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
