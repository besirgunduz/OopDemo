namespace OopDemo.Entities
{
    public class Photo : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public virtual City City { get; set; }

    }
}
