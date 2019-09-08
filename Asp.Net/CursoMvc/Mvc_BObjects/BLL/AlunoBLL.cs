using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class AlunoBLL
    {
        //responsavel pela conexão do banco de dados atraves WebConfig
        public IEnumerable<Aluno> GetAlunos()
        {
            //recuperando a string de conexão que esta armazenada no WebConfig
            string connectionString = ConfigurationManager.ConnectionStrings["ConSQLServer"].ConnectionString;

            //criando um objeto que vai representar uma lista de alunos
            List<Aluno> alunos = new List<Aluno>();

            try
            {
                //Assim que terminar o using lib era o recurso não precisando fechar a conexão
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    //Lendo a procedure
                    SqlCommand cmd = new SqlCommand("GetAlunos", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Aluno aluno = new Aluno();
                        aluno.Id = Convert.ToInt32(rdr["Id"]);
                        aluno.Nome = rdr["Nome"].ToString();
                        aluno.Email = rdr["Email"].ToString();
                        aluno.Idade = Convert.ToInt32(rdr["Idade"]);
                        aluno.DataIncricao = Convert.ToDateTime(rdr["DataIncricao"]);
                        aluno.Sexo = rdr["Sexo"].ToString();
                        alunos.Add(aluno);
                    }
                }
                return alunos;
            }
            catch
            {
                throw;
            }
        }
    }
}