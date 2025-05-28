using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Estoque
    {
        public Produto? ProdutoId { get; set; }
        public int? Quantidade { get; set; }
        public DateTime? UltimoMovimento { get; set; }

        public  Estoque() { }
        public Estoque(Produto? produto, int? quantidade, DateTime? ultimmovimento) 
        {
            ProdutoId = produto;
            Quantidade = quantidade;
            UltimoMovimento = ultimmovimento;          
        }
    }
   
}
