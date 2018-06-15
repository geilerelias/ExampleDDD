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

    public class MaquinariaService : EntityService<Maquinaria>, IMaquinaria
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMaquinariaRepository _maquinariaRepository;

        public MaquinariaService(IUnitOfWork unitOfWork, IMaquinariaRepository maquinariaRepository)
            : base(unitOfWork, maquinariaRepository)
        {
            _unitOfWork = unitOfWork;
            _maquinariaRepository = maquinariaRepository;
        }

    }
}