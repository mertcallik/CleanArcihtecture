using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;

public sealed record CreateCarCommand(string Model,string Name, int EnginePower):IRequest<MessageResponse>
{
    
}