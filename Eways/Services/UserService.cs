using System;
using Eways.Infrastructure;
using Eways.Repository;
using Eways.Repository.IRepositories;
using Eways.Repository.IService;
using Eways.Repository.Mapper;

namespace Eways.Services
{
    public class UserService : IUserService
    {
        public IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        //submit Action
        public async Task AddUserAsync(UserDto user)
        {
            await _repository.AddAsync(user.ToEntity());
        }
    }
}

