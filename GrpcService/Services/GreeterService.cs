using Grpc.Core;
using GrpcService;

namespace GrpcService.Services;
public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<SampleResponse> GetFullName(SampleRequest request, ServerCallContext context)
    {
        return Task.FromResult(new SampleResponse
        {
            FullName = $"{request.FirstName} {request.LastName}"
        });
    }
}
