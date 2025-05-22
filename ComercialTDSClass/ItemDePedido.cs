using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class ItemDePedido
    {
      

        public int Id { get; set; }
        public int PedidoId { get; set;  }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }
        public ItemDePedido()
        {
            Produto = new();        
        }

        public ItemDePedido(int id, int pedidoId, Produto produto,
             double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            PedidoId = pedidoId;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemDePedido( int pedidoId, Produto produto,
        double quantidade, double desconto)
        {
          
            PedidoId = pedidoId;
            Produto = produto;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemDePedido(int id,
           double quantidade, double desconto)
        {
            Id = id;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public void Deletar(int id)
        {
            var item = ObterPorId(id);
 //           delete from itempedido where id = 1
            var cmd = Banco.Abrir();
            cmd.CommandText = $" update estoques" +
           
         $" (select quantidade from itempedido where id = {item.Quantidade}) where prduto_id = {item.Produto.Id}";
            if (cmd.ExecuteNonQuery()>0)
            {
                cmd.CommandText = $"delete from itempedido where id {id}";
            }
        }
        public void inserir() 
        {
           // sp_itempedido_insert`(sppedido_id int, spproduto_id int,
           // spquantidade decimal(10, 3), spdesconto decimal(10, 2))
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedido_id ", PedidoId);
            cmd.Parameters.AddWithValue("spproduto_id", Produto.Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar);
            cmd.Connection.Close();
        }
        public bool Atualizar()
        {
           
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("spid", Id);

            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            bool atualizado = cmd.ExecuteNonQuery() > 0? true: false;
            cmd.Connection.Close();
            return atualizado;
        }
        public static ItemDePedido ObterPorId(int id)//id do item de pedido
        {
            ItemDePedido itemPedido = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from itempedido where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itemPedido = new(
                    dr.GetInt32(0), 
                    dr.GetInt32(1),
                    Produto.ObterPorId(dr.GetInt32(2)),
                    dr.GetDouble(3),
                     dr.GetDouble(4),
                      dr.GetDouble(5)
                    );

            }
            dr.Close();
            cmd.Connection.Close();
            return itemPedido;
        }
        public static List<ItemDePedido> ObterlistaPorPedidoId(int pedidoId)
        {
            ItemDePedido itemPedido = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from itempedido where pedido_id = {pedidoId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itemPedido.Add( 
                    new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    Produto.ObterPorId(dr.GetInt32(2)),
                    dr.GetDouble(3),
                     dr.GetDouble(4),
                      dr.GetDouble(5)
                    ));

            }
            dr.Close();
            cmd.Connection.Close();
            return itemPedido;    
        }
    }
}
