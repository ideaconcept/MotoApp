using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new GenericRepository<Employee, int>();

employeeRepository.Add(new Employee { Name = "Jacek" });
employeeRepository.Add(new Employee { Name = "Aldonka" });
employeeRepository.Add(new Employee { Name = "Julia" });
employeeRepository.Add(new Employee { Name = "Łukasz" });
employeeRepository.Save();

