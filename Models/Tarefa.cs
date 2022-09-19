using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTarefa.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        [Required(ErrorMessage = "{0} É obrigatorio")]
        [StringLength (50, ErrorMessage = "Use menos caracteres")]
        public string Nome da Tarefa { get; set; }

        Required(ErrorMessage = "{0} É obrigatorio")]
        public string Prioridade { get; set; }


        Required(ErrorMessage = "{0} É obrigatorio")]
        public string Descriçao da Tarefa { get; set; }


        [Required(ErrorMessage = "{0} É obrigatorio")]
        public string Data { get; set; }

        [Required(ErrorMessage = "{0} É obrigatorio")]
        [DataType(DataType.Time)]
        public string Horario { get; set; }

    }
}
