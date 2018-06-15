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

    public class TareaService : EntityService<Tarea>, ITareaService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly ITareaRepository _TareaRepository;

        public TareaService(IUnitOfWork unitOfWork, ITareaRepository TareaRepository)
            : base(unitOfWork, TareaRepository)
        {
            _unitOfWork = unitOfWork;
            _TareaRepository = TareaRepository;
        }

    }
}