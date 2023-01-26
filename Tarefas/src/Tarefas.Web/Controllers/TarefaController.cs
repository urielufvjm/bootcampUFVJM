
using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers
{
    
    public class TarefaController : Controller
    {
        public  List<TarefaViewModel> listaDeTarefas{get;set;}
        public TarefaController(){
            new TarefaViewModel() {
                id = 1, Titulo ="tarefa olhar", 
                };
                 new TarefaViewModel() {
                id = 2, Titulo ="tarefa esperar", Descricao = "aguarde por favor"
                };
        }
        public IActionResult Create(){
                    
            return View();

        }

        public IActionResult Index(){
             
            return View(listaDeTarefas);
        }

        public IActionResult Details(int id){
            var tarefa = listaDeTarefas.Find(tarefa=> tarefa.id == id);
            return View(tarefa);

        }
    }
}