using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    public class Cadastro
    {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public Cadastro(String nome, String Telefone)
        {



            // 1. Comando Sql -- SqlCommand

            cmd.CommandText = "Insert into ex (nome, telefone) values (@nome, @telefone) ";

            // Parametros

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", Telefone);


            try
            {
                // conectar com banco -- Conexao
                cmd.Connection = conexao.conectar();
                // executar comando
                cmd.ExecuteNonQuery();
                // desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso -- variavel
                this.mensagem = "Cadastrado com sucesso!!!!!!!!!!!!!!!!!!!";
            }

            catch (SqlException e)
            {
                 this.mensagem = "Erro ao tentar se conectar com o banco de dados do Iann";
               
            }


            

            

            
        }
    }
}
