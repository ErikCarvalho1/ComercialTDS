using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Inserir() { }

        public bool Atualizar()
        {
            return true;
        }     
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();

            return pedido;
        }
        public static List<Pedido> obterLista()
        {
            List<Pedido> pedidos = new();
            return pedidos;
        }
    }
}
