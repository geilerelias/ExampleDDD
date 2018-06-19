using Domain.Abstracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implements
{
    public class AgregarComponenteAMaquinariaService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMaquinariaRepository _maquinariaRepository;

        public AgregarComponenteAMaquinariaService(IUnitOfWork unitOfWork, IMaquinariaRepository maquinariaRepository)
        {
            _unitOfWork = unitOfWork;
            _maquinariaRepository = maquinariaRepository;
        }
        public AgregarComponenteAMaquinariaResponse Ejecutar(AgregarComponenteAMaquinariaRequest request)
        {
            Maquinaria maquina = _maquinariaRepository.FindBy(t => t.Placa.Equals(request.MaquinariaPlaca) ).FirstOrDefault();
            if (maquina != null)
            {
                var componente = new Componente { descripcion = request.Descripcion, nombre = request.Descripcion, referencia = request.Referencia };
                maquina.AgregarComponente(componente);
                _maquinariaRepository.Edit(maquina);
                _unitOfWork.Commit();
                return new AgregarComponenteAMaquinariaResponse() { Mensaje = $"Su ha agregado un nuevo componete {componente.nombre} a la maquina {maquina.Placa}." };
            }
            else
            {
                return new AgregarComponenteAMaquinariaResponse() { Mensaje = $"Id de Máquina no válido." };
            }
        }

    }
    public class AgregarComponenteAMaquinariaRequest
    {

        public String MaquinariaPlaca;

        public string Nombre;

        public string Descripcion;

        public string Referencia;
    }
    public class AgregarComponenteAMaquinariaResponse
    {
        public string Mensaje { get; set; }
    }
}
