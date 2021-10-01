using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext = new AppContext();

        public Medico AddMedico(Medico medico)
        {
            var medicoAdicionado = _appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }

        public Medico GetMedico(int idMedico)
        {
            return _appContext.Medicos.Find(idMedico);
        }

        public IEnumerable<Medico> GetAllMedicos()
        {
            return _appContext.Medicos;
        }

    }
}