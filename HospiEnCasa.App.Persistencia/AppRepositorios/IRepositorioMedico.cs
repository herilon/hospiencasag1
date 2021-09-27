using System;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioMedico
    {
        Medico AddMedico(Medico medico);
        Medico GetMedico(int idMedico);
    }
}