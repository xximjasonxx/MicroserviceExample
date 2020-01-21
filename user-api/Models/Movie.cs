namespace UserApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object? obj)
        {
            return ((Movie)obj)?.Id == Id;
        }
    }
}