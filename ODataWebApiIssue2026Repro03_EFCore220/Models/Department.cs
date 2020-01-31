using System.ComponentModel.DataAnnotations;

namespace ODataWebApiIssue2026Repro03_EFCore220.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
