using MediatR;
using SpeedParking.Application.Model;
using SpeedParking.Application.Request;
using SpeedParking.Domain.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SpeedParking.Application.RequestHandler
{
    public class GetOwnerRequestHandler : IRequestHandler<GetOwnerRequest, List<GetOwner>>
    {
        private readonly IOwnerRepository _ownerRepository;
        public GetOwnerRequestHandler(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }
        public Task<List<GetOwner>> Handle(GetOwnerRequest request, CancellationToken cancellationToken)
        {
            var owner = _ownerRepository.GetAll();

            var getOwnerNameList = owner
                .Select(s => new GetOwner(s.Name))
                .ToList();

            return Task.FromResult(getOwnerNameList);
        }
    }
}