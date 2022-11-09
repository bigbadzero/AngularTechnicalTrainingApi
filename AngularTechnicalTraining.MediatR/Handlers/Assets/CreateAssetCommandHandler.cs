using AngularTechnicalTraining.MediatR.Commands.Assets;
using AngularTechnicalTrainingApi.Data.GenericRepository;
using AngularTechnicalTrainingApi.Domain.Models;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTraining.MediatR.Handlers.Assets
{
    //public class CreateAssetCommandHandler : IRequestHandler<CreateAssetCommand, Asset>
    //{
    //    private readonly IUnitOfWork _unitOfWork;
    //    private readonly IMapper _mapper;
    //    public CreateAssetCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    //    {
    //        _unitOfWork = unitOfWork;
    //        _mapper = mapper;
    //    }

        public Task<Asset> Handle(CreateAssetCommand request, CancellationToken cancellationToken)
        {
            
        }
    }
}
