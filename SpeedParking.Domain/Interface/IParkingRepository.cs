using SpeedParking.Domain.Entities;
using System.Collections.Generic;

namespace SpeedParking.Domain.Interface
{
    public interface IParkingRepository
    {
        void Add(Parking parking);

        List<Parking> GetAll();
    }
}