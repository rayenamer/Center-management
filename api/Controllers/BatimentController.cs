using AutoMapper;
using Domain.Commands;
using Domain.Dtos;
using Domain.Handlers;
using Domain.Interface;
using Domain.Models;
using Domain.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatimentController : ControllerBase
    {
        public IGenericRepository<Batiment> Repository;
        CancellationToken cancellation;
        private object mapper;
        private readonly IMapper _mapper;


        public BatimentController(IGenericRepository<Batiment> _Repository, IMapper mapper)
        {
            Repository = _Repository;
            cancellation = new CancellationToken();
            _mapper = mapper;
        }

        [HttpGet("GetAllBatiment")]
        public IEnumerable<Batiment> getAllBatiment()
        {
            return (new GetListGenericHandler<Batiment>(Repository).Handle(new GetListGenericQuery<Batiment>(null, null), cancellation).Result);
        }

        [HttpGet("GetBatimentById")]
        public BatimentDto getAllBatimentByRequestFolderId(Guid Id)
        {
            return _mapper.Map<BatimentDto>(new GetGenericHandler<Batiment>(Repository).Handle(new GetGenericQuery<Batiment>(condition: x => x.Id_batiment == Id, includes: src => src.Include(x => x.Centre) ), cancellation).Result);
        }


        [HttpPost("PostBatiment")]
        public async Task<Batiment> PostBatiment([FromBody] Batiment Batiment)
        {
            var x = new AddGenericCommand<Batiment>(Batiment);
            var GenericHandler = new AddGenericHandler<Batiment>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }
        [HttpPut("PutBatiment")]
        public async Task<Batiment> PutBatiment([FromBody] Batiment Batiment)
        {
            var x = new PutGenericCommand<Batiment>(Batiment);
            var GenericHandler = new PutGenericHandler<Batiment>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }

        [HttpDelete("DeleteBatiment")]
        public async Task<Batiment> DeleteBatiment(Guid IdBatiment)
        {
            var x = new DeleteGenericCommand<Batiment>(IdBatiment);
            var GenericHandler = new DeleteGenericHandler<Batiment>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }
    }
}
