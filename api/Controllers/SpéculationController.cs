using AutoMapper;
using Domain.Commands;
using Domain.Handlers;
using Domain.Interface;
using Domain.Models;
using Domain.Queries;
using Microsoft.AspNetCore.Http;
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
    public class SpéculationController : ControllerBase
    {
        public IGenericRepository<Spéculation> Repository;
        CancellationToken cancellation;
        private readonly IMapper _mapper;


        public SpéculationController(IGenericRepository<Spéculation> _Repository, IMapper mapper)
        {
            Repository = _Repository;
            cancellation = new CancellationToken();
            _mapper = mapper;
        }

        [HttpGet("GetAllSpéculation")]
        public IEnumerable<Spéculation> getAllSpéculation()
        {
            return (new GetListGenericHandler<Spéculation>(Repository).Handle(new GetListGenericQuery<Spéculation>(null, null), cancellation).Result);
        }

        [HttpGet("GetSpéculationById")]
        public Spéculation getAllSpéculationByRequestFolderId(Guid Id)
        {
            return (new GetGenericHandler<Spéculation>(Repository).Handle(new GetGenericQuery<Spéculation>(condition: x => x.IdSpéculation == Id, null), cancellation).Result);
        }


        [HttpPost("PostSpéculation")]
        public async Task<Spéculation> PostSpéculation([FromBody] Spéculation Spéculation)
        {
            var x = new AddGenericCommand<Spéculation>(Spéculation);
            var GenericHandler = new AddGenericHandler<Spéculation>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }
        [HttpPut("PutSpéculation")]
        public async Task<Spéculation> PutSpéculation([FromBody] Spéculation Spéculation)
        {
            var x = new PutGenericCommand<Spéculation>(Spéculation);
            var GenericHandler = new PutGenericHandler<Spéculation>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }

        [HttpDelete("DeleteSpéculation")]
        public async Task<Spéculation> DeleteSpéculation(Guid IdSpéculation)
        {
            var x = new DeleteGenericCommand<Spéculation>(IdSpéculation);
            var GenericHandler = new DeleteGenericHandler<Spéculation>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }
    }
}
    

