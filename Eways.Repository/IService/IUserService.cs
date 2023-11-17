using System;
namespace Eways.Repository.IService
{
    public interface IUserService
    {
        Task AddUserAsync(UserDto user);

    }
}

