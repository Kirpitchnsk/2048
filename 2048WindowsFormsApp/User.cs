namespace _2048WindowsFormsApp
{
    [Serializable]
    public class User : IComparable<User>
    {
        public string? Name { get; private set; }
        public int Record { get; private set; }
        public User(string? name, int record)
        {
            Name = name;
            Record = record;
        }
        public override string ToString()
        {
            return Name + ";" + Record;
        }
        public int CompareTo(User other)
        {
            if(other == null) return 1;
            return -Record.CompareTo(other.Record);
        }
    }
}