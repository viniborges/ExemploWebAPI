using LojaAPI.Models;
using System.Collections.Generic;

namespace LojaAPI.DAO
{
    public class CarrinhoDAO
    {
        private static Dictionary<long, Carrinho> banco = new Dictionary<long, Carrinho>();
        private static long contador = 1;

        static CarrinhoDAO()
        {
            Produto videogame = new Produto(6237, "PlayStation 4", 4000, 1);
            Produto esporte = new Produto(3467, "Jogo de esporte", 60, 2);
            Carrinho carrinho = new Carrinho();
            carrinho.Adiciona(videogame);
            carrinho.Adiciona(esporte);
            carrinho.Endereco = "Rua José Spoladore, 77, Londrina/PR";
            carrinho.Id = 1;
            banco.Add(1, carrinho);
        }

        public void Adiciona(Carrinho carrinho)
        {
            contador++;
            carrinho.Id = contador;
            banco.Add(contador, carrinho);
        }

        public Carrinho Busca (long id)
        {
            return banco[id];
        }

        public void Remove (long id)
        {
            banco.Remove(id);
        }
    }
}