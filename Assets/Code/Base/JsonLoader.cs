using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;

namespace Code.Base
{
    public class JsonLoader
    {
        public static async Task<T> LoadAsync<T>(string path)
        {
            Debug.Log("loading " + path);
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                T result = JsonConvert.DeserializeObject<T>(json);
                return result;
            }

            return default;
        }
    }
}