using Newtonsoft.Json;
namespace _2048WindowsFormsApp
{
    public class JsonSerializer<T>
    {
        public string? Serialize(T obj) => JsonConvert.SerializeObject(obj) ?? String.Empty;
        public T? Deserialize(string json) => JsonConvert.DeserializeObject<T>(json);
    }
}
