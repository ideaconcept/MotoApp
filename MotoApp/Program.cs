using MotoApp;

var stack = new BasicStack();
stack.Push(67.7);
stack.Push(11);
stack.Push(36);
stack.Push(1);

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}

Console.WriteLine($"Sum: {sum}");

var licznik = stack.Count;
Console.WriteLine($"Count: {licznik}");
