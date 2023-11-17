using System;
using Eways.Repository.Entities;

namespace Eways.Repository.Mapper
{
    public static class UserMapper
    {

        public static User ToEntity(this UserDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new User
            {
                Name = dto.Name,
                LastName = dto.LastName,
                CostumerCode = dto.EmployeeId,
                BirthDate = dto.BirthDate,
                Description = dto.Description,
            };
        }
    }
}

