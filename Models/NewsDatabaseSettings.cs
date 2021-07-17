namespace NewsApi.Models
{
    public class NewsDatabaseSettings : INewsDatabaseSettings
    {
        public string NewsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface INewsDatabaseSettings
    {
        string NewsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}