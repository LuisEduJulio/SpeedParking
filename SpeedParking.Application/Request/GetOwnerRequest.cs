using MediatR;
using SpeedParking.Application.Model;
using System.Collections.Generic;

namespace SpeedParking.Application.Request
{
    public class GetOwnerRequest : IRequest<List<GetOwner>>
    {
    }
}