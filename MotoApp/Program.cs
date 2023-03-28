using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;
using MotoApp.Repositories.Extensions;

//var itemAdded = new ItemAdded<Employee>(EmployeeAdded);
var repository = new SqlRepository<Employee>(new MotoAppDbContext(), EmployeeAdded);
repository.ItemAdded += RepositoryOnItemAdded;

static void RepositoryOnItemAdded(object? sender, Employee e)
{
    Console.WriteLine($"Employee added => {e.Name} from {sender?.GetType().Name}");
}

static void EmployeeAdded(object item)
{
    var employee = (Employee)item;
    Console.WriteLine($"{employee.Name} added");
}

var employees = new[]
{
    new Employee { Name = "Tomasz" },
    new Employee { Name = "Joanna" },
    new Employee { Name = "Paulina" },
    new Employee { Name = "Krzysztof" }
};

repository.AddBatch(employees);
WriteAllToConsole(repository);


static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

