using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;
using MotoApp.Repositories.Extensions;

var repository = new SqlRepository<Employee>(new MotoAppDbContext());

var employees = new[]
{
    new Employee { Name = "Tomasz" },
    new Employee { Name = "Joanna" },
    new Employee { Name = "Paulina" },
    new Employee { Name = "Krzysztof" }
};

repository.AddBatch(employees);
WriteAllToConsole(repository);




//static void AddEmployess(IRepository<Employee> employeeRepository)
//{
//    employeeRepository.Add(new Employee { Name = "Tomasz" });
//    employeeRepository.Add(new Employee { Name = "Joanna" });
//    employeeRepository.Add(new Employee { Name = "Paulina" });
//    employeeRepository.Add(new Employee { Name = "Krzysztof" });
//    employeeRepository.Save();
//}



static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

