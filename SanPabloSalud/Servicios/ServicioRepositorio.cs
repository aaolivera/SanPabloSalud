using Dominio.Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioRepositorio" in both code and config file together.
    public class ServicioRepositorio : IServicioRepositorio
    {
        private readonly IRepositorio repositorio;
        public ServicioRepositorio(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        
        public IList<Paciente> ListarPacientes(string usuario)
        {
            return repositorio.Listar<Paciente>(x => true);
        }
    }
}
