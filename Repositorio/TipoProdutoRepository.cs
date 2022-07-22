using Fiap.Smart.City.Projeto.Models;
using Fiap.Smart.City.Projeto.Repositorio;
using System.Collections.Generic;
using System.Linq;



namespace Fiap.Smart.City.Projeto.Models.Repositorio
{
    public class TipoProdutoRepository
    {
        // Propriedade que terá a instância do DataBaseContext
        private readonly ProdutoContext context;

        public TipoProdutoRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new ProdutoContext();
        }


        public IList<TipoProduto> Listar()
        {
            return context.tiposProdutos.ToList();
        }


        public TipoProduto Consultar(int id)
        {
            return context.tiposProdutos.Find(id);
        }


        public void Inserir(TipoProduto tipoProduto)
        {
            context.tiposProdutos.Add(tipoProduto);
            context.SaveChanges();
        }

        public void Alterar(TipoProduto tipoProduto)
        {
            context.tiposProdutos.Update(tipoProduto);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            // Criar um tipo produto apenas com o Id
            var tipoProduto = new TipoProduto()
            {
                IdTipo = id
            };

            context.tiposProdutos.Remove(tipoProduto);
            context.SaveChanges();
        }

    }
}