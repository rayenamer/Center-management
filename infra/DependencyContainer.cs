


using DATA.Repositories;
using Domain.Commands;
using Domain.Handlers;
using Domain.Interface;
using Domain.Models;
using Domain.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace infra
{
   
            public class DependencyContainer
    {
               public static void RegisterService(IServiceCollection services)
                {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddTransient<IGenericRepository<Batiment>, GenericRepository<Batiment>>();
            services.AddTransient<IGenericRepository<Centre>, GenericRepository<Centre>>();
       
         
           

           
      services.AddTransient<IRequestHandler<GetListGenericQuery<Batiment>, IEnumerable<Batiment>>, GetListGenericHandler<Batiment>>();
         services.AddTransient<IRequestHandler<GetGenericQuery<Batiment>, Batiment>, GetGenericHandler<Batiment>>();
            services.AddTransient<IRequestHandler<GetListGenericQuery<Centre>, IEnumerable<Centre>>, GetListGenericHandler<Centre>>();
            services.AddTransient<IRequestHandler<GetGenericQuery<Centre>, Centre>, GetGenericHandler<Centre>>();



            services.AddTransient<IRequestHandler<PutGenericCommand<Batiment>, Batiment>, PutGenericHandler<Batiment>>();
            services.AddTransient<IRequestHandler<DeleteGenericCommand<Batiment>, Batiment>, DeleteGenericHandler<Batiment>>();
            services.AddTransient<IRequestHandler<AddGenericCommand<Batiment>, Batiment>, AddGenericHandler<Batiment>>();
          services.AddTransient<IRequestHandler<DeleteGenericCommand<Batiment>, Batiment>, DeleteGenericHandler<Batiment>>();
            services.AddTransient<IRequestHandler<AddGenericCommand<Batiment>, Batiment>, AddGenericHandler<Batiment>>();


         


            services.AddTransient<IRequestHandler<PutGenericCommand<Centre>, Centre>, PutGenericHandler<Centre>>();
            services.AddTransient<IRequestHandler<DeleteGenericCommand<Centre>, Centre>, DeleteGenericHandler<Centre>>();
            services.AddTransient<IRequestHandler<AddGenericCommand<Centre>, Centre>, AddGenericHandler<Centre>>();
            services.AddTransient<IRequestHandler<DeleteGenericCommand<Centre>, Centre>, DeleteGenericHandler<Centre>>();
            services.AddTransient<IRequestHandler<AddGenericCommand<Centre>, Centre>, AddGenericHandler<Centre>>();
        }
        }
    
}