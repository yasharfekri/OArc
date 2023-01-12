using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OA.Service.Features.CustomerFeatures.Commands;
using OA.Service.Features.CustomerFeatures.Queries;
using System.Threading.Tasks;

namespace OA.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v{version:apiVersion}/DetailLookup")]
    [ApiVersion("1.0")]
    public class DetailLookupController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

      

        
    }
}
