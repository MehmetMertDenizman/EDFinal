using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string CopanyName { get; set; }
        public string City { get; set; }
        
    }
}
