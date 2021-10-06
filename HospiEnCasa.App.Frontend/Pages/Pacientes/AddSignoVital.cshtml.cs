using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEncasa.App.Frontend.Pages.Pacientes
{
    public class AddSignoVitalModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public Paciente paciente {get; set;}
        public SignoVital signoVital {get; set;}
        public AddSignoVitalModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        }

        public void OnGet(int id)
        {
            paciente = _repoPaciente.GetPaciente(id);
            signoVital = new SignoVital();
        }

        public IActionResult OnPost(int idPaciente, SignoVital signoVital)
        {
            _repoPaciente.AsignarSignoVital(idPaciente, signoVital);
            return RedirectToPage("Details", new{id = idPaciente});
        }
    }
}
