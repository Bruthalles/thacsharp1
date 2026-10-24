using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace models
{
    public class Vendas
    {
        public Vendas(int id,string produto,decimal preco)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
    }
}