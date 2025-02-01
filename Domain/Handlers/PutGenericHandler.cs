
using Domain.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public class PutGenericHandler<TEntity> : IRequestHandler<PutGenericCommand<TEntity>, TEntity> where TEntity : class
    {
        private readonly Interface.IGenericRepository<TEntity> Repository;
        public PutGenericHandler(Interface.IGenericRepository<TEntity> Repository)
        {
            this.Repository = Repository;
        }
        public Task<TEntity> Handle(PutGenericCommand<TEntity> request, CancellationToken cancellationToken)
        {
            var result = Repository.Put(request.Entity);
            return Task.FromResult(result);
        }
    }
}
