using SpeedParking.Domain.Entities;
using System.Collections.Generic;

namespace SpeedParking.Domain.Interface
{
    public interface IOwnerRepository
    {
        void Add(Owner parking);

        List<Owner> GetAll();
    }
}