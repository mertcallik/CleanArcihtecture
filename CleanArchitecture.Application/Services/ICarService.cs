using CleanArchitecture.Application.Features.CarFeatures.Commands;

namespace CleanArchitecture.Application.Services;

public interface ICarService
{
    Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken);
}