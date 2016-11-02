using Dominio.Entidades;
using System.Collections.Generic;
using System.ServiceModel;

namespace Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioRepositorio" in both code and config file together.
    [ServiceContract]
    public interface IServicioRepositorio
    {

        [OperationContract]
        IList<Paciente> ListarPacientes(string usuario);
        
    }
}
