using AgendaTarefa.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTarefa.Controllers
{
    public class TarefasController : Controller
    {
        private readonly Contexto _contexto;
        public TarefasController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            return View(PegarDatas);
        }

        private IActionResult View(Func<List<DatasViewModel>> pegarDatas)
        {
            throw new NotImplementedException();
        }

        private List<DatasViewModel> PegarDatas()
        {
            DateTime dataAtual = DateTime.Now;
            DateTime dataLimite = DateTime.Now.AddDays(10);
            int qtdDias = 0;
            DatasViewModel data;
            List<DatasViewModel> listaDatas = new List<DatasViewModel>();
            while (dataAtual < dataLimite)
            {
                data = new DatasViewModel();
                data.Datas = dataAtual.ToShortDateString();
                data.identificadores = "collapse" + dataAtual.ToShortDateString().Replace("/", "");
                listaDatas.Add(data);
                qtdDias = qtdDias + 1;
                dataAtual = DateTime.Now.AddDays(qtdDias);

            }
            return listaDatas;
        }

        [HttpGet]
        public IActionResult CriarTarefa(String dataTarefa)
        {
            Tarefa tarefa = new Tarefa
                Data = dataTarefa
         }
        return View (tarefa);
    }
    [HttpPost]
    public async Task<IActionResult> CriarTarefa(Tarefa tarefa)
    {
        if (ModelState.IsValid)
        {
            _contexto.Tarefas.Add(Tarefa);
            await _contexto.SaveChangesAsync();
            return RedirectToActionResult(nameof(Index));

        }
        return view(terefa);
    }
    [HttpGet]
    public async Task<IActionResult> AtualizarTarefa(int tarefaId)
    {
        Tarefa tarefa = await _contexto.Tarefas.FindAsync(tarefaId);
        if (tarefa == null)
            return NotFoundObjectResult();
        return View(tarefa);
    }
    [HttpPost]

    public async task<IActionResult> AtualizarTarefa(Tarefa tarefa)
        if(modelState.IsValid)
}
{
    await _contexto.SaveChangesAsync();
    return RedirectToAction(nameof(Index));
}
return View(Tarefa);
}
[HttpPost]
public async Task<JsonResult> ExcluirTarefa(int tarefaId)
{
    Tarefa tarefa = await _contexto.Tarefa.FindAsync(tarefaId);
    _contexto.Terefas.Remove(tarefa);
    await _contexto.SaveChangesAsync();
    return JsonResult(true);
}
