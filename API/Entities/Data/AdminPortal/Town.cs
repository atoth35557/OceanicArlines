namespace API.Entities.Data.AdminPortal
{
    public class Town
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Town>? Connections { get; set; }
    }
}
