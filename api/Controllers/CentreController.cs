using AutoMapper;
using Domain.Commands;
using Domain.Handlers;
using Domain.Interface;
using Domain.Models;
using Domain.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CentreController : ControllerBase
    {
        public IGenericRepository<Centre> Repository;
        CancellationToken cancellation;
        private readonly IMapper _mapper;


        public CentreController(IGenericRepository<Centre> _Repository, IMapper mapper)
        {
            Repository = _Repository;
            cancellation = new CancellationToken();
            _mapper = mapper;
        }

        [HttpGet("GetAllCentres")]
        public IEnumerable<Centre> getAllCentres()
        {
            return (new GetListGenericHandler<Centre>(Repository).Handle(new GetListGenericQuery<Centre>(null, null), cancellation).Result);
        }

        [HttpGet("GetCentreById")]
        public Centre getAllCentresByRequestFolderId(Guid Id)
        {
            return (new GetGenericHandler<Centre>(Repository).Handle(new GetGenericQuery<Centre>(condition: x => x.IdCentre == Id, null), cancellation).Result);
        }

       
        [HttpPost("PostCentre")]
        public async Task<Centre> PostCentre([FromBody] Centre Centre)
        {
            var x = new AddGenericCommand<Centre>(Centre);
            var GenericHandler = new AddGenericHandler<Centre>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }
        [HttpPut("PutCentre")]
        public async Task<Centre> PutCentre([FromBody] Centre Centre)
        {
            var x = new PutGenericCommand<Centre>(Centre);
            var GenericHandler = new PutGenericHandler<Centre>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }

        [HttpDelete("DeleteCentre")]
        public async Task<Centre> DeleteCentre(Guid IdCentre)
        {
            var x = new DeleteGenericCommand<Centre>(IdCentre);
            var GenericHandler = new DeleteGenericHandler<Centre>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }
    }
}
