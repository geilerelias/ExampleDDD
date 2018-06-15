using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tarea : Entity<int>
    {

        [Required]
        [MaxLength(50)]
        public string nombre;

        [Required]
        [MaxLength(500)]
        public string descripcion;

        [Required]
        [MaxLength(50)]
        public string vehiculo;

        [Required]
        [MaxLength(50)]
        public string empleado;

    }
}
