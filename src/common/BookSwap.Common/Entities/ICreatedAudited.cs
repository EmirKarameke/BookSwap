namespace BookSwap.Common.Entities
{
    public interface ICreatedAudited<T>
    {
        public DateTime CreateTime { get; set; }
        public T CreatorUser { get; set; }
    }
}
