using MediatR;
using SpeedParking.Application.Command;
using SpeedParking.Domain.Entities;
using SpeedParking.Domain.Interface;
using System.Threading;
using System.Threading.Tasks;

namespace SpeedParking.Application.CommandHandler
{
    public class AddOwnerCommandHandler : IRequestHandler<AddOwnerCommand, Unit>
    {
        private readonly IOwnerRepository _ownerRepository;
        public AddOwnerCommandHandler(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }
        public Task<Unit> Handle(AddOwnerCommand request, CancellationToken cancellationToken)
        {
            var owner = new Owner()
            {
                Name = request.Name,
                Surname = request.Surname,
                DateBirth = request.DateBirth,
                CPF = request.CPF,
                Email = request.Email,
                Country = request.Country,
                City = request.City,
                State = request.State,
                CEP = request.CEP,
                Neighborhood = request.Neighborhood,
                Street = request.Street,
                Number = request.Number,
                Complement = request.Complement
            };
            
            _ownerRepository.Add(owner);

            return Task.FromResult(Unit.Value);
        }
    }
}