﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class DeleteGenericCommand<TEntity> : IRequest<TEntity> where TEntity : class
    {
        public DeleteGenericCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}