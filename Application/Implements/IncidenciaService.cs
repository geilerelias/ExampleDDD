using Application.Base;
using Application.Contracts;
using Domain.Abstracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implements
{

    public class IncidenciaService : EntityService<Incidencia>, IIncidenciaService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IIncidenciaRepository _insidenciaRepository;

        public IncidenciaService(IUnitOfWork unitOfWork, IIncidenciaRepository insidenciaRepository)
            : base(unitOfWork, insidenciaRepository)
        {
            _unitOfWork = unitOfWork;
            _insidenciaRepository = insidenciaRepository;
        }

    }
}