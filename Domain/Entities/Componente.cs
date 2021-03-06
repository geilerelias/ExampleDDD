﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Componente : Entity<long>
    {
        [Required]
        [MaxLength(50)]
        public string nombre;

        [Required]
        [MaxLength(50)]
        public string descripcion;

        [Required]
        [MaxLength(50)]
        public string referencia;

        public Maquinaria maquinaria { get; set; }
    }
}
