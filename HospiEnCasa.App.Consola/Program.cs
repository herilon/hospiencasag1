using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente();
        private static IRepositorioMedico _repoMedico = new RepositorioMedico();
    //    private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //BuscarPaciente(3);
            //MostrarPacientes();
            AddMedico();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Pepito",
                Apellidos = "Perez",
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,
                Direccion = "Calle 4 No 7-4",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990, 04, 12)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
        }
        private static void MostrarPacientes()
        {
            var pacientes = _repoPaciente.GetAllPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
            }
        }

        private static void AddMedico()
        {
            var medico = new Medico
            {
                Nombre = "Francisco",
                Apellidos = "Sanchez",
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,
                Especialidad = "Internista",
                Codigo = "1234abc",
                RegistroRethus = "abc123"
            };
            _repoMedico.AddMedico(medico);
        }


    }
}
