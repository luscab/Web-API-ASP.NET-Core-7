namespace WebAPI.Domain.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string? Photo { get; set; }
        public EmployeeDTO() { }
        public EmployeeDTO(int id, string name, int age, string? photo)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
            Photo = photo;
        }
    }
}
