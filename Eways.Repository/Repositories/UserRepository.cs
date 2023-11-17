using System;
using Eways.Infrastructure;
using Eways.Repository.Context;
using Eways.Repository.Entities;
using Eways.Repository.IRepositories;

namespace Eways.Repository.Repositories
{
	public class UserRepository : BaseRepository<User>, IUserRepository
	{
		public UserRepository(AppDbContext context) : base(context)
		{
		}
	}
}

