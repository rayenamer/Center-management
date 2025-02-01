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
    public class RotationController : ControllerBase
    {
        public IGenericRepository<Rotation> Repository;
        CancellationToken cancellation;
        private readonly IMapper _mapper;


        public RotationController(IGenericRepository<Rotation> _Repository, IMapper mapper)
        {
            Repository = _Repository;
            cancellation = new CancellationToken();
            _mapper = mapper;
        }

        [HttpGet("GetAllRotations")]
        public IEnumerable<Rotation> getAllRotations()
        {
            return (new GetListGenericHandler<Rotation>(Repository).Handle(new GetListGenericQuery<Rotation>(null, null), cancellation).Result);
        }

        [HttpGet("GetRotationById")]
        public Rotation getAllRotationsByRequestFolderId(Guid Id)
        {
            return (new GetGenericHandler<Rotation>(Repository).Handle(new GetGenericQuery<Rotation>(condition: x => x.IdRotation == Id, null), cancellation).Result);
        }

       
        [HttpPost("PostRotation")]
        public async Task<Rotation> PostRotation([FromBody] Rotation Rotation)
        {
            var x = new AddGenericCommand<Rotation>(Rotation);
            var GenericHandler = new AddGenericHandler<Rotation>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }
        [HttpPut("PutRotation")]
        public async Task<Rotation> PutRotation([FromBody] Rotation Rotation)
        {
            var x = new PutGenericCommand<Rotation>(Rotation);
            var GenericHandler = new PutGenericHandler<Rotation>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }

        [HttpDelete("DeleteRotation")]
        public async Task<Rotation> DeleteRotation(Guid IdRotation)
        {
            var x = new DeleteGenericCommand<Rotation>(IdRotation);
            var GenericHandler = new DeleteGenericHandler<Rotation>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }
    }
}
