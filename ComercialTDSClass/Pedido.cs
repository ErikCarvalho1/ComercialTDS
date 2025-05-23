using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Pedido
    {

        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public List<ItemDePedido>Items { get; set; }
        public Pedido(){}

        public Pedido(int id, Usuario usuario, Cliente cliente,
            DateTime data, string status, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = Desconto;
        }
        public Pedido(Usuario usuario, Cliente cliente)
        {
            
            Usuario = usuario;
            Cliente = cliente;
      
        }
        public Pedido(int id,  DateTime data, string status, double desconto)
        {
            Id = id;
         Status = status;
            Desconto = Desconto;
        }

        public Pedido(int id, Usuario usuario, Cliente cliente, 
            DateTime data, string status, double desconto,
            List<ItemDePedido> items)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Items = items;
        }

        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spusario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spstatus", Status);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            bool atualizado = cmd.ExecuteNonQuery() > 0 ? true : false;
            cmd.Connection.Close();
            return atualizado;
        }     
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where id = {id}";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                pedido = new(
                    dr.GetInt32(0),
                    Usuario.ObterporId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5),
                    ItemDePedido.ObterlistaPorPedidoId(dr.GetInt32(0))
                    );
            }
            dr.Close();
            cmd.Connection.Close();
            return pedido;
        }
        public static List<Pedido> obterLista()
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(  new(
                    dr.GetInt32(0),
                    Usuario.ObterporId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5),
                    ItemDePedido.ObterlistaPorPedidoId(dr.GetInt32(0))
                    )
                    );
            }
            dr.Close();
            cmd.Connection.Close();
            return pedidos;
        }
    }
}
