using System;
using Microsoft.EntityFrameworkCore;
using Repository.Base;
using Repository.Core;
using Repository.Entities;

namespace Repository.ENtityFramework
{
    public class TestRepository:RepositoryBase<TestEntity,Guid>
    {
        public TestRepository(IDbContext context):base(context)
        {
            context.Set<TestEntity>();
        }

    }
}