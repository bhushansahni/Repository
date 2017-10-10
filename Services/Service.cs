using System;
using Repository.Base;
using Repository.Entities;

namespace Repository
{
    public class TestService
    {
         IUnitOfWork _uow;
         public TestService(IUnitOfWork uow)
         {
             _uow=uow;
         }
        public void Add(TestEntity entity)
        {
            _uow.Repository<TestEntity, Guid>().Add(entity);
            _uow.Save();
        }
    }
}