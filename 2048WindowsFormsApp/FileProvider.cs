using System.Text;

namespace _2048WindowsFormsApp
{
    public class FileProvider
    {
        public static void Append(string filename, string data)
        {
            var writer = new StreamWriter(filename,true,Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }
        public static string GetValue(string filename)
        {
            var reader = new StreamReader(filename);
            var data = reader.ReadToEnd();
            reader.Close();
            return data;
        }
        public static bool IsFileCreated(string filename) => File.Exists(filename);
        public static bool IsFileEmpty(string filename)
        {
            var fileInfo = new FileInfo(filename);
            if (fileInfo.Length == 0) return true; 
            return false;
        }
        public static void Clear(string fileName) => File.WriteAllText(fileName, String.Empty);

    }
}
