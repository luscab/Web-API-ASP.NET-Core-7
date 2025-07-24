using WebAPI.Domain.DTOs;
using WebAPI.Domain.Model;

namespace WebAPI.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> Get()
        {
            return _context.Employees.ToList();
        }

        public Employee? Get(int id)
        {
            return _context.Employees.Find(id);
        }

        public List<EmployeeDTO> Get(int pageNumber, int pageQuantity)
        {
            return _context.Employees.Skip(pageNumber * pageQuantity)
                .Take(pageQuantity)
                .Select(e => 
                new EmployeeDTO()
                {
                    Id = e.id,
                    Name = e.name,
                    Age = e.age,
                    Photo = e.photo
                }).ToList();
        }
    }
}
