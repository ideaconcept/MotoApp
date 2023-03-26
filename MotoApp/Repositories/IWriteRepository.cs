﻿using MotoApp.Entities;

namespace MotoApp.Repositories
{
    public interface IWriteRepository<in T> where T : class, IEntity
    {
        void Add(T iteem);
        void Remove(T iteem);
        void Save();
    }
}
