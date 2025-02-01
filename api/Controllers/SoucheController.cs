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
    public class SoucheController : ControllerBase
    {
        public IGenericRepository<Souche> Repository;
        CancellationToken cancellation;
        private readonly IMapper _mapper;


        public SoucheController(IGenericRepository<Souche> _Repository, IMapper mapper)
        {
            Repository = _Repository;
            cancellation = new CancellationToken();
            _mapper = mapper;
        }

        [HttpGet("GetAllSouches")]
        public IEnumerable<Souche> getAllSouches()
        {
            return (new GetListGenericHandler<Souche>(Repository).Handle(new GetListGenericQuery<Souche>(null, null), cancellation).Result);
        }

        [HttpGet("GetSoucheById")]
        public Souche getAllSouchesByRequestFolderId(Guid Id)
        {
            return (new GetGenericHandler<Souche>(Repository).Handle(new GetGenericQuery<Souche>(condition: x => x.IdSouche == Id, null), cancellation).Result);
        }


        [HttpPost("PostSouche")]
        public async Task<Souche> PostSouche([FromBody] Souche Souche)
        {
            var x = new AddGenericCommand<Souche>(Souche);
            var GenericHandler = new AddGenericHandler<Souche>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }
        [HttpPut("PutSouche")]
        public async Task<Souche> PutSouche([FromBody] Souche Souche)
        {
            var x = new PutGenericCommand<Souche>(Souche);
            var GenericHandler = new PutGenericHandler<Souche>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }

        [HttpDelete("DeleteSouche")]
        public async Task<Souche> DeleteSouche(Guid IdSouche)
        {
            var x = new DeleteGenericCommand<Souche>(IdSouche);
            var GenericHandler = new DeleteGenericHandler<Souche>(Repository);
            return await GenericHandler.Handle(x, cancellation);
        }
    }
}

    

