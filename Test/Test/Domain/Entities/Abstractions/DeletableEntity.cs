namespace Test.Domain.Entities.Abstractions
{
    public class DeletableEntity : Entity, IDeletable
    {
        public bool IsDeleted { get; set; }
    }
}