using System;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);    
        Paciente GetPaciente(int idPaciente);
        Medico AsignarMedico(int idPaciente, int idMedico);
        SignoVital AsignarSignoVital(int idPaciente, SignoVital signoVital);
        IEnumerable<Paciente> GetPacientesGenero(int genero);
        IEnumerable<Paciente> SearchPacientes(string nombre);
    }
}