using System;
namespace Eways.Infrastructure
{
    public class BaseEntity<TPrimeryKey>
    {
        public TPrimeryKey Id { get; set; }
    }
}

