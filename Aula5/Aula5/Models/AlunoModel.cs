using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Aula5.Models
{
    public class AlunoModel
    {
        public int id { get; set; }
        public String nome{ get; set; }
        public String ra { get; set; }
        public String cpf{ get; set; }
        public int idade{ get; set; }

        readonly string connectionString = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=AVA;Integrated Security=True";


        public DataTable Listar() {

            DataTable alunos = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(connectionString)) {
                sqlCon.Open();

                SqlDataAdapter sqlDT = new SqlDataAdapter("SELECT * FROM aluno order by nome asc", sqlCon);
                sqlDT.Fill(alunos);
            }
                return alunos;
        } 


        public void Salvar() {
            using (SqlConnection sqlCon = new SqlConnection(connectionString)) {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("INSERT INTO aluno VALUES (@nome, @ra, @cpf, @idade) ", sqlCon);

                sqlCmd.Parameters.AddWithValue("@nome", nome);
                sqlCmd.Parameters.AddWithValue("@ra", ra);
                sqlCmd.Parameters.AddWithValue("@cpf", cpf);
                sqlCmd.Parameters.AddWithValue("@idade", idade);

                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
