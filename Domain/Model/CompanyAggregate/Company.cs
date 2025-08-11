using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Domain.Model.CompanyAggregate
{
    [Table("company")]
    public class Company
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
