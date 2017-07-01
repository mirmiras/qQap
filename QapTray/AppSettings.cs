using Newtonsoft.Json;
using System.IO;

namespace QapTray
{
    public class AppSettings<T> where T : new()
    {
        private const string DefaultFilename = "app.json";

        public void Save(string fileName = DefaultFilename)
        {

            File.WriteAllText(fileName, JsonConvert.SerializeObject(this, Formatting.Indented));
        }

        public static void Save(T pSettings, string fileName = DefaultFilename)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(pSettings, Formatting.Indented));
        }

        public static T Load(string fileName = DefaultFilename)
        {
            T t = new T();
            if (File.Exists(fileName))
            {
                var readAllText = File.ReadAllText(fileName);
                t = (T)JsonConvert.DeserializeObject(readAllText, typeof(T));
            }
            return t;
        }
    }
}
