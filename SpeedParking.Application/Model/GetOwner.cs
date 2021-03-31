namespace SpeedParking.Application.Model
{
    public class GetOwner
    {
        public GetOwner(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}