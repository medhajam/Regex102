using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Regex102.Application.UseCases.Matches;
using Regex102.Application.UseCases.Substitutions;
using Regex102.Domain.Contracts.Matches;
using Regex102.Domain.Contracts.Substutution;

namespace Regex102.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(DependencyInjection).Assembly);
            services.AddScoped<IRegexMatcher, MatchRegex>();
            services.AddScoped<IRegexSubstutor, SubstituteRegex>();
            return services;
        }
    }
}
