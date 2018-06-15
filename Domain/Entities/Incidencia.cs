using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Incidencia : Entity<int>
    {

        [Required]
        [MaxLength(50)]
        public string nombre;

        [Required]
        [MaxLength(50)]
        public string descripcion;
    }
}
