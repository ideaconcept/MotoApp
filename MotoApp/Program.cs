using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());

AddEmployess(employeeRepository);
AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);


static void AddEmployess(IRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { Name = "Tomasz" });
    employeeRepository.Add(new Employee { Name = "Joanna" });
    employeeRepository.Add(new Employee { Name = "Paulina" });
    employeeRepository.Add(new Employee { Name = "Krzysztof" });
    employeeRepository.Save();
}

static void AddManagers(IWriteRepository<Manager> managerRepository)    
{
    managerRepository.Add(new Manager { Name = "Jacek" });
    managerRepository.Add(new Manager { Name = "Aldonka" });
    managerRepository.Add(new Manager { Name = "Julia" });
    managerRepository.Add(new Manager { Name = "Łukasz" });
    managerRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

