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

    public class ComponenteService : EntityService<Componente>, IComponenteService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IComponenteRepository _componenteRepository;

        public ComponenteService(IUnitOfWork unitOfWork, IComponenteRepository componenteRepository)
            : base(unitOfWork, componenteRepository)
        {
            _unitOfWork = unitOfWork;
            _componenteRepository = componenteRepository;
        }

    }
}