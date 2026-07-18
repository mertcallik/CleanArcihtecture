using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Entities;

public sealed class Car:Entity
{
    public string Model { get; private set; }
    public string Name { get; private set; }
    public int EnginePower { get; private set; }
}

