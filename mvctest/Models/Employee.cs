namespace mvctest.Models
{
    public class Employee
    {
        public Employee()
        {
            Id = 0;
            Name = "Demo";
            LastName = string.Empty;
            Age = 0;
            City = "Lima";
            Country = "Peru";
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
