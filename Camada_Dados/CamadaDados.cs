using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camada_Dados
{
    public class CamadaDados
    {
        //Configurações do banco de dados
        
        SQLiteConnection conexao = new SQLiteConnection("Data Source = C:\\Users\\André\\OneDrive - Fatec Centro Paula Souza\\Fatec\\4Semestre\\Eng-Soft3\\wfaProjeto\\Camada_Dados\\EmpresaDB.db;Version=3");
 
    public void AbrirConexao()
        {
            //Abrir conexão
            try
            {
                conexao.Open();
            }
            catch
            {
                throw;
            }
        }

        public void FecharConexao()
        {
            //Fecha conexão
            conexao.Close();
        }


        public void ExecutaComando(string query)
        {
            try
            {
                AbrirConexao();

                SQLiteCommand comando = new SQLiteCommand(conexao);

                comando.CommandText = query;
                
                comando.ExecuteNonQuery();

                FecharConexao();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataSet RetornaDataSet(string comando)
        {
            try
            {
               
                AbrirConexao();

                DataSet ds = new DataSet();
                
                SQLiteDataAdapter da = new SQLiteDataAdapter(comando, conexao);
                da.Fill(ds);

                return ds;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
