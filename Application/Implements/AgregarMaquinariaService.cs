using Domain.Abstracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implements
{
    public class AgregarMaquinariaService
    {


        readonly IUnitOfWork _unitOfWork;
        readonly IMaquinariaRepository _maquinariaRepository;

        public AgregarMaquinariaService(IUnitOfWork unitOfWork, IMaquinariaRepository maquinariaRepository)
        {
            _unitOfWork = unitOfWork;
            _maquinariaRepository = maquinariaRepository;
        }
        public AgregarMaquinariaResponse Ejecutar(AgregarMaquinariaRequest request)
        {
            Maquinaria maquina = _maquinariaRepository.FindBy(t => t.Placa.Equals(request.Placa)).FirstOrDefault();
            if (maquina == null)
            {
                maquina = new Maquinaria();
                maquina.Placa = request.Placa;
                maquina.Marca = request.Marca;
                maquina.Linea = request.Linea;
                maquina.Modelo = request.Modelo;
                maquina.Color = request.Color;
                maquina.FechaAdquisicion = request.FechaAdquisicion;
                maquina.Chasi = request.Chasi;
                maquina.Motor = request.Motor;
                _maquinariaRepository.Add(maquina);
                _unitOfWork.Commit();
                return new AgregarMaquinariaResponse() { Mensaje = $"Se ha agregado la maquina {maquina.Placa} satisfatoriamente." };
            }
            else
            {
                return new AgregarMaquinariaResponse() { Mensaje = $"Id de Máquina ya se encuentra registrado." };
            }
        }

    }

    public class AgregarMaquinariaRequest
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string FechaAdquisicion { get; set; }
        public string Chasi { get; set; }
        public string Motor { get; set; }
    }

    public class AgregarMaquinariaResponse
    {
        public string Mensaje { get; set; }
    }
}
