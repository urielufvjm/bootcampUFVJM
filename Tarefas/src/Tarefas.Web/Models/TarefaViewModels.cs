using System.ComponentModel;


namespace Tarefas.Web.Models{

    public class TarefaViewModel{
        
        [DisplayName ("Código")]
        public int id {get;set;}

        [DisplayName ("Título")]
        public String Titulo {get;set;}

        [DisplayName ("Descrição")]
        public String Descricao {get;set;}

    }
}