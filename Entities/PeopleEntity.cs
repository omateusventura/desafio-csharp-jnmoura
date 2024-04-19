namespace API.Models
{
    public class PeopleEntity
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string dateofbirth { get; set; }
        public int inactive { get; set; }
        public int nationality { get; set; }
        public string document { get; set; }
        public string passport { get; set; } 
    }
}
