using Fiap.Smart.City.Projeto.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Filters;


namespace Fiap.Smart.City.Projeto.Controllers
{
    public class TipoProdutoController : Controller
    {
       
        public IActionResult Index()
        {

            // Criando o atributo da lista
            IList<Models.TipoProduto> listaTipo = new List<Models.TipoProduto>();

            // Adicionando na lista o TipoProduto da Tinta
            listaTipo.Add(new TipoProduto()
            {
                IdTipo = 1,
                DescricaoTipo = "Tinta",
                Comercializado = true
            });

            listaTipo.Add(new TipoProduto()
            {
                IdTipo = 2,
                DescricaoTipo = "Filtro de água",
                Comercializado = true
            });

            listaTipo.Add(new TipoProduto()
            {
                IdTipo = 3,
                DescricaoTipo = "Captador de energia",
                Comercializado = false
            });

            // Retornando para View a lista de Tipos
            return View(listaTipo);

        }
        // Anotação de uso do Verb HTTP Get


        [HttpGet]
        public IActionResult Cadastrar()
        {
            // Imprime a mensagem de execução
            System.Diagnostics.Debug.Print("Executou a Action Cadastrar()");

            // Retorna para a View Cadastrar um 
            // objeto modelo com as propriedades em branco 
            return View(new TipoProduto());
        }

        // Anotação de uso do Verb HTTP Post
        [HttpPost]
        public IActionResult Cadastrar(Models.TipoProduto tipoProduto)
        {
            //if (string.IsNullOrEmpty(tipoProduto.DescricaoTipo))
            // {
            //  ModelState.AddModelError("Descricao", "Descrição obrigatória!");
            //  }

            if (ModelState.IsValid)
            {
                // Imprime os valores do modelo
                System.Diagnostics.Debug.Print("Descrição: " + tipoProduto.DescricaoTipo);
                System.Diagnostics.Debug.Print("Comercializado: " + tipoProduto.Comercializado);

                // Simila que os dados foram gravados.
                System.Diagnostics.Debug.Print("Gravando o Tipo de Produto");

                // Substituímos o return View()
                // pelo método de redirecionamento
                TempData["mensagem"] = "Tipo cadastrado com sucesso";

                return RedirectToAction("Index", "TipoProduto");

            }
            else
            {
                return View(tipoProduto);
            }


        }

        [HttpGet]
        public IActionResult Editar(int Id)
        {
            // Imprime a mensagem de execução
            System.Diagnostics.Debug.Print("Consultando o Tipo com Id = " + Id);

            // Cria o modelo que SIMULA a consulta no  banco de dados
            TipoProduto tipoProduto = new TipoProduto()
            {
                IdTipo = Id,
                DescricaoTipo = "Tinta",
                Comercializado = true
            };

            // Retorna para a View o objeto modelo 
            // com as propriedades preenchidas com dados do banco de dados 
            return View(tipoProduto);
        }

        [HttpPost]
        public IActionResult Editar(Models.TipoProduto tipoProduto)
        {
            // Imprime os valores do modelo
            System.Diagnostics.Debug.Print("Descrição: " + tipoProduto.DescricaoTipo);
            System.Diagnostics.Debug.Print("Comercializado: " + tipoProduto.Comercializado);

            // Simila que os dados foram gravados.
            System.Diagnostics.Debug.Print("Gravando o Tipo Editado");

            // Substituímos o return View()
            // pelo método de redirecionamento
            return RedirectToAction("Index", "TipoProduto");
        }

        [HttpGet]
        public IActionResult Consultar(int Id)
        {
            // Imprime a mensagem de execução
            System.Diagnostics.Debug.Print("Consultando o Tipo com Id = " + Id);
            // Cria o modelo que SIMULA a consulta no  banco de dados
            TipoProduto tipoProduto = new TipoProduto()
            {
                IdTipo = Id,
                DescricaoTipo = "Tinta",
                Comercializado = true
            };
            // Retorna para a View o objeto modelo 
            // com as propriedades preenchidas com dados do banco de dados 
            return View(tipoProduto);
        }

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            // Imprime a mensagem de execução
            System.Diagnostics.Debug.Print("Excluir o Tipo com Id = " + Id);

            // Substituímos o return View()
            // pelo método de redirecionamento
            return RedirectToAction("Index", "TipoProduto");
        }
    }
}       

