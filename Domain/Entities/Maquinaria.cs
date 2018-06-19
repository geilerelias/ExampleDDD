using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain.Entities
{

    public class Maquinaria:  Entity<int>
    {

        [Required]
        [MaxLength(50)]
        public string Placa { get; set; }

        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }

        [Required]
        [MaxLength(50)]
        public string Linea { get; set; }

        [Required]
        [MaxLength(50)]
        public string Modelo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Color { get; set; }

        [Required]
        [MaxLength(50)]
        public string FechaAdquisicion { get; set; }

        [Required]
        [MaxLength(50)]
        public string Chasi { get; set; }

        [Required]
        [MaxLength(50)]
        public string Motor { get; set; }

        public List<Componente> Componentes { get; set; }

        public void AgregarComponente(Componente componente) {
            //validar
            this.Componentes.Add(componente);
        }


    }
}
