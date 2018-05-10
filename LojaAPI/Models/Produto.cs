using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaAPI.Models
{
    public class Produto
    {
        public long Id { get; set; }
        public double Preco { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Produto(){}

        public Produto(long id, string nome, double preco, int quantidade)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}