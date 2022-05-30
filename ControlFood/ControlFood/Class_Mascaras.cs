using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFood
{
    internal class Class_Mascaras
    {
        //Declaração de Variáveis privadas para uso na classe
        private string cpfCli;
        private string telCli;        
        private string cepCli;        

        // Retornos Set (sem retornos) e Get (com retornos)

        public void setMskCpfCli(string cpf)
        {
            this.cpfCli = cpf;
        }

        public string getMskCpfCli()
        {
            return this.cpfCli;
        }

        public void setMskTelCli(string telefone)
        {
            this.telCli = telefone;
        }

        public string getMskTelCli()
        {
            return this.telCli;
        }

        public void setMskCepCli(string cep)
        {
            this.cepCli = cep;
        }

        public string getMskCepCli()
        {
            return this.cepCli;
        }

        public void mascaraCPF()
        {
            long numCPFtxt = long.Parse(this.cpfCli);
            string strMascara = string.Format(@"{0:000\.000\.000\-00}", numCPFtxt);
            string cpfMascara = Convert.ToString(string.Format(strMascara, numCPFtxt));
            this.cpfCli = cpfMascara;
        }

        public string getMascaraCPF()
        {
            return this.cpfCli;
        }
        // Método SET Mascara Telefone Celular
        public void mascaraTelefoneCel()
        {
            long numTeltxt = long.Parse(this.telCli);
            string strMascara = string.Format(@"{0:(00)00000-0000}", numTeltxt);
            string telMacara = Convert.ToString(string.Format(strMascara, numTeltxt));
            this.telCli=telMacara;
        }
        // Método GET Telefone Celular
        public string getMascaraTelefoneCel()
        {
            return this.telCli;
        }
        // Método SET Telefone Fixo
        public void mascaraTelefoneFixo()
        {
            long numTeltxt = long.Parse(this.telCli);
            string strMascara = string.Format(@"{0:(00)0000-0000}", numTeltxt);
            string telMacara = Convert.ToString(string.Format(strMascara, numTeltxt));
            this.telCli = telMacara;
        }
        // Método GET Telefone Fixo
        public string getMascaraTelefoneFixo()
        {
            return this.telCli;
        }

        // Método SET CEP
        public void mascaraCEP()
        {
            long numCEPtxtMsk = long.Parse(this.cepCli);
            string strMascaraMsk = string.Format(@"{0:00\.000\-000}", numCEPtxtMsk);
            this.cepCli = Convert.ToString(string.Format(strMascaraMsk, numCEPtxtMsk));
        }
        // Método GET Telefone Fixo
        public string getMascaraCEP()
        {
            return this.cepCli;
        }
    }
}
