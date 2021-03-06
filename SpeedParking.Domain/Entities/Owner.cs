using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpeedParking.Domain.Entities
{
    [Table("Owner")]
    public class Owner : BaseEntities
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateBirth { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CEP { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
    }
}