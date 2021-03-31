using System;

namespace SpeedParking.Domain.Entities
{
    public class Parking : BaseEntities
    {
        public string NameFantasy { get; set; }
        public string CompanyName { get; set; }
        public string CNPJ { get; set; }
        public DateTime FoundationDate { get; set; }
        public Owner Owner { get; set; }
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