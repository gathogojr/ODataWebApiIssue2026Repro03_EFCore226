using ODataWebApiIssue2026Repro03_EFCore220.DataSources;
using ODataWebApiIssue2026Repro03_EFCore220.Models;
using System;
using System.Linq;

namespace ODataWebApiIssue2026Repro03_EFCore220
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Run migrations first -> Using Package Manager Console: Update-Database
            using (var db = new AppDbContext())
            {
                var query = db.Employers.Take(1).Select(d => new Employer
                {
                    Id = d.Id,
                    Name = d.Name,
                    Employees = d.Employees.Take(3).Select(e => new Employee
                    {
                        Id = e.Id,
                        Name = e.Name,
                        EmployerId = e.EmployerId,
                        DepartmentId = e.DepartmentId,
                        Department = e.Department
                    })
                });

                var result = query.ToList();
            }

            Console.Read();
        }
    }
}
