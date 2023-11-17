using System;
using Eways.Infrastructure;

namespace Eways.Repository.Entities
{
    public class User : BaseEntity<long>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public long CostumerCode { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }
    }
}

