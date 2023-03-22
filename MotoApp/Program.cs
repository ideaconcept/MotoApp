using MotoApp.Entities;
using MotoApp.Entities.Repositories;

var employeeRepository = new EmployeeRepository();

employeeRepository.Add(new Employee { FirstName = "Jacek" });
employeeRepository.Add(new Employee { FirstName = "Aldonka" });
employeeRepository.Add(new Employee { FirstName = "Julia" });
employeeRepository.Add(new Employee { FirstName = "Łukasz" });
employeeRepository.Save();

