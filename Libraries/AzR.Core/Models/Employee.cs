using System.ComponentModel.DataAnnotations;

namespace AzR.Core.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
    }
}
