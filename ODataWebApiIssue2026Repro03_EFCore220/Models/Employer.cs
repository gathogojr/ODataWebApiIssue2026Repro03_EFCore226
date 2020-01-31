using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODataWebApiIssue2026Repro03_EFCore220.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }
    }
}
