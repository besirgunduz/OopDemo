namespace OopDemo.Entities
{
    public class CityDetailDto : BaseEntity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string UserName { get; set; }
        public UserRole UserRole { get; set; }
    }
}
