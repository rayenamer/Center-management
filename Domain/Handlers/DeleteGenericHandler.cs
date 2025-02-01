
using Domain.Commands;
using Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public class DeleteGenericHandler<TEntity> : IRequestHandler<DeleteGenericCommand<TEntity>, TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> Repository;
        public DeleteGenericHandler(IGenericRepository<TEntity> Repository)
        {
            this.Repository = Repository;
        }
        public Task<TEntity> Handle(DeleteGenericCommand<TEntity> request, CancellationToken cancellationToken)
        {
            var result = Repository.Delete(request.Id);
            return Task.FromResult(result);
        }
    }
}