namespace Blog.Core.Entities
{
    public abstract class EntityBase : IEntityBase
    {
        //// Bu tarz bir yapı da kullanılabilir.
        //public EntityBase()
        //{
        //    Id = Guid.NewGuid();
        //    CreatedDate = DateTime.Now;
        //    isDeleted

        //}

        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual string CreatedBy { get; set; }
        public virtual string? UpdatedBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? UpdatedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool isDeleted { get; set; } = false;

    }
}
