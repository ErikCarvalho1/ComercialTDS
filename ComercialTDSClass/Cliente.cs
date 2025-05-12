using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    class Cliente
    {
       

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public DateTime DataNasc { get; set; }

        public DateTime DataCad { get; set; }

        public bool Ativo { get; set; }

        public Cliente() { }

        //listar
        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime dataNasc, DateTime dataCad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = dataNasc;
            DataCad = dataCad;
            Ativo = ativo;
        }


        //inserir 
        public Cliente( string nome, string cpf, string telefone, string email, DateTime dataNasc, DateTime dataCad, bool ativo)
        {
            
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Ativo = ativo;
        }
        //alterar
        public Cliente( string nome,  string telefone, DateTime dataNasc, DateTime dataCad, bool ativo)
        {
            
            Nome = nome;
            Telefone = telefone;
            DataNasc = dataNasc;
            DataCad = dataCad;
            Ativo = ativo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
      
            Id = Convert.ToInt32(cmd.ExecuteScalarAsync());
            cmd.Connection.Close();
        }
        public bool Atualizar()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnopme", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone",Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);

            //usuando if ternario, sem fechar conexao 
            return cmd.ExecuteNonQuery() > 0 ? true : false;

               
        }

    }
}
