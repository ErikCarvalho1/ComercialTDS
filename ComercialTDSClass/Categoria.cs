using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Categoria
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Categoria() { }
        public Categoria(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            this.Sigla = sigla;
        }
        public Categoria(string nome, string sigla)
        {
            Nome = nome;
            this.Sigla = sigla;
        }
        // inserir, atualizar, lista , obterPorId
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            //cmd.Parameters.Add("spnome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            Id = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
        }
        public static Categoria ObterPorId(int id)
        {
            Categoria categoria = new();
            //codigo categoria método 
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //categoria.Id = dr.GetInt32(0);
                //categoria.Nome = dr.GetString(1);
                //categoria.Sigla = dr.GetString(2);
                categoria = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(1));
            }
            dr.Close();
            cmd.Connection.Close();


            return categoria;

        }
        public static List<Categoria> ObterLista()
        {
            List<Categoria> niveis = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from categorias order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                niveis.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(1)));
            }
            return niveis;
        }
        public bool Atualizar()
        {
            //como o metodo nao é estatico devemos considerar que as propriedades
            //ja possuem valores atrtibudos
            bool atualizado = false;
            if (Id < 1) return atualizado;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);

            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            if (cmd.ExecuteNonQuery() > 0)
            {

                atualizado = true;
            }
            cmd.Connection.Close();
            return atualizado;

        }

    }
}
