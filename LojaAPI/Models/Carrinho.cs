using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace LojaAPI.Models
{
    public class Carrinho
    {
        public List<Produto> Produtos { get; set; }
        public string Endereco { get; set; }
        public long Id { get; set; }

        public Carrinho()
        {
            this.Produtos = new List<Produto>();
        }

        public void Adiciona(Produto produto)
        {
            this.Produtos.Add(produto);
        }

        public string ToXml()
        {
            //serializar o tipo Carrinho em XML
            XmlSerializer xml = new XmlSerializer(typeof(Carrinho));
            StringWriter stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                xml.Serialize(writer, this);
                return stringWriter.ToString();
            }

        }

        public void Remove(long id)
        {
            Produto produto = Produtos.FirstOrDefault(p => p.Id == id);
            Produtos.Remove(produto);
        }

        public void Troca(Produto produto)
        {
            Remove(produto.Id);
            Adiciona(produto);
        }

        public void TrocaQuantidade(Produto prod)
        {
            Produto prodCarregado = Produtos.FirstOrDefault(p => p.Id == prod.Id);
            prodCarregado.Quantidade = prod.Quantidade;
        }

        public void TrocaEndereco(string endereco)
        {
            this.Endereco = endereco;
        }
    }
}