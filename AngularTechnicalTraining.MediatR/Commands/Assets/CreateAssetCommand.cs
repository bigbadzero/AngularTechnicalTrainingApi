using AngularTechnicalTrainingApi.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTechnicalTraining.MediatR.Commands.Assets
{
    public class CreateAssetCommand : IRequest<Asset>
    {
        public Asset Asset { get; set; }
    }
}
