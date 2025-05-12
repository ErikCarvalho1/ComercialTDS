using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Pqc.Crypto.Bike;

namespace ComercialTDSClass
{
    class Nivel
    {
     

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Nivel() { }
   public Nivel(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            this.Sigla = sigla;
        }
        public Nivel(string nome, string sigla)
        {
            Nome = nome;
            this.Sigla = sigla;
        }
        // inserir, atualizar, lista , obterPorId
        public void Iserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_nivel_insert";
            //cmd.Parameters.Add("spnome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            Id = Convert.ToInt32(  cmd.ExecuteNonQuery()) ;
            cmd.Connection.Close();
        }
        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            //codigo nivel método 
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from niveis whwre id = {id}";
            var dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                //nivel.Id = dr.GetInt32(0);
                //nivel.Nome = dr.GetString(1);
                //nivel.Sigla = dr.GetString(2);
                nivel = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(1));
            }
            dr.Close();
            cmd.Connection.Close();


            return nivel;

        }
        public static List<Nivel> ObterLista()
        {
            List<Nivel> niveis = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "seletc * from niveis order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                niveis.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(1)));
            }
            return niveis;
        }
        public bool atualizar()
        {  
            //como o metodo nao é estatico devemos considerar que as propriedades
            //ja possuem valores atrtibudos
            bool atualizado = false;
            if (Id < 1) return atualizado;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_nivel_update";
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
