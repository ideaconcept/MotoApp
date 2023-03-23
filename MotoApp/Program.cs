using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new GenericRepository<Employee, int>();

employeeRepository.Add(new Employee { FirstName = "Jacek" });
employeeRepository.Add(new Employee { FirstName = "Aldonka" });
employeeRepository.Add(new Employee { FirstName = "Julia" });
employeeRepository.Add(new Employee { FirstName = "Łukasz" });
employeeRepository.Save();

