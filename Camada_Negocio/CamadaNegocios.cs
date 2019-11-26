using Camada_Dados;
using System;
using System.Data;
using System.Net.Mail;

namespace Camada_Negocios
{
    public class CamadaNegocios
    {
        public DataSet ExibirDados(string tabela)
        {
            CamadaDados acessaDados = new CamadaDados();
            return acessaDados.RetornaDataSet("Select * from "+tabela);
        }
        //Validações

        public bool Cpf(string cpf)
        {
            //numeros de teste do CPF
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };


            cpf = cpf.Trim().Replace(".", "").Replace(",", "");

            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string cpfTemp = cpf.Substring(0, 9);

            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpfTemp[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();

            cpfTemp += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpfTemp[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            return cpf.EndsWith(digito);
            // Fim da validação
        }

        public bool Cnpj(string cnpj)
        {
            //numeros de teste do CNPJ
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace(",", "").Replace("-", "");

            if (cnpj.Length != 14)
                return false;

            string cnpjTemp = cnpj.Substring(0, 12);
            int soma = 0;

            for (int c = 0; c < 12; c++)
                soma += int.Parse(cnpjTemp[c].ToString()) * multiplicador1[c];

            int resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();

            cnpjTemp += digito;

            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(cnpjTemp[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public static bool Email(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }


    public class BancoCliente
    {
        public DataSet InserirCliente(string nome, string cpf, string cnpj, string email, string tipo, string telefone, string logradouro, string bairro, string cidade, string estado, string complemento, string numero)
        {
            CamadaDados acessaDados = new CamadaDados();
            return acessaDados.RetornaDataSet("INSERT INTO Cliente(Nome_Cliente,CPF_Cliente,CNPJ_Cliente,Email_Cliente,Tipo_Cliente,Telefone_Cliente,Logradouro,Bairro,Cidade,Estado,Complemento,Numero) VALUES('" + nome + "','" + cpf + "','" + cnpj + "','" + email + "','" + tipo + "','" + telefone + "','" + logradouro + "','" + bairro + "','" + cidade + "','" + estado + "'," + complemento + "," + numero + ")");
        }
       
        public DataSet AlterarCliente(string nome, string cpf, string cnpj, string email, string tipo, string telefone, string logradouro, string bairro, string cidade, string estado, string complemento, string numero)
        {
            CamadaDados acessaDados = new CamadaDados();
            return acessaDados.RetornaDataSet("update Cliente set Nome_Cliente='" + nome + "', CPF_Cliente='" + cpf + "',CNPJ_Cliente='" + cnpj + "',Email_Cliente='" + email + "',Tipo_Cliente='" + tipo + "',Telefone_Cliente='" + telefone + "',Logradouro='" + logradouro+ "',Bairro='" + bairro + "',Cidade='" + cidade + "',Estado='" + estado + "',Complemento=" + complemento + ",Numero =" + numero + " where Nome_Cliente='" + nome + "'");
        }

        public DataSet SelecionarCLietne(string nome)
        {
            CamadaDados acessaDados = new CamadaDados();
            return acessaDados.RetornaDataSet("Select * from alunos where nome='" + nome + "'");
        } 
        
        public DataSet ExcluirCliente(string nome, string cpf, string cnpj, string email, string tipo, string telefone, string logradouro, string bairro, string cidade, string estado, string complemento, string numero)
        {
            CamadaDados acessaDados = new CamadaDados();
            return acessaDados.RetornaDataSet("delete from Cliente where Nome_Cliente = '" + nome + "'");
        }
    }

    public class BancoEstoque
    {

    }

    public class BancoPedido
    {

    }

    public class BancoProduto

    public class BancoLogin
    {

    }
}
