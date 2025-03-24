namespace ThirdSemesterIT.A11UserLinkedList
{
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public User(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public override bool Equals(object? obj)
        {
            if (obj is User other) { 
                return Name == other.Name && Id == other.Id;
            }
            return false;
        }
    }
}