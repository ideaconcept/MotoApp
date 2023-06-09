﻿namespace MotoApp.Entities
{
    public class Employee : EntityBase
    {
        public string? Name { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {Name}";
    }
}
