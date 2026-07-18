using MediatR;
using CleanArchitecture.Domain.Dtos;
namespace CleanArchitecture.Application.Features.CarFeatures.Commands;

public sealed record CreateCarCommand(string Model,string Name, int HorsePower):IRequest<MessageResponse>
{
    
}