using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Paciente
    {
        [Key]
        public virtual int Id { get; set; }
        
    }
}
