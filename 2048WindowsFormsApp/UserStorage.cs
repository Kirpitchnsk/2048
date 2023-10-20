namespace _2048WindowsFormsApp
{
    public class UserStorage
    {
        public const string FileNameJson = "user.json";
        public static List<User> Users { get; private set; }= new List<User>();
        public UserStorage()
        {
            GetFromFileJson();
        }
        private static void GetFromFileJson()
        {
            var serializer = new JsonSerializer<User>();
            if (FileProvider.IsFileCreated(FileNameJson) && !FileProvider.IsFileEmpty(FileNameJson))
            {
                var jsonData = FileProvider.GetValue(FileNameJson).Split("\n");
                foreach (var item in jsonData)
                {
                    if (item != String.Empty)
                    {
                        var user = serializer.Deserialize(item);
                        Users.Add(user);
                    }
                }
            }
        }
        public static void Add(User user)
        {
            var serializer = new JsonSerializer<User>();
            Users.Add(user);
            var jsonInfo = serializer.Serialize(user);
            FileProvider.Append(FileNameJson, jsonInfo);
        }
        public static void Remove(User user)
        {
            Users.Remove(user);
            FileProvider.Clear(FileNameJson);
            var serializer = new JsonSerializer<User>();
            foreach (var item in Users)
            {
                var itemJson = serializer.Serialize(item);
                FileProvider.Append(FileNameJson, itemJson);
            }
        }
        public static void SortStorage() => Users.Sort();
    }
}